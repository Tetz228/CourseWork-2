using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class Status_projectsForm : MaterialForm
    {
        DataTable StatusTable = new DataTable();

        public Status_projectsForm()
        {
            InitializeComponent();

            this.dataGridViewStatus_projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void Status_projects_Load(object sender, EventArgs e)
        {
            this.dataGridViewStatus_projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateStatusProject();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateStatusProject()
        {
            ConnectionDB connection = new ConnectionDB();
            StatusTable = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Status_projects", connection.GetSqlConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.OpenConnect();

            adapter.Fill(StatusTable);

            dataGridViewStatus_projects.DataSource = StatusTable.DefaultView;

            connection.CloseConnect();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView view = StatusTable.DefaultView;

            view.RowFilter = string.Format("status_name_project like '%{0}%' ", textBoxSearch.Text);

            dataGridViewStatus_projects.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowStatusProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteStatus_project", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_status_project", Convert.ToInt32(dataGridViewStatus_projects.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateStatusProject();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_projectsFormAdd formAdd = new Status_projectsFormAdd();
  
            formAdd.ShowDialog();

            SelectDateStatusProject();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewStatus_projects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Status_projectsFormAdd formAdd = new Status_projectsFormAdd();

                formAdd.ShowDialog();

                SelectDateStatusProject();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_projectsFormEdit formEdit = new Status_projectsFormEdit();

            Program.DataStatus_project.Id = Convert.ToInt32(dataGridViewStatus_projects.CurrentRow.Cells[0].Value);
            Program.DataStatus_project.Name = Convert.ToString(dataGridViewStatus_projects.CurrentRow.Cells[1].Value);

            formEdit.ShowDialog();

            SelectDateStatusProject();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewStatus_projects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Если не выбрана строка, содержащие заголовки
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewStatus_projects.Rows[e.RowIndex];

                Program.DataStatus_project.Id = Convert.ToInt32(view.Cells[0].Value);
                Program.DataStatus_project.Name = view.Cells[1].Value.ToString();

                Status_projectsFormEdit formEdit = new Status_projectsFormEdit();

                formEdit.ShowDialog();

                SelectDateStatusProject();
            }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowStatusProject();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewStatus_projects_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowStatusProject();
           
            e.Cancel = true;
        }
    }
}
