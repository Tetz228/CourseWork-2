using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork.Status_task
{
    public partial class Status_taskForm : MaterialForm
    {
        DataTable StatusTable = new DataTable();

        public Status_taskForm()
        {
            InitializeComponent();

            this.dataGridViewStatus_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            if (Program.DataAuth.Role_user == 2)
                MainToolStripMenuItem.Visible = false;
        }

        // При загрузки формы
        private void Status_task_Load(object sender, EventArgs e)
        {
            this.dataGridViewStatus_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateStatusTask();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateStatusTask()
        {
            ConnectionDB connection = new ConnectionDB();
            StatusTable = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * " +
                "FROM Status_task", connection.GetSqlConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.OpenConnect();

            adapter.Fill(StatusTable);

            dataGridViewStatus_task.DataSource = StatusTable.DefaultView;

            connection.CloseConnect();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView view = StatusTable.DefaultView;

            view.RowFilter = string.Format("status_name_task like '%{0}%' ", textBoxSearch.Text);

            dataGridViewStatus_task.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowStatusTask()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteStatus_task", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_status_task", Convert.ToInt32(dataGridViewStatus_task.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateStatusTask();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_taskFormAdd formAdd = new Status_taskFormAdd();

            formAdd.ShowDialog();

            SelectDateStatusTask();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewStatus_task_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
                if (e.KeyCode == Keys.Insert)
                {
                    Status_taskFormAdd formAdd = new Status_taskFormAdd();

                    formAdd.ShowDialog();

                    SelectDateStatusTask();
                } 
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_taskFormEdit formEdit = new Status_taskFormEdit();

            Program.DataStatus_task.Id = Convert.ToInt32(dataGridViewStatus_task.CurrentRow.Cells[0].Value);

            Program.DataStatus_task.Name = Convert.ToString(dataGridViewStatus_task.CurrentRow.Cells[1].Value);

            formEdit.ShowDialog();

            SelectDateStatusTask();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewStatus_task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
                if (e.RowIndex != -1)
                {
                    DataGridViewRow view = dataGridViewStatus_task.Rows[e.RowIndex];

                    Program.DataStatus_task.Id = Convert.ToInt32(view.Cells[0].Value);
                    Program.DataStatus_task.Name = view.Cells[1].Value.ToString();

                    Status_taskFormEdit formEdit = new Status_taskFormEdit();

                    formEdit.ShowDialog();

                    SelectDateStatusTask();
                }   
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowStatusTask();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewStatus_task_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DeleteRowStatusTask();
            }
            else
                e.Cancel = true;
        }
    }
}
