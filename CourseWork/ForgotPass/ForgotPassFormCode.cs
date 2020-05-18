using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using CourseWork.Authorization_Registration_ForgotPass.ForgotPass;

namespace CourseWork.Authorization_Registration_Forgot_pass
{
    public partial class ForgotPassFormCode : MaterialForm
    {
        private string global;
        private string subject = "Код безопасности учетной записи";
        private string body = "Ваш код безопасности для изменения пароля - ";

        public ForgotPassFormCode()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы отправлять код
        private void ForgotPassFormCode_Load(object sender, EventArgs e)
        { 
            СonfirmationСode();
        }

        // Проверка отправленного и введенного кода
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (global == textBoxCode.Text)
            {
                ForgotPassFormNewPassword formNewPassword = new ForgotPassFormNewPassword();

                this.Hide();

                formNewPassword.ShowDialog();
            }
            else
                labelConfirmationMail.Show();
        }

        // При нажатии закрывать форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Повторная отправка кода
        private void linkLabelConfirmationCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            СonfirmationСode();
            MessageBox.Show("Код безопасности отправлен повторно!");
        }

        // Получение кода подтвеждения с помощью глобальной переменной 
        private void СonfirmationСode()
        {
            ConfirmationMailForm mailForm = new ConfirmationMailForm();
            
            global = mailForm.SendingCode(Program.DataEmailForgotPass.Value, subject, body);
        }

        // При закрытии формы
        private void ForgotPassFormCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form authorization = Application.OpenForms[0];

            authorization.StartPosition = FormStartPosition.Manual;
            authorization.Left = this.Left;
            authorization.Top = this.Top;
            authorization.Show();
        }

        // При вводе в TextBox скрывать Label
        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelConfirmationMail.Hide();
        } 
    }
}
