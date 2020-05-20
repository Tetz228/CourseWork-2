using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class ConfirmationMailForm : MaterialForm
    {
        private string global;
        private string subject = "Подтверждение почты";
        private string body = "Ваш код подтверждения - ";

        public ConfirmationMailForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // Получение кода подтверждение
        private void ConfirmationMailForm_Load(object sender, EventArgs e)
        {
            CallSendingCode();
        }

        // Вызов функции отправки кода и занесение возвращенного значения в глоб. переменную
        private void CallSendingCode()
        {
            global = SendingCode(Program.DataRegist.Email, subject, body);
        }

        // Отправка кода подтверждение
        public string SendingCode(string email, string subject, string body)
        {
            Random random = new Random();

            string code;

            MailAddress fromMailAddress = new MailAddress("itproject719@gmail.com", "ITProject");
            MailAddress toMailAddress = new MailAddress(email);

            using (MailMessage mailMessager = new MailMessage(fromMailAddress, toMailAddress))
            using (SmtpClient smtp = new SmtpClient())
            {
                code = Convert.ToString(random.Next(100000, 999999));

                mailMessager.Subject = subject;
                mailMessager.Body = body + code;

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromMailAddress.Address, "%*kHy#l7~x");
                smtp.Send(mailMessager);

                return code;
            }
        }

        // Сравнивание введенного и полученного кода в глобальной переменной
        private void buttonConfirmationMail_Click(object sender, EventArgs e)
        {
            if (global == textBoxCode.Text)
            {
                Program.DataRegist.СorrectCode = "Сorrect code";
                this.Close();
            }
            else
                labelConfirmationMail.Show();
        }

        // Закрытие формы
        private void buttonBackConfirmationMail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Повторная отправка кода
        private void linkLabelConfirmationCode_Click(object sender, EventArgs e)
        {
            CallSendingCode();
        }

        // Перемещение формы
        Point point;

        private void ConfirmationMailForm_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void ConfirmationMailForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        // При закрытии формы
        private void ConfirmationMailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form registration = Application.OpenForms[1];

            registration.StartPosition = FormStartPosition.Manual;
            registration.Left = this.Left;
            registration.Top = this.Top;
            registration.Show();
        }

        // Скрывать Label при вводе в TextBox
        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelConfirmationMail.Hide();
        }
    }
}
