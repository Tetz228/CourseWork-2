﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;
using MaterialSkin.Controls;
using MaterialSkin;
using CourseWork.Main;

namespace CourseWork
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // Вызов всех проверок и переход к форме подтвержения почты 
        private void ButtonReg_Click(object sender, EventArgs e)
        {
            if (!CheckNullAndSpace())
                return;
            else
            if (!CheckLogAndPassLength())
                return;
            else
            if (!ValidationLogin())
            {
                labelValidRegLog.Text = "Некорректный логин.";
                labelValidRegLog.Show();
                return;
            }
            else
            if (!LoginOriginality())
                return;
            else
            if (!ValidationPassword())
            {
                labelValidRegPass.Text = "Некорректный пароль. Пароль\nдолжен быть минимум с одной\nцифрой,одной заглавной и\nодной строчной буквой.";
                labelValidRegPass.Show();
                return;
            }
            else
            if (!ValidationEmail())
            {
                labelValidEmail.Text = "Некорректная почта";
                labelValidEmail.Show();

                return;
            }
            else
            if (!MailOriginality())
                return;
            else
            {
                Values.RegEmail = TextBoxEmail.Text;

                ConfirmationMailForm mailForm = new ConfirmationMailForm();

                mailForm.Left = this.Left;
                mailForm.Top = this.Top;

                this.Hide();

                mailForm.ShowDialog();

                if (Values.СorrectCode == "Сorrect code")
                    Registration();
            }
        }

        // Проверка TextBox`ов на пустоту
        private bool CheckNullAndSpace()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(TextBoxLname.Text))
            {
                labelValidLname.Text = "Введите фамилию";
                labelValidLname.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxFname.Text))
            {
                labelValidFname.Text = "Введите имя";
                labelValidFname.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxRegLog.Text))
            {
                labelValidRegLog.Text = "Введите логин";
                labelValidRegLog.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxRegPass.Text))
            {
                labelValidRegPass.Text = "Введите пароль";
                labelValidRegPass.Show();
                
                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxEmail.Text))
            {
                labelValidEmail.Text = "Введите почту";
                labelValidEmail.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxRegPassRepeat.Text))
            {
                labelValidRegPassRepeat.Text = "Введите ещё раз пароль";
                labelValidRegPassRepeat.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }

        // Проверка логина и пароля
        private bool CheckLogAndPassLength()
        {
            if (TextBoxRegLog.Text.Length < 4 && TextBoxRegPass.Text.Length < 6)
            {
                labelValidRegLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidRegLog.Show();

                labelValidRegPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidRegPass.Show();

                return false;
            }
            else
            if (TextBoxRegLog.Text.Length < 4)
            {
                labelValidRegLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidRegLog.Show();

                return false;
            }
            else

            if (TextBoxRegPass.Text.Length < 6)
            {
                labelValidRegPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidRegPass.Show();

                return false;
            }
            else

            if (TextBoxRegPass.Text != TextBoxRegPassRepeat.Text)
            {
                labelValidRegPassRepeat.Text = "Пароли должны совпадать";
                labelValidRegPassRepeat.Show();
                return false;
            }
            return true;
        }

        // Валидация логина
        private bool ValidationLogin()
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9]{3,30}$";

            Match isMatch = Regex.Match(TextBoxRegLog.Text, pattern);

            return isMatch.Success;
        }

        // Проверка на уникальность логина
        private bool LoginOriginality()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT login " +
                "FROM Users " +
                "WHERE login = @log", connection.GetSqlConnect());
            selectLog.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = TextBoxRegLog.Text.Trim();

            adapter.SelectCommand = selectLog;
            adapter.Fill(table);

            connection.CloseConnect();

            if (table.Rows.Count > 0)
            {
                labelValidRegLog.Text = "Пользователь с таким логином\nуже существует!";
                labelValidRegLog.Show();
                return false;
            }
            else
                return true; 
        }

        // Валидация пароля
        // От 6 до 35 символов с минимум одной цифрой, одной заглавной и одной строчной буквой
        private bool ValidationPassword()
        {
            string pattern = @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,35})";

            Match isMatch = Regex.Match(TextBoxRegPass.Text, pattern);

            return isMatch.Success;
        }

        // Валидация почты
        private bool ValidationEmail()
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(TextBoxEmail.Text, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        // Проверка на уникальность почты
        private bool MailOriginality()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT Email " +
                "FROM Employees " +
                "WHERE Email = @email", connection.GetSqlConnect());
            selectLog.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = TextBoxEmail.Text.Trim();

            adapter.SelectCommand = selectLog;
            adapter.Fill(table);

            connection.CloseConnect();

            if (table.Rows.Count > 0)
            {
                labelValidEmail.Text = "Пользователь с такой почтой\nуже существует!";
                labelValidEmail.Show();
                
                return false;
            }
            else
                return true;
        } 

        // Хеширование пароля
        private string HashPassword(byte[] val)
        {
            using (SHA512Managed sha512 = new SHA512Managed())
            {
                var hash = sha512.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        // Регистрация пользователя в базу данных
        private void Registration()
        {
            AddEmp();
            AddUser();
        }

        // Добавлять ФИО и Email в базу данных
        private void AddEmp()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlCommand insertIntoEmp = new SqlCommand("AddEmployees", connection.GetSqlConnect());

            insertIntoEmp.CommandType = CommandType.StoredProcedure;

            insertIntoEmp.Parameters.AddWithValue("@employee_lname", SqlDbType.NVarChar).Value = TextBoxLname.Text.Trim();
            insertIntoEmp.Parameters.AddWithValue("@employee_fname", SqlDbType.NVarChar).Value = TextBoxFname.Text.Trim();
            insertIntoEmp.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = TextBoxEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(TextBoxMname.Text))
                insertIntoEmp.Parameters.AddWithValue("@employee_mname", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                insertIntoEmp.Parameters.AddWithValue("@employee_mname", SqlDbType.NVarChar).Value = TextBoxMname.Text.Trim();

            SqlParameter parameterEmp = insertIntoEmp.Parameters.AddWithValue("@id_employee", SqlDbType.Int);

            parameterEmp.Direction = ParameterDirection.Output;

            insertIntoEmp.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Добавлять пользователя в базу данных
        private void AddUser()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxRegPass.Text);

            SqlCommand selectIdEmp = new SqlCommand("SELECT id_employee " +
                "FROM Employees " +
                "WHERE @mail = Email", connection.GetSqlConnect());

            selectIdEmp.Parameters.AddWithValue("@mail", SqlDbType.VarChar).Value = TextBoxEmail.Text.Trim();

            SqlCommand insertIntoUser = new SqlCommand("AddUsers", connection.GetSqlConnect());

            insertIntoUser.CommandType = CommandType.StoredProcedure;

            insertIntoUser.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = TextBoxRegLog.Text.Trim();
            insertIntoUser.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = HashPassword(passtohash);
            insertIntoUser.Parameters.AddWithValue("@fk_role", SqlDbType.Int).Value = 2;
            insertIntoUser.Parameters.AddWithValue("@fk_employee", SqlDbType.Int).Value = selectIdEmp.ExecuteScalar();

            SqlParameter parameterUser = insertIntoUser.Parameters.AddWithValue("@id_user", SqlDbType.Int);

            parameterUser.Direction = ParameterDirection.Output;

            insertIntoUser.ExecuteNonQuery();

            MessageBox.Show("Аккаунт успешно создан!");

            this.Close();

            connection.CloseConnect();
        }

        // Скрывать Label`ы при вводе в TextBox`ы
        private void TextBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidLname.Hide();
        }

        private void TextBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidFname.Hide();
        }

        private void TextBoxRegLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegLog.Hide();
        }

        private void TextBoxRegPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegPass.Hide();
        }

        private void TextBoxRegPassRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegPassRepeat.Hide();
        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidEmail.Hide();
        }

        //Перемещение формы
        Point point;

        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        // Возврат к форме авторизации
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // При закрытии формы
        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Вызываем главную форму, которая открыла текущую, главная форма всегда 0
            Form authorization = Application.OpenForms[0]; 

            authorization.StartPosition = FormStartPosition.Manual; 
            authorization.Left = this.Left;
            authorization.Top = this.Top;
            authorization.Show();
        }

        // Скрывать / показывать пароль
        private void pictureBoxShowHidePassword_Click(object sender, EventArgs e)
        {
            if (TextBoxRegPass.UseSystemPasswordChar == true)
            {
                TextBoxRegPass.UseSystemPasswordChar = false;
                TextBoxRegPassRepeat.UseSystemPasswordChar = false;

                pictureBoxShowHidePassword.Image = Properties.Resources.ShowPassword;
            }
            else
            {
                TextBoxRegPass.UseSystemPasswordChar = true;
                TextBoxRegPassRepeat.UseSystemPasswordChar = true;

                pictureBoxShowHidePassword.Image = Properties.Resources.HidePassword; 
            }
        } 
    }
}