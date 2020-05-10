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

        // Функция добавления строки
        private void AddRowHistory()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddHistory", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@fk_project", SqlDbType.Int).Value = Convert.ToInt32(Program.DataAddHistoryProject.Value);
            command.Parameters.AddWithValue("@fk_status_project", SqlDbType.Int).Value = Convert.ToInt32(Program.DataAddHistoryStatus.Value);
            command.Parameters.AddWithValue("@history_date_project", SqlDbType.VarChar).Value = Program.DataAddHistoryDate.Value;

            SqlParameter parameter = command.Parameters.AddWithValue("@id_history_project", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            SelectDateHistory_projects();

            connection.CloseConnect();
        }

        // Функция редактирования строки
        private void EditRowHistory()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditHistory", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@fk_project", SqlDbType.Int).Value = Convert.ToInt32(Program.DataEditHistoryProject.Value);
            command.Parameters.AddWithValue("@fk_status_project", SqlDbType.Int).Value = Convert.ToInt32(Program.DataEditHistoryStatus.Value);
            command.Parameters.AddWithValue("@history_date_project", SqlDbType.VarChar).Value = Program.DataEditHistoryDate.Value;

            command.Parameters.AddWithValue("@id_history_project", Convert.ToInt32(dataGridViewHistory_projects.CurrentRow.Cells["Column_id_history_project"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateHistory_projects();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_projectsFormAdd formAdd = new History_projectsFormAdd();

            formAdd.ShowDialog();

            AddRowHistory();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_projectsFormEdit formEdit = new History_projectsFormEdit();

            formEdit.ShowDialog();

            EditRowHistory();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewHistory_projects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewHistory_projects.Rows[e.RowIndex];

                Program.DataEditHistoryProject.Value = view.Cells[1].Value.ToString();
                Program.DataEditHistoryStatus.Value = view.Cells[2].Value.ToString();
                Program.DataEditHistoryDate.Value = view.Cells[3].Value.ToString();

                History_projectsFormEdit formEdit = new History_projectsFormEdit();

                formEdit.ShowDialog();

                EditRowHistory();
            }
        }
    }
}
