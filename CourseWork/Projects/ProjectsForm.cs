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
        DataTable ProjectTable = new DataTable();

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

            SelectDateProject();

            radioButtonProject.Checked = true;
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectDateProject", connection.GetSqlConnect());
            ProjectTable = new DataTable();

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);
            
            connection.OpenConnect();

            sqlDA.Fill(ProjectTable);

            dataGridViewProjects.DataSource = ProjectTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonProject.Checked)
                SearchProject();
            if (radioButtonTarget.Checked)
                SearchTarget();
            //if (radioButtonStart.Checked)
            //    SearchStart();
            //if (radioButtonCompletion.Checked)
            //    SearchCompletion();
            if (radioButtonLeader.Checked)
                SearchLeader();
        }

        // Фильтр: Проект
        private void SearchProject()
        {
            DataView view = ProjectTable.DefaultView;

            view.RowFilter = string.Format("Name like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects.DataSource = view.ToTable();
        }

        // Фильтр: Цель
        private void SearchTarget()
        {
            DataView view = ProjectTable.DefaultView;

            view.RowFilter = string.Format("Target like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects.DataSource = view.ToTable();
        }

        /*// Фильтр: Дата начала
        private void SearchStart()
        {
            DataView view = ProjectTable.DefaultView;

            view.RowFilter = string.Format("Start like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects.DataSource = view.ToTable();
        }

        // Фильтр: Дата завершения
        private void SearchCompletion()
        {
            DataView view = ProjectTable.DefaultView;

            view.RowFilter = string.Format("Completion like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects.DataSource = view.ToTable();
        }
        */

        // Фильтр: Руководитель
        private void SearchLeader()
        {
            DataView view = ProjectTable.DefaultView;

            view.RowFilter = string.Format("Employee like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteProjects", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_project", Convert.ToInt32(dataGridViewProjects.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateProject();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsFormAdd formAdd = new ProjectsFormAdd();

            formAdd.ShowDialog();

            SelectDateProject();   
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewProjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                ProjectsFormAdd formAdd = new ProjectsFormAdd();

                formAdd.ShowDialog();

                SelectDateProject();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsFormEdit formEdit = new ProjectsFormEdit();

            Program.DataProject.Id = Convert.ToInt32(dataGridViewProjects.CurrentRow.Cells[0].Value);
            Program.DataProject.Name = Convert.ToString(dataGridViewProjects.CurrentRow.Cells[1].Value);
            Program.DataProject.Target = Convert.ToString(dataGridViewProjects.CurrentRow.Cells[2].Value);
            Program.DataProject.Start = Convert.ToString(dataGridViewProjects.CurrentRow.Cells[3].Value);
            Program.DataProject.Completion = Convert.ToString(dataGridViewProjects.CurrentRow.Cells[4].Value);
            Program.DataProject.Leader = Convert.ToString(dataGridViewProjects.CurrentRow.Cells[5].Value);

            formEdit.ShowDialog();

            SelectDateProject();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewProjects.Rows[e.RowIndex];

                Program.DataProject.Id = Convert.ToInt32(view.Cells[0].Value);
                Program.DataProject.Name = view.Cells[1].Value.ToString();
                Program.DataProject.Target = view.Cells[2].Value.ToString();
                Program.DataProject.Start = view.Cells[3].Value.ToString();
                Program.DataProject.Completion = view.Cells[4].Value.ToString();
                Program.DataProject.Leader = view.Cells[5].Value.ToString();

                ProjectsFormEdit formEdit = new ProjectsFormEdit();

                formEdit.ShowDialog();

                SelectDateProject();
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
        private void dataGridViewProjects_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProject();

           e.Cancel = true;
        }

        // При клике на pictureBox скрывать панель
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

        private void radioButtonTarget_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonLeader_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }
    }
}
