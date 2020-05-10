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
            if (!CheckNullAndSpace())
                return;
            else
                if (!CheckLogAndPassLength())
                return;
            else
                if (!LoginOriginality())
                return;
            else
                if (!ValidationEmail(TextBoxEmail.Text))
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

                Program.DataEmailReg.Value = TextBoxEmail.Text;

                ConfirmationMailForm mailForm = new ConfirmationMailForm();
                mailForm.Left = this.Left;
                mailForm.Top = this.Top;
                this.Hide();
                mailForm.ShowDialog();

                if (Program.DataReturnReg.Value == "Сorrect code")
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
            if (string.IsNullOrEmpty(TextBoxRegLog.Text))
            {
                labelValidRegLog.Text = "Введите логин";
                labelValidRegLog.Show();

                check = 1;
            }
            if (string.IsNullOrEmpty(TextBoxRegPass.Text))
            {
                labelValidRegPass.Text = "Введите пароль";
                labelValidRegPass.Show();
                
                check = 1;
            }
            if (string.IsNullOrEmpty(TextBoxEmail.Text))
            {
                labelValidEmail.Text = "Введите почту";
                labelValidEmail.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }

        // Проверка логина на нужную длину
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
                return true;
        }


        // Проверка на уникальность логина
        private bool LoginOriginality()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT login FROM Users WHERE login = @log", connection.GetSqlConnect());
            selectLog.Parameters.Add("@log", SqlDbType.VarChar).Value = TextBoxRegLog.Text;

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

        // Валидация почты
        public bool ValidationEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        // Проверка на уникальность почты
        private bool MailOriginality()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT Email FROM Employees WHERE Email = @email", connection.GetSqlConnect());
            selectLog.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBoxEmail.Text;

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

        // Хеширование пароля пока без соли
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

            insertIntoEmp.Parameters.Add("@employee_lname", SqlDbType.NVarChar).Value = TextBoxLname.Text;
            insertIntoEmp.Parameters.Add("@employee_fname", SqlDbType.NVarChar).Value = TextBoxFname.Text;
            insertIntoEmp.Parameters.Add("@Email", SqlDbType.NVarChar).Value = TextBoxEmail.Text;

            if (string.IsNullOrWhiteSpace(TextBoxMname.Text))
                insertIntoEmp.Parameters.Add("@employee_mname", SqlDbType.NVarChar).Value = "Не указано";
            else
                insertIntoEmp.Parameters.Add("@employee_mname", SqlDbType.NVarChar).Value = TextBoxMname.Text;

            if (insertIntoEmp.ExecuteNonQuery() == 1)
            {
                byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxRegPass.Text.ToString());

                SqlCommand selectIdEmp = new SqlCommand("SELECT id_employee FROM Employees WHERE @mail = Email", connection.GetSqlConnect());

                selectIdEmp.Parameters.Add("@mail", SqlDbType.NVarChar).Value = TextBoxEmail.Text;
              
                SqlCommand insertIntoUser = new SqlCommand("INSERT INTO Users(login,password,fk_role_user,fk_employee) VALUES(@log, @pass, @role, @fk_employee)", connection.GetSqlConnect());

                insertIntoUser.Parameters.Add("@log", SqlDbType.VarChar).Value = TextBoxRegLog.Text;
                insertIntoUser.Parameters.Add("@pass", SqlDbType.VarChar).Value = HashPassword(passtohash);
                insertIntoUser.Parameters.Add("@role", SqlDbType.Int).Value = 2;
                insertIntoUser.Parameters.Add("@fk_employee", SqlDbType.Int).Value = selectIdEmp.ExecuteScalar();

                //Если команда = 1, то есть она успешно выполняется, то аккаунт будет создан
                if (insertIntoUser.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!");

                    this.Close();
                }
                else
                    MessageBox.Show("Аккаунт не был создан!");
            }

            connection.CloseConnect();
        }

        // Ввод только определенных символов
        private void TextBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidLname.Hide();

            //BACKSPACE, space, русс. и анг. символы, Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z, цифры
            if (!(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar <= 'я' && e.KeyChar >= 'а' || e.KeyChar >= 'А' && e.KeyChar <= 'Я' 
                || e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' 
                || e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026
                || (e.KeyChar >= 48 && e.KeyChar <= 57)))
                e.Handled = true;

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        // Ввод только определенных символов
        private void TextBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidFname.Hide();

            //BACKSPACE, space, русс. и анг. символы, Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z, цифры, минус, нижнее подчеркивание
            if (!(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar <= 'я' && e.KeyChar >= 'а' || e.KeyChar >= 'А' && e.KeyChar <= 'Я'
                || e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                || e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026
                || (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 45 || e.KeyChar == 95)))
                e.Handled = true;

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        // Ввод только определенных символов
        private void TextBoxMname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidLname.Hide();

            //BACKSPACE, space, русс. и анг. символы, Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z, цифры, минус, нижнее подчеркивание
            if (!(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar <= 'я' && e.KeyChar >= 'а' || e.KeyChar >= 'А' && e.KeyChar <= 'Я'
                || e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                || e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026
                || (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 45 || e.KeyChar == 95)))
                e.Handled = true;

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        // Ввод только определенных символов 
        private void TextBoxRegLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegLog.Hide();

            //BACKSPACE, цифры, буквы верхнего регистра, буквы нижнего регистра, точка, минус, нижнее подчеркивание, Shift
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90) ||
                (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 46 || e.KeyChar == 45 || e.KeyChar == 95 || e.KeyChar == 14 ||
                // Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z
                e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026))
            {
                e.Handled = true;
            }
        }

        // Запрет на ввод определенных символов
        private void TextBoxRegPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegPass.Hide();

            //Запрет на ввод space, кириллицы, Ctrl + V
            char key = e.KeyChar;

            if (key == 32 || key <= 'я' && key >= 'а' || key >= 'А' && key <= 'Я' || key == 13 || key == 022)
                e.Handled = true;
        }

        // Ввод только определенных символов
        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidEmail.Hide();

            char key = e.KeyChar;

            //BACKSPACE, цифры, буквы нижнего регистра, точка, минус, нижнее подчеркивание, Shift, @
            if (!(key == 8 || (key >= 48 && key <= 57) || (key >= 97 && key <= 122) ||
                key == 46 || key == 45 || key == 95 || key == 14 || key == 64 || key <= 'я' && key >= 'а'  ||
                // Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z
                key == 001 || key == 003 || key == 024 || key == 026))
            {
                e.Handled = true;
            }
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
    }
}