using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            labelDashLname.ForeColor = Color.DeepSkyBlue;
        }

        // Перемещение формы
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form authorization = Application.OpenForms[0]; // Вызываем главную форму, которая открыла текущую, главная форма всегда 0
            authorization.StartPosition = FormStartPosition.Manual; 
            authorization.Left = this.Left;
            authorization.Top = this.Top;
            authorization.Show();
        }

        // При клике на TextBox`ы
        private void TextBoxFname_Click(object sender, EventArgs e)
        {
            labelDashFname.ForeColor = Color.DeepSkyBlue;
        }

        private void TextBoxLname_Click(object sender, EventArgs e)
        {
            labelDashLname.ForeColor = Color.DeepSkyBlue;
        }

        private void TextBoxMname_Click(object sender, EventArgs e)
        {
            labelDashMname.ForeColor = Color.DeepSkyBlue;
        }

        private void TextBoxRegLog_Click(object sender, EventArgs e)
        {
            labelDashRegLog.ForeColor = Color.DeepSkyBlue;
        }

        private void TextBoxRegPass_Click(object sender, EventArgs e)
        {
            labelDashRegPass.ForeColor = Color.DeepSkyBlue;
        }

        private void TextBoxEmail_Click(object sender, EventArgs e)
        {
            labelDashEmail.ForeColor = Color.DeepSkyBlue;
        }

        // При выходе из TextBox`ов
        private void TextBoxLname_Leave(object sender, EventArgs e)
        {
            labelDashLname.ForeColor = Color.Black;
        }

        private void TextBoxFname_Leave(object sender, EventArgs e)
        {
            labelDashFname.ForeColor = Color.Black;
        }

        private void TextBoxMname_Leave(object sender, EventArgs e)
        {
            labelDashMname.ForeColor = Color.Black;
        }  

        private void TextBoxRegLog_Leave(object sender, EventArgs e)
        {
            labelDashRegLog.ForeColor = Color.Black;
        }      

        private void TextBoxRegPass_Leave(object sender, EventArgs e)
        {
            labelDashRegPass.ForeColor = Color.Black;
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            labelDashEmail.ForeColor = Color.Black;
        }
    }
}
