using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using CourseWork.Main;

namespace CourseWork
{
    public partial class ConfirmationMailForm : MaterialForm
    {
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

        // Вызов функции отправки кода
        private void CallSendingCode()
        {
            SendingCode sending = new SendingCode();

            Values.RegCode = sending.FunSendingCode(Values.RegEmail, "Подтверждение почты", "Ваш код подтверждения - ");
        }   

        // Сравнивание введенного и полученного кода
        private void buttonConfirmationMail_Click(object sender, EventArgs e)
        {
            if (Values.RegCode == textBoxCode.Text)
            {
                Values.СorrectCode = "Сorrect code";
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
