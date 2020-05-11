using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Status_projectsFormAdd : MaterialForm
    {
        public Status_projectsFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При закрытии формы передать определенный текст в класс
        private void Status_projectsFormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.DataValidAddStatus_project.Value == "true")
                return;
            else
                Program.DataValidAddStatus_project.Value = "false";
        }

        // При нажатии валидация и передача текста в класс
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                Program.DataAddStatus_project.Value = textBoxNameStatus.Text.Trim();

                this.Close();
            }
        }

        // При нажатии передать определенный текст в класс
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.DataValidAddStatus_project.Value = "false";

            this.Close();
        }

        // Валидация TextBox`а
        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxNameStatus.Text))
            {
                labelValid.Show();

                return false;
            }
            else
            {
                Program.DataValidAddStatus_project.Value = "true";

                return true;
            }
        }

        // При вводе в TextBox скрывать label
        private void textBoxNameStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }
    }
}
