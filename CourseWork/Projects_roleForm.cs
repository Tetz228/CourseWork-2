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
    public partial class Projects_roleForm : MaterialForm
    {
        public Projects_roleForm()
        {
            InitializeComponent();

            this.dataGridViewProjects_role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void Projects_roleForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewProjects_role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateProjects_role();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateProjects_role()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Projects_role", connection.GetSqlConnect());

            DataTable table = new DataTable();
            sqlDA.Fill(table);

            dataGridViewProjects_role.DataSource = table;

            connection.CloseConnect();
        }

        // Функция добавления строки
        private void AddRowProjects_role()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddProjects_role", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@project_role_name", SqlDbType.NVarChar).Value = Program.DataAddProjects_role.Value;

            SqlParameter parameter = command.Parameters.AddWithValue("@id_project_role", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateProjects_role();
        }

        // Функция редактирования строки
        private void EditRowProjects_role()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditProjects_role", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@project_role_name", SqlDbType.NVarChar).Value = Program.DataEditProjects_role.Value;
            command.Parameters.AddWithValue("@id_project_role", Convert.ToInt32(dataGridViewProjects_role.CurrentRow.Cells["Column_id_project_role"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateProjects_role();
        }

        // Функция удаления строки
        private void DeleteRowProjects_role()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteProjects_role", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_project_role", Convert.ToInt32(dataGridViewProjects_role.CurrentRow.Cells["Column_id_project_role"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateProjects_role();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления, после чего вызов функции добавления строки
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects_roleFormAdd formAdd = new Projects_roleFormAdd();

            formAdd.ShowDialog();

            if (Program.DataValidAddProjects_role.Value == "true")
            {
                AddRowProjects_role();
                Program.DataValidAddProjects_role.Value = "";
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения, после чего проверка класса и вызов функции редактирования строки
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects_roleFormEdit formEdit = new Projects_roleFormEdit();

            formEdit.ShowDialog();

            if (Program.DataValidEditProjects_role.Value == "true")
            {
                EditRowProjects_role();
                Program.DataValidEditProjects_role.Value = "";
            }
        }

        // Cобытие при 2-ом клике на ячейку позволяет провести редактирование
        private void dataGridViewProjects_role_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Если не выбрана строка, содержащие заголовки
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewProjects_role.Rows[e.RowIndex];

                Program.DataEditProjects_role.Value = view.Cells[1].Value.ToString();

                Projects_roleFormEdit formEdit = new Projects_roleFormEdit();

                formEdit.ShowDialog();

                if (Program.DataValidEditProjects_role.Value == "true")
                {
                    EditRowProjects_role();
                    Program.DataValidEditProjects_role.Value = "";
                }
            }
        }

        // При клике на "Правка" -> "Удалить"
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProjects_role();
            else
                return;
        }

        // При выделение строки и нажание на клавишу Delete
        private void dataGridViewProjects_role_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProjects_role();
            else
                e.Cancel = true;

            e.Cancel = true;
        }
    }
}
