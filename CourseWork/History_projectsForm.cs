using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class History_projectsForm : MaterialForm
    {
        public History_projectsForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewHistory_projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        // При загрузки формы
        private void History_projectsForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewHistory_projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectProjectComboBox();

            SelectStatusComboBox();

            SelectDateHistory_projects();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateHistory_projects()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM History_projects", connection.GetSqlConnect());
            DataTable HistoryTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTable);

            dataGridViewHistory_projects.DataSource = HistoryTable.DefaultView;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Проект"
        private void SelectProjectComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_project AS Id, project_name AS Project FROM Projects", connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_project.ValueMember = "Id";
            ComboBox_fk_project.DisplayMember = "Project";
            ComboBox_fk_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Статус"
        private void SelectStatusComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_status_project AS Id, status_name_project AS Status FROM Status_projects", connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_status_project.ValueMember = "Id";
            ComboBox_fk_status_project.DisplayMember = "Status";
            ComboBox_fk_status_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowHistoryProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteHistoryProjects", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_history_project", Convert.ToInt32(dataGridViewHistory_projects.CurrentRow.Cells["Column_id_history_project"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateHistory_projects();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления, после чего вызов функции добавления строки
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_projectsFormAdd formAdd = new History_projectsFormAdd();

            formAdd.ShowDialog();

            SelectDateHistory_projects();
        }

        // При нажатии на Ins(Insert) на клавиатуре появляется форма добавления
        private void dataGridViewHistory_projects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                History_projectsFormAdd formAdd = new History_projectsFormAdd();

                formAdd.ShowDialog();

                SelectDateHistory_projects();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения, после чего проверка класса и вызов функции редактирования строки
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_projectsFormEdit formEdit = new History_projectsFormEdit();

            Program.DataEditHistoryProjectId.Value = Convert.ToString(dataGridViewHistory_projects.CurrentRow.Cells["Column_id_history_project"].Value);
            Program.DataEditHistoryProjectName.Value = Convert.ToString(dataGridViewHistory_projects.CurrentRow.Cells["ComboBox_fk_project"].Value);
            Program.DataEditHistoryProjectStatus.Value = Convert.ToString(dataGridViewHistory_projects.CurrentRow.Cells["ComboBox_fk_status_project"].Value); 
            Program.DataEditHistoryProjectDate.Value = Convert.ToString(dataGridViewHistory_projects.CurrentRow.Cells["Column_history_date_project"].Value); 

            formEdit.ShowDialog();

            SelectDateHistory_projects();
        }

        // Cобытие при 2-ом клике на ячейку позволяет провести редактирование
        private void dataGridViewHistory_projects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewHistory_projects.Rows[e.RowIndex];

                Program.DataEditHistoryProjectId.Value = view.Cells[0].Value.ToString();
                Program.DataEditHistoryProjectName.Value = view.Cells[1].Value.ToString();
                Program.DataEditHistoryProjectStatus.Value = view.Cells[2].Value.ToString();
                Program.DataEditHistoryProjectDate.Value = view.Cells[3].Value.ToString();

                History_projectsFormEdit formEdit = new History_projectsFormEdit();

                formEdit.ShowDialog();

                SelectDateHistory_projects();
            }
        }

        // При клике на "Правка" -> "Удалить"
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowHistoryProject();
            else
                return;
        }

        // При выделение строки и нажание на клавишу Del(Delete)
        private void dataGridViewHistory_projects_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowHistoryProject();
            else
                e.Cancel = true;

            e.Cancel = true;
        }
    }
}
