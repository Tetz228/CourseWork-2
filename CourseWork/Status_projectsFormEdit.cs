using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Status_projectsFormEdit : MaterialForm
    {
        public Status_projectsFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы передать тест из класса в TextBox
        private void Status_projectsFormEdit_Load(object sender, EventArgs e)
        {
            textBoxEdit.Text = Program.DataEditStatus_project.Value;
        }

        // При закрытии формы передать определенный текст в класс
        private void Status_projectsFormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.DataValidEditStatus_project.Value == "true")
                return;
            else
                Program.DataValidEditStatus_project.Value = "false";
        }

        // При нажатии валидация и передача текста в класс
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                Program.DataEditStatus_project.Value = textBoxEdit.Text.Trim();

                this.Close();
            }
        }

        // При нажатии передать определенный текст в класс
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.DataValidEditStatus_project.Value = "false";

            this.Close();
        }

        // Валидация TextBox`а
        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxEdit.Text))
            {
                labelValid.Show();

                return false;
            }
            else
            {
                Program.DataValidEditStatus_project.Value = "true";

                return true;
            }
        }

        // При вводе в TextBox скрывать label
        private void textBoxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }
    }
}
