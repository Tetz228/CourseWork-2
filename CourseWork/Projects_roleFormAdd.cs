using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class Projects_roleFormAdd : MaterialForm
    {
        public Projects_roleFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При нажатии валидация и передача текста в класс
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                Program.DataAddProjects_role.Value = textBoxNameRole.Text.Trim();

                this.Close();
            }
            
        }

        // При нажатии передать определенный текст в класс
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.DataValidAddProjects_role.Value = "false";

            this.Close();
        }

        // Валидация TextBox`а
        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxNameRole.Text))
            {
                labelValid.Show();

                return false;
            }
            else
            {
                Program.DataValidAddProjects_role.Value = "true";

                return true;
            }
        }

        // При вводе в TextBox скрывать label
        private void textBoxNameRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }

        // При закрытии формы передать определенный текст в класс
        private void Projects_roleFormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.DataValidAddProjects_role.Value == "true")
                return;
            else
                Program.DataValidAddProjects_role.Value = "false";
        }  
    }
}
