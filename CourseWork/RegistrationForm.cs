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
        }

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

        private void TextBoxLname_Leave(object sender, EventArgs e)
        {
            labelDashLname.ForeColor = Color.Black;
        }

        private void TextBoxLname_Click(object sender, EventArgs e)
        {
            labelDashLname.ForeColor = Color.DeepSkyBlue;
        }
    }
}
