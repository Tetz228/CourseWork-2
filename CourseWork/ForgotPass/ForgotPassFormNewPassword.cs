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

namespace CourseWork.Authorization_Registration_ForgotPass.ForgotPass
{
    public partial class ForgotPassFormNewPassword : MaterialForm
    {
        public ForgotPassFormNewPassword()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При нажатии вызов всех проверок и обновление пароля
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            if (!CheckPass())
                return;
            else
            if (!ValidationPassword(TextBoxNewPass.Text))
            {
                labelValidPass.Text = "Некорректный пароль. Пароль\nдолжен быть минимум с одной\nцифрой, одной заглавной и\nодной строчной буквой.";
                labelValidPass.Show();
                return;
            }
            else
            {
                СhangePassword();
                MessageBox.Show("Пароль был успешно изменен!");
                this.Close();
            }
        }

        // При нажатии закрывать форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // При закрытии формы
        private void ForgotPassFormNewPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form authorization = Application.OpenForms[0];

            authorization.StartPosition = FormStartPosition.Manual;
            authorization.Left = this.Left;
            authorization.Top = this.Top;
            authorization.Show();
        }

        // Валидация пароля
        // От 6 до 35 символов с минимум одной цифрой, одной заглавной и одной строчной буквой
        private bool ValidationPassword(string password)
        {
            string pattern = @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,35})";

            Match isMatch = Regex.Match(password, pattern);

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

        // Функция изменения пароля
        private void СhangePassword()
        {
            byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxNewPass.Text.ToString());

            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlCommand updatePasswordUser = new SqlCommand("NewPassword", connection.GetSqlConnect());
            updatePasswordUser.CommandType = CommandType.StoredProcedure;

            updatePasswordUser.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = HashPassword(passtohash);
            updatePasswordUser.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = Convert.ToInt32(Program.DataIdForgotPass.Value);

            updatePasswordUser.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Проверка на нулевые значения в TextBox`сах
        private bool CheckTextBox()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(TextBoxNewPass.Text))
            {
                labelValidPass.Text = "Введите пароль";
                labelValidPass.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxNewPass.Text))
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

        // Проверка пароля на нужную длинну и проверка на совпадение
        private bool CheckPass()
        {
            if (TextBoxNewPass.Text.Length < 6)
            {
                labelValidPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidPass.Show();

                return false;
            }
            else

            if (TextBoxNewPass.Text != TextBoxNewPassRepeat.Text)
            {
                labelValidPassRepeat.Text = "Пароли должны совпадать";
                labelValidPassRepeat.Show();

                return false;
            }

            return true;
        }

        // Скрывать / показывать пароль
        private void pictureBoxShowHidePassword_Click(object sender, EventArgs e)
        {

        }

        //Скрыввать label`ы при вводе в TextBox`ы
        private void TextBoxNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidPass.Hide();
        }

        private void TextBoxNewPassRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidPassRepeat.Hide();
        }
    }
}
