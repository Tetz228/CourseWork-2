using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork.Projects_task
{
    public partial class Projects_taskFormAdd : MaterialForm
    {
        public Projects_taskFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Projects_taskFormAdd_Load(object sender, EventArgs e)
        {
            SelectProjectComboBox();

            SelectTypeComboBox();

            SelectEmployeeComboBox();

            SelectRoleComboBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                AddRowProjects_task();
                this.Close();
            } 
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

            DataRow row = Projects_taskTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Проект";
            Projects_taskTableComboBox.Rows.InsertAt(row, 0);

            comboBox_fk_project.DataSource = Projects_taskTableComboBox;

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

            comboBox_fk_type_task.ValueMember = "Id";
            comboBox_fk_type_task.DisplayMember = "Type";

            DataRow row = Projects_taskTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Тип задачи";
            Projects_taskTableComboBox.Rows.InsertAt(row, 0);

            comboBox_fk_type_task.DataSource = Projects_taskTableComboBox;

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

            comboBox_fk_employee.ValueMember = "Id";
            comboBox_fk_employee.DisplayMember = "Employee";

            DataRow row = Projects_taskTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Сотрудник";
            Projects_taskTableComboBox.Rows.InsertAt(row, 0);

            comboBox_fk_employee.DataSource = Projects_taskTableComboBox;

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

            comboBox_fk_project_role.ValueMember = "Id";
            comboBox_fk_project_role.DisplayMember = "Role";

            DataRow row = Projects_taskTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Роль в проекте";
            Projects_taskTableComboBox.Rows.InsertAt(row, 0);

            comboBox_fk_project_role.DataSource = Projects_taskTableComboBox;

            connection.CloseConnect();
        }

        // Функция добавления строки
        private void AddRowProjects_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddProjects_task", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@fk_project", SqlDbType.NVarChar).Value = comboBox_fk_project.SelectedValue;
            command.Parameters.AddWithValue("@fk_type_task", SqlDbType.Date).Value = comboBox_fk_type_task.SelectedValue;
            command.Parameters.AddWithValue("@fk_employee", SqlDbType.Date).Value = comboBox_fk_employee.SelectedValue;
            command.Parameters.AddWithValue("@fk_project_role", SqlDbType.NVarChar).Value = comboBox_fk_project_role.SelectedValue;

            SqlParameter parameter = command.Parameters.AddWithValue("@id_task", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Проверки на пустоту полей
        private bool CheckTextBox()
        {
            int check = 0;

            if (comboBox_fk_project.Text == "Проект")
            {
                labelValidProject.Show();

                check = 1;
            }
            if (comboBox_fk_type_task.Text == "Тип задачи")
            {
                labelValidType.Show();

                check = 1;
            }
            if (comboBox_fk_employee.Text == "Сотрудник")
            {
                labelValidEmployee.Show();

                check = 1;
            }
            if (comboBox_fk_project_role.Text == "Роль в проекте")
            {
                labelValidRole.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
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
