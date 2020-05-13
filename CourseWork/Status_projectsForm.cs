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
            DataTable StatusTable = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Status_projects", connection.GetSqlConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.OpenConnect();

            adapter.Fill(StatusTable);

            dataGridViewStatus_projects.DataSource = StatusTable.DefaultView;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowStatusProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteStatus_project", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_status_project", Convert.ToInt32(dataGridViewStatus_projects.CurrentRow.Cells["Column_id_status_project"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateStatusProject();
        }
            
        // При клике на "Правка" -> "Добавить" открывается форма для добавления, после чего вызов функции добавления строки
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_projectsFormAdd formAdd = new Status_projectsFormAdd();
  
            formAdd.ShowDialog();

            SelectDateStatusProject();
        }

        // При нажатии на Ins(Insert) на клавиатуре появляется форма добавления
        private void dataGridViewStatus_projects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Status_projectsFormAdd formAdd = new Status_projectsFormAdd();

                formAdd.ShowDialog();

                SelectDateStatusProject();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения, после чего проверка класса и вызов функции редактирования строки
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_projectsFormEdit formEdit = new Status_projectsFormEdit();

            Program.DataEditStatus_projectId.Value = Convert.ToString(dataGridViewStatus_projects.CurrentRow.Cells["Column_id_status_project"].Value);

            Program.DataEditStatus_project.Value = Convert.ToString(dataGridViewStatus_projects.CurrentRow.Cells["Column_status_name_project"].Value);

            formEdit.ShowDialog();

            SelectDateStatusProject();
        }

        // Cобытие при 2-ом клике на ячейку вызывает форму редактирования
        private void dataGridViewStatus_projects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Если не выбрана строка, содержащие заголовки
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewStatus_projects.Rows[e.RowIndex];

                Program.DataEditStatus_project.Value = view.Cells[1].Value.ToString();

                Program.DataEditStatus_projectId.Value = Convert.ToString(dataGridViewStatus_projects.CurrentRow.Cells["Column_id_status_project"].Value);

                Status_projectsFormEdit formEdit = new Status_projectsFormEdit();

                formEdit.ShowDialog();

                SelectDateStatusProject();
            }
        }

        // При клике на "Правка" -> "Удалить"
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowStatusProject();
            else
                return;
        }

        // При выделение строки и нажатие на клавишу Del(Delete)
        private void dataGridViewStatus_projects_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowStatusProject();
            else
                e.Cancel = true;

            e.Cancel = true;
        }
    }
}
