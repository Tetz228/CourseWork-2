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

        // Функция удаления строки
        private void DeleteRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteProjects_task", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_task", Convert.ToInt32(dataGridViewProjects_task.CurrentRow.Cells["Column_id_task"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateProject_task();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects_taskFormAdd formAdd = new Projects_taskFormAdd();

            formAdd.ShowDialog();

            SelectDateProject_task();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewProjects_task_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Projects_taskFormAdd formAdd = new Projects_taskFormAdd();

                formAdd.ShowDialog();

                SelectDateProject_task();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DataEditProjects_taskId.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells["Column_id_task"].Value);
            Program.DataEditProjects_taskProject.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells["ComboBox_fk_project"].Value);
            Program.DataEditProjects_taskType_task.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells["ComboBox_fk_type_task"].Value);
            Program.DataEditProjects_taskEmployee.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells["ComboBox_fk_employee"].Value);
            Program.DataEditProjects_taskProject_role.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells["ComboBox_fk_project_role"].Value);

            Projects_taskFormEdit formEdit = new Projects_taskFormEdit();

            formEdit.ShowDialog();

            SelectDateProject_task();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewProjects_task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewProjects_task.Rows[e.RowIndex];

                Program.DataEditProjects_taskId.Value = view.Cells[0].Value.ToString();
                Program.DataEditProjects_taskProject.Value = view.Cells[1].Value.ToString();
                Program.DataEditProjects_taskType_task.Value = view.Cells[2].Value.ToString();
                Program.DataEditProjects_taskEmployee.Value = view.Cells[3].Value.ToString();
                Program.DataEditProjects_taskProject_role.Value = view.Cells[4].Value.ToString();

                Projects_taskFormEdit formEdit = new Projects_taskFormEdit();

                formEdit.ShowDialog();

                SelectDateProject_task();
            }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProject();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewProjects_task_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProject();

            e.Cancel = true;
        }
    }
}
