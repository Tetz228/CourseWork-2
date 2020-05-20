﻿using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace CourseWork.Users
{
    public partial class UsersFormEdit : MaterialForm
    {
        string log;
        string pass;

        public UsersFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void UsersFormEdit_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();

            SelectRoleComboBox();

            TextBoxLog.Text = log = Program.DataUser.Login;
            TextBoxPass.Text = pass = Program.DataUser.Password;
            TextBoxPassRepeat.Text = Program.DataUser.Password;

            int indexEmp = ComboBox_fk_employee.FindString(Program.DataUser.Employee);
            int indexPost = ComboBox_fk_role_user.FindString(Program.DataUser.Role);

            ComboBox_fk_employee.SelectedIndex = indexEmp;
            ComboBox_fk_role_user.SelectedIndex = indexPost;
        }

        // Заполнение ComboBox`а "Сотрудник"
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, " +
                "CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee " +
                "FROM Employees", connection.GetSqlConnect());
            DataTable EmployeeTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(EmployeeTableComboBox);

            ComboBox_fk_employee.ValueMember = "Id";
            ComboBox_fk_employee.DisplayMember = "Employee";
            ComboBox_fk_employee.DataSource = EmployeeTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Роль сотрудника"
        private void SelectRoleComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_user_role AS Id, " +
                "user_name_role AS Role " +
                "FROM Users_roles", connection.GetSqlConnect());
            DataTable RoleTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(RoleTableComboBox);

            ComboBox_fk_role_user.ValueMember = "Id";
            ComboBox_fk_role_user.DisplayMember = "Role";
            ComboBox_fk_role_user.DataSource = RoleTableComboBox;

            connection.CloseConnect();
        }

        // При нажатии вызов всех проверок и добавление в бд
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxs())
                return;
            else
            if (!CheckLogAndPassLength())
                return;
            else
            if (!ValidationLogin())
            {
                labelValidLog.Text = "Некорректный логин.";
                labelValidLog.Show();

                return;
            }
            else
            if (!ValidationPassword())
            {
                labelValidPass.Text = "Некорректный пароль. Первым\nсимволом не может быть цифра.\nПароль должен быть минимум с\nодной цифрой, одной заглавной\nи одной строчной буквой.";
                labelValidPass.Show();

                return;
            }
            else
            if (log != TextBoxLog.Text.Trim())
            {
                if (!LoginOriginality())
                    return;
                else
                {
                    if (pass != TextBoxPass.Text.Trim())
                    {
                        byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxPass.Text.Trim().ToString());

                        pass = HashPassword(passtohash);

                        EditRowUser();
                    }
                    else
                    {
                        EditRowUser();

                        this.Close();
                    }
                }
            }
            else
            if (pass != TextBoxPass.Text.Trim())
            {
                byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxPass.Text.Trim().ToString());

                pass = HashPassword(passtohash);

                EditRowUser();

                this.Close();
            }
            else
            {
                EditRowUser();

                this.Close();
            }
        }

        // При нажатии закрытие формы
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Проверки TextBox`ов и ComboBox`ов
        private bool CheckTextBoxs()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(TextBoxLog.Text))
            {
                labelValidLog.Text = "Введите логин";
                labelValidLog.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxPass.Text))
            {
                labelValidPass.Text = "Введите пароль";
                labelValidPass.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxPassRepeat.Text))
            {
                labelValidPassRepeat.Text = "Введите ещё раз пароль";
                labelValidPassRepeat.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }

        // Скрывать / показывать пароль
        private void pictureBoxShowHidePassword_Click(object sender, EventArgs e)
        {
            if (TextBoxPass.UseSystemPasswordChar == true)
            {
                TextBoxPass.UseSystemPasswordChar = false;
                TextBoxPassRepeat.UseSystemPasswordChar = false;

                pictureBoxShowHidePassword.Image = Properties.Resources.ShowPassword;
            }
            else
            {
                TextBoxPass.UseSystemPasswordChar = true;
                TextBoxPassRepeat.UseSystemPasswordChar = true;

                pictureBoxShowHidePassword.Image = Properties.Resources.HidePassword;
            }
        }

        // Проверка логина и пароля на нужную длинну
        private bool CheckLogAndPassLength()
        {
            if (TextBoxLog.Text.Length < 4 && TextBoxPass.Text.Length < 6)
            {
                labelValidLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidLog.Show();

                labelValidPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidPass.Show();

                return false;
            }
            else
            if (TextBoxLog.Text.Length < 4)
            {
                labelValidLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidLog.Show();

                return false;
            }
            else
            if (TextBoxPass.Text.Length < 6)
            {
                labelValidPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidPass.Show();

                return false;
            }
            else
            if (TextBoxPass.Text != TextBoxPassRepeat.Text)
            {
                labelValidPassRepeat.Text = "Пароли должны совпадать";
                labelValidPassRepeat.Show();

                return false;
            }
            return true;
        }

        // Валидация логина
        private bool ValidationLogin()
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9]{3,30}$";

            Match isMatch = Regex.Match(TextBoxLog.Text, pattern);

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
            selectLog.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = TextBoxLog.Text;

            adapter.SelectCommand = selectLog;
            adapter.Fill(table);

            connection.CloseConnect();

            if (table.Rows.Count > 0)
            {
                labelValidLog.Text = "Пользователь с таким логином\nуже существует!";
                labelValidLog.Show();
                return false;
            }
            else
                return true;
        }

        // Валидация пароля
        // От 6 до 35 символов с минимум одной цифрой, одной заглавной и одной строчной буквой
        private bool ValidationPassword()
        {
            string pattern = @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{5,35})";

            Match isMatch = Regex.Match(TextBoxPass.Text.Trim(), pattern);

            return isMatch.Success;
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

        // Функция изменения пользователя
        private void EditRowUser()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditUsers", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;
         
            connection.OpenConnect();

            command.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = TextBoxLog.Text.Trim();
            command.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = pass;
            command.Parameters.AddWithValue("@fk_role", SqlDbType.Int).Value = ComboBox_fk_role_user.SelectedValue;
            command.Parameters.AddWithValue("@fk_employee", SqlDbType.Int).Value = ComboBox_fk_employee.SelectedValue;
            command.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = Program.DataUser.Id;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Скрывать Label`ы при вводе в TextBox`ы или выборе в ComboBox`сах
        private void TextBoxLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidLog.Hide();
        }

        private void TextBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidPass.Hide();
        }

        private void TextBoxPassRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidPassRepeat.Hide();
        }

        private void ComboBox_fk_role_user_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidRole.Hide();
        }

        private void ComboBox_fk_employee_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidEmployee.Hide();
        }
    }
}
