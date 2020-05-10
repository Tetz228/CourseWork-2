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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                Program.DataAddStatus_project.Value = textBoxNameStatus.Text;

                this.Close();
            }
        }

        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxNameStatus.Text))
            {
                labelValid.Show();

                return false;
            }
            else
            {
                Program.DataValidStatus_project.Value = "true";

                return true;
            }
        }

        private void textBoxNameStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }

        private void Status_projectsFormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.DataValidStatus_project.Value == "true")
                return;
            else
                Program.DataValidStatus_project.Value = "false";
        }
    }
}
