using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;
using MaterialSkin.Controls;
using MaterialSkin;
using CourseWork.Main;

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
            Functions functions = new Functions();

            if (!CheckTextBox())
                return;
            else
            if (!CheckPass())
                return;
            else
            if (!functions.ValidationPassword(TextBoxNewPass.Text.Trim()))
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

        // Функция изменения пароля
        private void СhangePassword()
        {
            Functions functions = new Functions();

            byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxNewPass.Text.Trim());

            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlCommand updatePasswordUser = new SqlCommand("NewPassword", connection.GetSqlConnect());
            updatePasswordUser.CommandType = CommandType.StoredProcedure;

            updatePasswordUser.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = functions.HashPassword(passtohash);
            updatePasswordUser.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = Values.ForgotIdUser;

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

        //Скрыввать label`ы при вводе в TextBox`ы
        private void TextBoxNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidPass.Hide();
        }

        private void TextBoxNewPassRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidPassRepeat.Hide();
        }

        // Скрывать / показывать пароль
        private void pictureBoxShowHidePassword_Click(object sender, EventArgs e)
        {
            if (TextBoxNewPass.UseSystemPasswordChar == true)
            {
                TextBoxNewPass.UseSystemPasswordChar = false;
                TextBoxNewPassRepeat.UseSystemPasswordChar = false;

                pictureBoxShowHidePassword.Image = Properties.Resources.ShowPassword;
            }
            else
            {
                TextBoxNewPass.UseSystemPasswordChar = true;
                TextBoxNewPassRepeat.UseSystemPasswordChar = true;

                pictureBoxShowHidePassword.Image = Properties.Resources.HidePassword;
            }
        }
    }
}
