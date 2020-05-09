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
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class ProjectsFormEdit : MaterialForm
    {
        public ProjectsFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ProjectsFormEdit_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();

            int i = -1;
            i += Convert.ToInt32(Program.DataEditProjectLeader.Value);

            textBoxProject_name.Text = Program.DataEditProjectName.Value;
            textBoxProject_target.Text = Program.DataEditProjectTarget.Value;
            textBoxDate_start.Text = Program.DataEditProjectStart.Value;
            textBoxDate_completion.Text = Program.DataEditProjectCompletion.Value;
            comboBox_fk_leader.SelectedIndex = i;
        }

        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());
            DataTable ProjectTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTableComboBox);

            comboBox_fk_leader.ValueMember = "Id";
            comboBox_fk_leader.DisplayMember = "Employee";

            comboBox_fk_leader.DataSource = ProjectTableComboBox;

            connection.CloseConnect();
        }  

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int i = 1;
            i += comboBox_fk_leader.SelectedIndex;

            Program.DataEditProjectName.Value = textBoxProject_name.Text;
            Program.DataEditProjectTarget.Value = textBoxProject_target.Text;
            Program.DataEditProjectStart.Value = textBoxDate_start.Text;
            Program.DataEditProjectCompletion.Value = textBoxDate_completion.Text;
            Program.DataEditProjectLeader.Value = i.ToString();

            this.Close();
        }
    }
}
