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

        private void Status_projectsFormEdit_Load(object sender, EventArgs e)
        {
            textBoxEdit.Text = Program.DataEditStatus_project.Value;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Program.DataEditStatus_project.Value = textBoxEdit.Text;
            this.Close();
        }
    }
}
