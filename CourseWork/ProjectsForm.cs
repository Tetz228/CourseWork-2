using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class ProjectsForm : MaterialForm
    {
        public ProjectsForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        // При загрузки формы
        private void Projects_Load(object sender, EventArgs e)
        {
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectEmployeeComboBox();

            SelectDateProject();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Projects", connection.GetSqlConnect());
            DataTable ProjectTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTable);

            dataGridViewProjects.DataSource = ProjectTable.DefaultView;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Руководитель"
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());
            DataTable ProjectTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTableComboBox);

            ComboBox_fk_leader.ValueMember = "Id";
            ComboBox_fk_leader.DisplayMember = "Employee";
            ComboBox_fk_leader.DataSource = ProjectTableComboBox;

            connection.CloseConnect();
        }

        // Функция добавления строки
        private void AddRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddProjects", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@project_name", SqlDbType.NVarChar).Value = Program.DataAddProjectName.Value;
            command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = Program.DataAddProjectTarget.Value;
            command.Parameters.AddWithValue("@date_start", SqlDbType.VarChar).Value = Program.DataAddProjectStart.Value;
            command.Parameters.AddWithValue("@date_completion", SqlDbType.VarChar).Value = Program.DataAddProjectCompletion.Value;
            command.Parameters.AddWithValue("@fk_leader", SqlDbType.Int).Value = Convert.ToInt32(Program.DataAddProjectLeader.Value);
            
            SqlParameter parameter = command.Parameters.AddWithValue("@id_project", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            SelectDateProject();

            connection.CloseConnect();
        }

        // Функция редактирования строки
        private void EditRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditProject", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@project_name", SqlDbType.NVarChar).Value = Program.DataEditProjectName.Value;
            command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = Program.DataEditProjectTarget.Value;
            command.Parameters.AddWithValue("@date_start", SqlDbType.VarChar).Value = Program.DataEditProjectStart.Value;
            command.Parameters.AddWithValue("@date_completion", SqlDbType.VarChar).Value = Program.DataEditProjectCompletion.Value;
            command.Parameters.AddWithValue("@fk_leader", SqlDbType.Int).Value = Convert.ToInt32(Program.DataEditProjectLeader.Value);
            command.Parameters.AddWithValue("@id_project", Convert.ToInt32(dataGridViewProjects.CurrentRow.Cells["Column_id_project"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateProject();
        }

        // Функция удаления строки
        private void DeleteRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteProjects", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_project", Convert.ToInt32(dataGridViewProjects.CurrentRow.Cells["Column_id_project"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateProject();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления, после чего вызов функции добавления строки
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsFormAdd formAdd = new ProjectsFormAdd();

            formAdd.ShowDialog();

            if (Program.DataValidAddProject.Value == "true")
            {
                AddRowProject();
                Program.DataValidAddProject.Value = "";
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения, после чего проверка класса и вызов функции редактирования строки
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsFormEdit formEdit = new ProjectsFormEdit();

            formEdit.ShowDialog();

            if (Program.DataValidEditProject.Value == "true")
            {
                EditRowProject();
                Program.DataValidEditProject.Value = "";
            }
        }

        // Cобытие при 2-ом клике на ячейку позволяет провести редактирование
        private void dataGridViewProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewProjects.Rows[e.RowIndex];

                Program.DataEditProjectName.Value = view.Cells[1].Value.ToString();
                Program.DataEditProjectTarget.Value = view.Cells[2].Value.ToString();
                Program.DataEditProjectStart.Value = view.Cells[3].Value.ToString();
                Program.DataEditProjectCompletion.Value = view.Cells[4].Value.ToString();
                Program.DataEditProjectLeader.Value = view.Cells[5].Value.ToString();

                ProjectsFormEdit formEdit = new ProjectsFormEdit();

                formEdit.ShowDialog();

                if (Program.DataValidEditProject.Value == "true")
                {
                    EditRowProject();
                    Program.DataValidEditProject.Value = "";
                }
            }
        }

        // При клике на "Правка" -> "Удалить"
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProject();
            else
                return;
        }

        // При выделение строки и нажание на клавишу Delete
        private void dataGridViewProjects_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProject();
            else
                e.Cancel = true;

           e.Cancel = true;
        }
    }
}
