using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class ProjectsFormAdd : MaterialForm
    {
        public ProjectsFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
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

            DataRow row = ProjectTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Руководитель";
            ProjectTableComboBox.Rows.InsertAt(row, 0);

            comboBox_fk_leader.DataSource = ProjectTableComboBox;

            connection.CloseConnect();
        }

        private void ProjectsFormAdd_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Program.DataAddProjectName.Value = textBoxProject_name.Text;
            Program.DataAddProjectTarget.Value = textBoxProject_target.Text;
            Program.DataAddProjectStart.Value = textBoxDate_start.Text;
            Program.DataAddProjectCompletion.Value = textBoxDate_completion.Text;
            Program.DataAddProjectLeader.Value = comboBox_fk_leader.SelectedValue.ToString();

            this.Close();
        }
    }
}
