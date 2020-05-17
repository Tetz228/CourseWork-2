using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Drawing;

namespace CourseWork.Projects_task
{
    public partial class Projects_taskForm : MaterialForm
    {
        public Projects_taskForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewProjects_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void Projects_taskForm_Load(object sender, EventArgs e)
        {
            SelectProjectComboBox();

            SelectTypeComboBox();

            SelectEmployeeComboBox();

            SelectRoleComboBox();

            SelectDateProject_task();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateProject_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Projects_task", connection.GetSqlConnect());
            DataTable Projects_taskTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTable);

            dataGridViewProjects_task.DataSource = Projects_taskTable.DefaultView;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Проект"
        private void SelectProjectComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_project AS Id, project_name AS Project FROM Projects", connection.GetSqlConnect());
            DataTable Projects_taskTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTableComboBox);

            ComboBox_fk_project.ValueMember = "Id";
            ComboBox_fk_project.DisplayMember = "Project";
            ComboBox_fk_project.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Тип задачи"
        private void SelectTypeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_type_task AS Id, task_name_type AS Type FROM Type_task", connection.GetSqlConnect());
            DataTable Projects_taskTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTableComboBox);

            ComboBox_fk_type_task.ValueMember = "Id";
            ComboBox_fk_type_task.DisplayMember = "Type";
            ComboBox_fk_type_task.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Сотрудник"
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());
            DataTable Projects_taskTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTableComboBox);

            ComboBox_fk_employee.ValueMember = "Id";
            ComboBox_fk_employee.DisplayMember = "Employee";
            ComboBox_fk_employee.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Роль в проекте"
        private void SelectRoleComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_project_role AS Id, project_role_name AS Role FROM Projects_role", connection.GetSqlConnect());
            DataTable Projects_taskTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTableComboBox);

            ComboBox_fk_project_role.ValueMember = "Id";
            ComboBox_fk_project_role.DisplayMember = "Role";
            ComboBox_fk_project_role.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }
    }
}
