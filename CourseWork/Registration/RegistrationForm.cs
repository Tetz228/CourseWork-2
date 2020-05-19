using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;
using MaterialSkin.Controls;
using MaterialSkin;

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
            //if (!CheckNullAndSpace(TextBoxLname.Text, TextBoxFname.Text, TextBoxRegLog.Text, TextBoxRegPass.Text, TextBoxRegPassRepeat.Text, TextBoxEmail.Text))
            //    return;
            //else
            if (!CheckLogAndPassLength(TextBoxRegLog.Text, TextBoxRegPass.Text, TextBoxRegPassRepeat.Text))
                return;
            else
            if (!ValidationLogin(TextBoxRegLog.Text))
            {
                labelValidRegLog.Text = "Некорректный логин.";
                labelValidRegLog.Show();
                return;
            }
            //else
            //if (!LoginOriginality(TextBoxRegLog.Text))
            //    return;
            //else
            //if (!ValidationPassword(TextBoxRegPass.Text))
            //{
            //    labelValidRegPass.Text = "Некорректный пароль. Пароль\nдолжен быть минимум с одной\nцифрой,одной заглавной и\nодной строчной буквой.";
            //    labelValidRegPass.Show();
            //    return;
            //}
            //else
            //if (!ValidationEmail(TextBoxEmail.Text))
            //{
            //    labelValidEmail.Text = "Некорректная почта";
            //    labelValidEmail.Show();

            //    return;
            //}
            //else
            //if (!MailOriginality(TextBoxEmail.Text))
            //    return;
            //else
            //{
            //    Program.DataEmailReg.Value = TextBoxEmail.Text;

            //    ConfirmationMailForm mailForm = new ConfirmationMailForm();
            //    mailForm.Left = this.Left;
            //    mailForm.Top = this.Top;
            //    this.Hide();
            //    mailForm.ShowDialog();

            //    if (Program.DataReturnReg.Value == "Сorrect code")
            //        Registration();
            //}
        }

        // Проверка TextBox`ов на пустоту
        private bool CheckNullAndSpace(string lname, string fname, string login, string password, string repeatPassword,string email)
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(lname))
            {
                labelValidLname.Text = "Введите фамилию";
                labelValidLname.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(fname))
            {
                labelValidFname.Text = "Введите имя";
                labelValidFname.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(login))
            {
                labelValidRegLog.Text = "Введите логин";
                labelValidRegLog.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                labelValidRegPass.Text = "Введите пароль";
                labelValidRegPass.Show();
                
                check = 1;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                labelValidEmail.Text = "Введите почту";
                labelValidEmail.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(repeatPassword))
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
        private bool CheckLogAndPassLength(string login, string password, string repeatPassword)
        {
            if (login.Length < 4 && password.Length < 6)
            {
                labelValidRegLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidRegLog.Show();

                labelValidRegPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidRegPass.Show();

                return false;
            }
            else
            if (login.Length < 4)
            {
                labelValidRegLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidRegLog.Show();

                return false;
            }
            else

            if (password.Length < 6)
            {
                labelValidRegPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidRegPass.Show();

                return false;
            }
            else

            if (password != repeatPassword)
            {
                labelValidRegPassRepeat.Text = "Пароли должны совпадать";
                labelValidRegPassRepeat.Show();
                return false;
            }
            return true;
        }

        // Валидация логина
        private bool ValidationLogin(string login)
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9]{3,30}$";

            Match isMatch = Regex.Match(login, pattern);

            return isMatch.Success;
        }

        // Проверка на уникальность логина
        private bool LoginOriginality(string login)
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT login FROM Users WHERE login = @log", connection.GetSqlConnect());
            selectLog.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = login;

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
        private bool ValidationPassword(string password)
        {
            string pattern = @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,35})";

            Match isMatch = Regex.Match(password, pattern);

            return isMatch.Success;
        }

        // Валидация почты
        private bool ValidationEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        // Проверка на уникальность почты
        private bool MailOriginality(string email)
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT Email FROM Employees WHERE Email = @email", connection.GetSqlConnect());
            selectLog.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;

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
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlCommand insertIntoEmp = new SqlCommand("INSERT INTO Employees(employee_lname, employee_fname, employee_mname, Email) VALUES(@employee_lname, @employee_fname, @employee_mname, @Email) ", connection.GetSqlConnect());

            insertIntoEmp.Parameters.AddWithValue("@employee_lname", SqlDbType.NVarChar).Value = TextBoxLname.Text.Trim();
            insertIntoEmp.Parameters.AddWithValue("@employee_fname", SqlDbType.NVarChar).Value = TextBoxFname.Text.Trim();
            insertIntoEmp.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = TextBoxEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(TextBoxMname.Text))
                insertIntoEmp.Parameters.AddWithValue("@employee_mname", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                insertIntoEmp.Parameters.AddWithValue("@employee_mname", SqlDbType.NVarChar).Value = TextBoxMname.Text.Trim();

            if (insertIntoEmp.ExecuteNonQuery() == 1)
            {
                byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxRegPass.Text.ToString());

                SqlCommand selectIdEmp = new SqlCommand("SELECT id_employee FROM Employees WHERE @mail = Email", connection.GetSqlConnect());

                selectIdEmp.Parameters.AddWithValue("@mail", SqlDbType.VarChar).Value = TextBoxEmail.Text.Trim();
              
                SqlCommand insertIntoUser = new SqlCommand("INSERT INTO Users(login,password,fk_role_user,fk_employee) VALUES(@log, @pass, @role, @fk_employee)", connection.GetSqlConnect());

                insertIntoUser.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = TextBoxRegLog.Text.Trim();
                insertIntoUser.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = HashPassword(passtohash);
                insertIntoUser.Parameters.AddWithValue("@role", SqlDbType.Int).Value = 2;
                insertIntoUser.Parameters.AddWithValue("@fk_employee", SqlDbType.Int).Value = selectIdEmp.ExecuteScalar();

                //Если команда = 1, то есть она успешно выполняется, то аккаунт будет создан
                if (insertIntoUser.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!");

                    this.Close();
                }
            }

            connection.CloseConnect();
        }

        // Скрывать Label`ы при вводе в TextBox`ы
        private void TextBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidLname.Hide();

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        private void TextBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidFname.Hide();

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        private void TextBoxMname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        private void TextBoxRegLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegLog.Hide();

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        private void TextBoxRegPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegPass.Hide();

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        private void TextBoxRegPassRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegPassRepeat.Hide();

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidEmail.Hide();

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
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