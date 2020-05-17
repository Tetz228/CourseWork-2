using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork.Type_task
{
    public partial class Type_taskForm : MaterialForm
    {
        public Type_taskForm()
        {
            InitializeComponent();

            this.dataGridViewType_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

             var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void Type_task_Load(object sender, EventArgs e)
        {
            this.dataGridViewType_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateType_task();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateType_task()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable StatusTable = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Type_task", connection.GetSqlConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.OpenConnect();

            adapter.Fill(StatusTable);

            dataGridViewType_task.DataSource = StatusTable.DefaultView;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowType_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteType_task", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_type_task", Convert.ToInt32(dataGridViewType_task.CurrentRow.Cells["Column_id_type_task"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateType_task();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type_taskFormAdd formAdd = new Type_taskFormAdd();

            formAdd.ShowDialog();

            SelectDateType_task();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewStatus_task_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Type_taskFormAdd formAdd = new Type_taskFormAdd();

                formAdd.ShowDialog();

                SelectDateType_task();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type_taskFormEdit formEdit = new Type_taskFormEdit();

            Program.DataEditType_taskId.Value = Convert.ToString(dataGridViewType_task.CurrentRow.Cells["Column_id_status_task"].Value);

            Program.DataEditType_taskName.Value = Convert.ToString(dataGridViewType_task.CurrentRow.Cells["Column_status_name_task"].Value);

            formEdit.ShowDialog();

            SelectDateType_task();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewStatus_task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Если не выбрана строка, содержащие заголовки
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewType_task.Rows[e.RowIndex];

                Program.DataEditType_taskId.Value = view.Cells[0].Value.ToString();
                Program.DataEditType_taskName.Value = view.Cells[1].Value.ToString();

                Type_taskFormEdit formEdit = new Type_taskFormEdit();

                formEdit.ShowDialog();

                SelectDateType_task();
            }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowType_task();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewStatus_task_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowType_task();

            e.Cancel = true;
        }
    }
}
