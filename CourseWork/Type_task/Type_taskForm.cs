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
        DataTable TypeTable = new DataTable();

        public Type_taskForm()
        {
            InitializeComponent();

            this.dataGridViewType_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            if (Program.DataAuth.Role_user == 2)
                MainToolStripMenuItem.Visible = false;
        }

        // При загрузки формы
        private void Type_task_Load(object sender, EventArgs e)
        {
            this.dataGridViewType_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateType_task();

            radioButtonName.Checked = true;
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateType_task()
        {
            ConnectionDB connection = new ConnectionDB();
            TypeTable = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * " +
                "FROM Type_task", connection.GetSqlConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.OpenConnect();

            adapter.Fill(TypeTable);

            dataGridViewType_task.DataSource = TypeTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string name = "task_name_type like '%{0}%' ";
            string descr = "task_description like '%{0}%' ";

            if (radioButtonName.Checked)
                Search(name);
            if (radioButtonDescription.Checked)
                Search(descr);
        }

        // Функция поиска
        private void Search(string f)
        {
            DataView view = TypeTable.DefaultView;

            view.RowFilter = string.Format(f, textBoxSearch.Text);

            dataGridViewType_task.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowType_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteType_task", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_type_task", Convert.ToInt32(dataGridViewType_task.CurrentRow.Cells[0].Value));

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
        private void dataGridViewType_task_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
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

            Program.DataType_task.Id = Convert.ToInt32(dataGridViewType_task.CurrentRow.Cells[0].Value);
            Program.DataType_task.Name = Convert.ToString(dataGridViewType_task.CurrentRow.Cells[1].Value);
            Program.DataType_task.Description = Convert.ToString(dataGridViewType_task.CurrentRow.Cells[2].Value);

            formEdit.ShowDialog();

            SelectDateType_task();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewType_task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
                if (e.RowIndex != -1)
                {
                    DataGridViewRow view = dataGridViewType_task.Rows[e.RowIndex];

                    Program.DataType_task.Id = Convert.ToInt32(view.Cells[0].Value);
                    Program.DataType_task.Name = view.Cells[1].Value.ToString();
                    Program.DataType_task.Description = view.Cells[2].Value.ToString();

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
        private void dataGridViewType_task_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DeleteRowType_task();
                e.Cancel = true;
            }
            else
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
        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonDescription_CheckedChanged(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }
    }
}
