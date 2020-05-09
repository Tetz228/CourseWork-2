using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ConfirmationMailForm : Form
    {
        private string global;

        public ConfirmationMailForm()
        {
            InitializeComponent();
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

        private void ConfirmationMailForm_Load(object sender, EventArgs e)
        {
            //global = SendingCode(Program.DataEmailReg.Value);
        }

        public string SendingCode(string email)
        {
            Random random = new Random();

            string code;

            MailAddress fromMailAddress = new MailAddress("itproject719@gmail.com", "ITProject");
            MailAddress toMailAddress = new MailAddress(email);

            using (MailMessage mailMessager = new MailMessage(fromMailAddress, toMailAddress))
            using (SmtpClient smtp = new SmtpClient())
            {
                code = Convert.ToString(random.Next(100000, 999999));

                mailMessager.Subject = "Подтверждение почты";
                mailMessager.Body = "Ваш код подтверждения - " + code;

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

        private void buttonConfirmationMail_Click(object sender, EventArgs e)
        {
            string returnCode = global;
            string enteredCode = textBoxCode.Text;

            if (returnCode == enteredCode)
            {
                Program.DataReturnReg.Value = "Сorrect code";
                this.Close();
            }
            else
                labelConfirmationMail.Show();
        }

        private void buttonBackConfirmationMail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelConfirmationMail.Hide();

            //Только цифры
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 ||
                // Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z, BACKSPACE
                e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026 || e.KeyChar == 8))

                e.Handled = true;
        }

        private void linkLabelConfirmationCode_Click(object sender, EventArgs e)
        {
            global = SendingCode(Program.DataEmailReg.Value);
        }

        private void textBoxCode_Click(object sender, EventArgs e)
        {
            labelDashConfirmationMail.ForeColor = Color.White;
        }

        private void textBoxCode_Leave(object sender, EventArgs e)
        {
            labelDashConfirmationMail.ForeColor = Color.Black;
        }

        private void ConfirmationMailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form registration = Application.OpenForms[1];

            registration.StartPosition = FormStartPosition.Manual;
            registration.Left = this.Left;
            registration.Top = this.Top;
            registration.Show();
        }
    }
}
