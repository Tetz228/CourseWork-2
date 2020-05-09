using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // Функция добавления строки
        private void AddRowStatusProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddStatus_project", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.Add("@status_name_project", SqlDbType.NVarChar, 20).Value = Program.DataAddStatus_project.Value;

            SqlParameter parameter = command.Parameters.Add("@id_status_project", SqlDbType.Int, 0, "id_status_project");

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateStatusProject();
        }

        // Функция редактирования строки
        private void EditRowStatusProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditStatus_project", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.Add("@status_name_project", SqlDbType.NVarChar, 20).Value = Program.DataEditStatus_project.Value;
            command.Parameters.AddWithValue("@id_status_project", Convert.ToInt32(dataGridViewStatus_projects.CurrentRow.Cells["Column_id_status_project"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateStatusProject();
        }

        // Функция удаления строки
        private void DeleteRowStatusProject()
        {
            if (dataGridViewStatus_projects.CurrentRow.Cells["Column_id_status_project"].Value != DBNull.Value)
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionDB connection = new ConnectionDB();
                    SqlCommand command = new SqlCommand("DeleteStatus_project", connection.GetSqlConnect());

                    connection.OpenConnect();

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id_status_project", Convert.ToInt32(dataGridViewStatus_projects.CurrentRow.Cells["Column_id_status_project"].Value));

                    command.ExecuteNonQuery();

                    connection.CloseConnect();
                }
                else
                    return;
            else
            {
                MessageBox.Show("Вы не выбрали строку. Выберите строку и повторите удаление.");
                return;
            }

            SelectDateStatusProject();
        }
        
        // При клике на "Правка" -> "Добавить"
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_projectsFormAdd formAdd = new Status_projectsFormAdd();
  
            formAdd.ShowDialog();

            //AddRowStatusProject();
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения, после чего вызов функции редактирования строки
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status_projectsFormEdit formEdit = new Status_projectsFormEdit();

            formEdit.ShowDialog();

            //EditRowStatusProject();
        }

        // Отработка события редактирования при 2-ом клике на ячейку
        private void dataGridViewStatus_projects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewStatus_projects.Rows[e.RowIndex];

                Program.DataEditStatus_project.Value = view.Cells[1].Value.ToString();

                Status_projectsFormEdit formEdit = new Status_projectsFormEdit();

                formEdit.ShowDialog();

                EditRowStatusProject();
            }
        }

        // При клике на "Правка" -> "Удалить"
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRowStatusProject();
        }      
    }
}
