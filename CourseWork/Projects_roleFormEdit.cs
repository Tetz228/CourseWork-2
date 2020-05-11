using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class Projects_roleFormEdit : MaterialForm
    {
        public Projects_roleFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы передать тест из класса в TextBox
        private void Projects_roleFormEdit_Load(object sender, EventArgs e)
        {
            textBoxEdit.Text = Program.DataEditProjects_role.Value;
        }

        // При нажатии валидация и передача текста в класс
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                Program.DataEditProjects_role.Value = textBoxEdit.Text.Trim();

                this.Close();
            }
            
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
                Program.DataValidEditProjects_role.Value = "true";

                return true;
            }
        }

        // При нажатии передать определенный текст в класс
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.DataValidEditProjects_role.Value = "false";

            this.Close();
        }

        // При закрытии формы передать определенный текст в класс
        private void Projects_roleFormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.DataValidEditProjects_role.Value == "true")
                return;
            else
                Program.DataValidEditProjects_role.Value = "false";
        }

        // При вводе в TextBox скрывать label
        private void textBoxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }
    }
}
