using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork.Projects_task
{
    public partial class Projects_taskForm : MaterialForm
    {
        DataTable Projects_taskTable = new DataTable();

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
            SelectDateProject_task();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateProject_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectDateProject_task", connection.GetSqlConnect());
            Projects_taskTable = new DataTable();

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);

            connection.OpenConnect();

            sqlDA.Fill(Projects_taskTable);

            dataGridViewProjects_task.DataSource = Projects_taskTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonProject.Checked)
                SearchProject();
            if (radioButtonType.Checked)
                SearchType();
            if (radioButtonEmployee.Checked)
                SearchEmployee();
            if (radioButtonRole.Checked)
                SearchRole();
        }

        // Фильтр: Проект
        private void SearchProject()
        {
            DataView view = Projects_taskTable.DefaultView;

            view.RowFilter = string.Format("Project like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects_task.DataSource = view.ToTable();
        }

        // Фильтр: Тип задачи
        private void SearchType()
        {
            DataView view = Projects_taskTable.DefaultView;

            view.RowFilter = string.Format("Type like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects_task.DataSource = view.ToTable();
        }

        // Фильтр: Сотрудник
        private void SearchEmployee()
        {
            DataView view = Projects_taskTable.DefaultView;

            view.RowFilter = string.Format("Employee like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects_task.DataSource = view.ToTable();
        }

        // Фильтр: Роль
        private void SearchRole()
        {
            DataView view = Projects_taskTable.DefaultView;

            view.RowFilter = string.Format("Role like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects_task.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteProjects_task", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_task", Convert.ToInt32(dataGridViewProjects_task.CurrentRow.Cells[0].Value));

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
            Program.DataEditProjects_taskId.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells[0].Value);
            Program.DataEditProjects_taskProject.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells[1].Value);
            Program.DataEditProjects_taskType_task.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells[2].Value);
            Program.DataEditProjects_taskEmployee.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells[3].Value);
            Program.DataEditProjects_taskProject_role.Value = Convert.ToString(dataGridViewProjects_task.CurrentRow.Cells[4].Value);

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

        // При клике на pictureBox скрывать / показывать панель
        private void pictureBoxFilters_Click(object sender, EventArgs e)
        {
            if (panelFilters.Visible == false)
                panelFilters.Visible = true;
            else
                panelFilters.Visible = false;
        }

        // При клике на переключатели скрывать панель
        private void radioButtonProject_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonType_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonEmployee_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonRole_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }
    }
}
