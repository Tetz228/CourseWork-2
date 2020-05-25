using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
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
            Functions functions = new Functions();

            if (!CheckNullAndSpace())
                return;
            else
            if (!CheckLogAndPassLength())
                return;
            else
            if (!functions.ValidationLogin(TextBoxRegLog.Text.Trim()))
            {
                labelValidRegLog.Text = "Некорректный логин.";
                labelValidRegLog.Show();

                return;
            }
            else
            if (!functions.LoginOriginality(TextBoxRegLog.Text.Trim()))
                return;
            else
            if (!functions.ValidationPassword(TextBoxRegPass.Text.Trim()))
            {
                labelValidRegPass.Text = "Некорректный пароль. Пароль\nдолжен быть минимум с одной\nцифрой,одной заглавной и\nодной строчной буквой.";
                labelValidRegPass.Show();

                return;
            }
            else
            if (!functions.ValidationEmail(TextBoxEmail.Text.Trim()))
            {
                labelValidEmail.Text = "Некорректная почта";
                labelValidEmail.Show();

                return;
            }
            else
            if (!functions.MailOriginality(TextBoxEmail.Text.Trim()))
            {
                labelValidEmail.Text = "Пользователь с такой почтой\nуже существует!";
                labelValidEmail.Show();

                return;
            }
            else
            {
                Values.RegEmail = TextBoxEmail.Text;

                ConfirmationMailForm mailForm = new ConfirmationMailForm();

                mailForm.Left = this.Left;
                mailForm.Top = this.Top;

                this.Hide();

                mailForm.ShowDialog();

                if (Values.СorrectCode == "Сorrect code")
                {
                    AddEmployee();
                    AddUser();

                    MessageBox.Show("Аккаунт успешно создан!");

                    this.Close();
                }
            }
        }

        // Добавлять ФИО и Email сотрудника в базу данных
        public void AddEmployee()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlCommand insertIntoEmp = new SqlCommand("AddEmployees", connection.GetSqlConnect());

            insertIntoEmp.CommandType = CommandType.StoredProcedure;

            insertIntoEmp.Parameters.AddWithValue("@employee_lname", SqlDbType.NVarChar).Value = TextBoxLname.Text.Trim();
            insertIntoEmp.Parameters.AddWithValue("@employee_fname", SqlDbType.NVarChar).Value = TextBoxFname.Text.Trim();
            insertIntoEmp.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = TextBoxEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(TextBoxMname.Text.Trim()))
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
            Functions functions = new Functions();

            connection.OpenConnect();

            byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxRegPass.Text);

            SqlCommand selectIdEmp = new SqlCommand("SELECT id_employee " +
                "FROM Employees " +
                "WHERE @mail = Email", connection.GetSqlConnect());

            selectIdEmp.Parameters.AddWithValue("@mail", SqlDbType.VarChar).Value = TextBoxEmail.Text.Trim();

            SqlCommand insertIntoUser = new SqlCommand("AddUsers", connection.GetSqlConnect());

            insertIntoUser.CommandType = CommandType.StoredProcedure;

            insertIntoUser.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = TextBoxRegLog.Text.Trim();
            insertIntoUser.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = functions.HashPassword(passtohash);
            insertIntoUser.Parameters.AddWithValue("@fk_role", SqlDbType.Int).Value = 2;
            insertIntoUser.Parameters.AddWithValue("@fk_employee", SqlDbType.Int).Value = selectIdEmp.ExecuteScalar();

            SqlParameter parameterUser = insertIntoUser.Parameters.AddWithValue("@id_user", SqlDbType.Int);

            parameterUser.Direction = ParameterDirection.Output;

            insertIntoUser.ExecuteNonQuery();

            connection.CloseConnect();
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