using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            History_projectsForm history_Projects = new History_projectsForm();

            history_Projects.MdiParent = this;
            history_Projects.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            history_Projects.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ListProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                ProjectsForm proj = new ProjectsForm();

                proj.MdiParent = this;
                proj.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                proj.Show();
            }
        }

        private void Status_projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                Status_projectsForm stat_proj = new Status_projectsForm();

                stat_proj.MdiParent = this;
                stat_proj.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                stat_proj.Show();
            }
        }

        private void Projects_roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                Projects_roleForm proj_role = new Projects_roleForm();

                proj_role.MdiParent = this;
                proj_role.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                proj_role.Show();
            }
        }

        private void History_projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                History_projectsForm history_Projects = new History_projectsForm();

                history_Projects.MdiParent = this;
                history_Projects.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                history_Projects.Show();
            }
        }

        private void списокПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
