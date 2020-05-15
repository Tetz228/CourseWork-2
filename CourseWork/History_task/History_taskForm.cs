using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace CourseWork.History_task
{
    public partial class History_taskForm : MaterialForm
    {
        public History_taskForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewHistory_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        // При загрузки формы
        private void History_taskForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewHistory_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectTaskComboBox();

            SelectStatusComboBox();

            SelectDateHistory_task();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateHistory_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM History_task", connection.GetSqlConnect());
            DataTable HistoryTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTable);

            dataGridViewHistory_task.DataSource = HistoryTable.DefaultView;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Задача"
        private void SelectTaskComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectHistory_taskComboBox", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_project_task.ValueMember = "Id";
            ComboBox_fk_project_task.DisplayMember = "Task";
            ComboBox_fk_project_task.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Статус"
        private void SelectStatusComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter(
                "SELECT id_status_task AS Id, " +
                "status_name_task AS Status " +
                "FROM Status_task", 
                connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_status_task.ValueMember = "Id";
            ComboBox_fk_status_task.DisplayMember = "Status";
            ComboBox_fk_status_task.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowHistoryTask()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteHistoryTask", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_history_task", Convert.ToInt32(dataGridViewHistory_task.CurrentRow.Cells["Column_id_history_task"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateHistory_task();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_taskFormAdd formAdd = new History_taskFormAdd();

            formAdd.ShowDialog();

            SelectDateHistory_task();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewHistory_task_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                History_taskFormAdd formAdd = new History_taskFormAdd();

                formAdd.ShowDialog();

                SelectDateHistory_task();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_taskFormEdit formEdit = new History_taskFormEdit();

            Program.DataEditHistoryTaskId.Value = Convert.ToString(dataGridViewHistory_task.CurrentRow.Cells["Column_id_history_task"].Value);
            Program.DataEditHistoryTaskName.Value = Convert.ToString(dataGridViewHistory_task.CurrentRow.Cells["ComboBox_fk_project_task"].Value);
            Program.DataEditHistoryTaskStatus.Value = Convert.ToString(dataGridViewHistory_task.CurrentRow.Cells["ComboBox_fk_status_task"].Value);
            Program.DataEditHistoryTaskDate.Value = Convert.ToString(dataGridViewHistory_task.CurrentRow.Cells["Column_history_date_task"].Value);

            formEdit.ShowDialog();

            SelectDateHistory_task();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewHistory_task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewHistory_task.Rows[e.RowIndex];

                Program.DataEditHistoryTaskId.Value = view.Cells[0].Value.ToString();
                Program.DataEditHistoryTaskName.Value = view.Cells[1].Value.ToString();
                Program.DataEditHistoryTaskStatus.Value = view.Cells[2].Value.ToString();
                Program.DataEditHistoryTaskDate.Value = view.Cells[3].Value.ToString();

                History_taskFormEdit formEdit = new History_taskFormEdit();

                formEdit.ShowDialog();

                SelectDateHistory_task();
            }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowHistoryTask();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewHistory_task_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowHistoryTask();

            e.Cancel = true;
        }
    }
}
