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

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
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
                proj.WindowState = FormWindowState.Maximized;
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
                stat_proj.Location = new Point(0, 0);
                stat_proj.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                stat_proj.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProjectsForm proj = new ProjectsForm();

            proj.MdiParent = this;
            proj.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            proj.Show();
        }
    }
}
