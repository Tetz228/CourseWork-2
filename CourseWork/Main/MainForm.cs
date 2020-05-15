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
using CourseWork.Posts;
using CourseWork.Status_task;
using CourseWork.History_task;

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
            History_taskForm history_task = new History_taskForm();

            history_task.MdiParent = this;
            history_task.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            history_task.Show();
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

                History_projectsForm history_projects = new History_projectsForm();

                history_projects.MdiParent = this;
                history_projects.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                history_projects.Show();
            }
        }

        private void списокПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listEmployeesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                EmployeesForm employees = new EmployeesForm();

                employees.MdiParent = this;
                employees.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                employees.Show();
            }
        }

        private void Posts_employeesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                Posts_employeesForm postsEmployees = new Posts_employeesForm();

                postsEmployees.MdiParent = this;
                postsEmployees.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                postsEmployees.Show();
            }
            
        }

        private void ListPostsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                PostsForm posts = new PostsForm();

                posts.MdiParent = this;
                posts.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                posts.Show();
            }
        }

        private void Status_taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                Status_taskForm task = new Status_taskForm();

                task.MdiParent = this;
                task.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                task.Show();
            }
        }

        private void History_taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                MdiChildren[0].Close();

                History_taskForm history_task = new History_taskForm();

                history_task.MdiParent = this;
                history_task.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                history_task.Show();
            }
        }
    }
}
