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
            Program.DataAddStatus_project.Value = textBoxNameStatus.Text;
            this.Close();
        }
    }
}
