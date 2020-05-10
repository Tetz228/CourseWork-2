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

        private void Projects_roleFormEdit_Load(object sender, EventArgs e)
        {
            textBoxEdit.Text = Program.DataEditProjects_role.Value;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Program.DataEditProjects_role.Value = textBoxEdit.Text;

            this.Close();
        }
    }
}
