using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;
namespace CourseWork.Projects_task
{
    public partial class Projects_taskFormEdit : MaterialForm
    {
        public Projects_taskFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Projects_taskFormEdit_Load(object sender, EventArgs e)
        {
            SelectProjectComboBox();

            SelectTypeComboBox();

            SelectEmployeeComboBox();

            SelectRoleComboBox();

            int indexProj = comboBox_fk_project.FindString(Program.DataEditProjects_taskProject.Value);
            int indexType = comboBox_fk_type_task.FindString(Program.DataEditProjects_taskType_task.Value);
            int indexEmp = comboBox_fk_employee.FindString(Program.DataEditProjects_taskEmployee.Value);
            int indexRole = comboBox_fk_project_role.FindString(Program.DataEditProjects_taskProject_role.Value);

            comboBox_fk_project.SelectedIndex = indexProj;
            comboBox_fk_type_task.SelectedIndex = indexType;
            comboBox_fk_employee.SelectedIndex = indexEmp;
            comboBox_fk_project_role.SelectedIndex = indexRole;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditRowProjects_task();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Заполнение ComboBox`а "Проект"
        private void SelectProjectComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_project AS Id, project_name AS Project FROM Projects", connection.GetSqlConnect());
            DataTable Projects_taskTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTableComboBox);

            comboBox_fk_project.ValueMember = "Id";
            comboBox_fk_project.DisplayMember = "Project";
            comboBox_fk_project.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Тип задачи"
        private void SelectTypeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_type_task AS Id, " +
                "task_name_type AS Type " +
                "FROM Type_task", connection.GetSqlConnect());
            DataTable Projects_taskTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTableComboBox);

            comboBox_fk_type_task.ValueMember = "Id";
            comboBox_fk_type_task.DisplayMember = "Type";
            comboBox_fk_type_task.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Сотрудник"
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, " +
                "CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee " +
                "FROM Employees", connection.GetSqlConnect());
            DataTable Projects_taskTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTableComboBox);

            comboBox_fk_employee.ValueMember = "Id";
            comboBox_fk_employee.DisplayMember = "Employee";
            comboBox_fk_employee.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Роль в проекте"
        private void SelectRoleComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_project_role AS Id, " +
                "project_role_name AS Role " +
                "FROM Projects_role", connection.GetSqlConnect());
            DataTable Projects_taskTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTableComboBox);

            comboBox_fk_project_role.ValueMember = "Id";
            comboBox_fk_project_role.DisplayMember = "Role";
            comboBox_fk_project_role.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }

        // Функция добавления строки
        private void EditRowProjects_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditProjects_task", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@fk_project", SqlDbType.NVarChar).Value = comboBox_fk_project.SelectedValue;
            command.Parameters.AddWithValue("@fk_type_task", SqlDbType.Date).Value = comboBox_fk_type_task.SelectedValue;
            command.Parameters.AddWithValue("@fk_employee", SqlDbType.Date).Value = comboBox_fk_employee.SelectedValue;
            command.Parameters.AddWithValue("@fk_project_role", SqlDbType.NVarChar).Value = comboBox_fk_project_role.SelectedValue;
            command.Parameters.AddWithValue("@id_task", SqlDbType.NVarChar).Value = Convert.ToInt32(Program.DataEditProjects_taskId.Value);

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        private void comboBox_fk_project_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidProject.Hide();
        }

        private void comboBox_fk_type_task_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidType.Hide();
        }

        private void comboBox_fk_employee_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidEmployee.Hide();
        }

        private void comboBox_fk_project_role_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidRole.Hide();
        }
    }
}
