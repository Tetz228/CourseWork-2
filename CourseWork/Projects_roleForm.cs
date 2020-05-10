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

        private void Projects_roleForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewProjects_role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateProjects_role();
        }

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

            SqlParameter parameter = command.Parameters.Add("@id_project_role", SqlDbType.Int, 0, "id_project_role");

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
            if (dataGridViewProjects_role.CurrentRow.Cells["Column_id_project_role"].Value != DBNull.Value)
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionDB connection = new ConnectionDB();
                    SqlCommand command = new SqlCommand("DeleteProjects_role", connection.GetSqlConnect());

                    connection.OpenConnect();

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id_project_role", Convert.ToInt32(dataGridViewProjects_role.CurrentRow.Cells["Column_id_project_role"].Value));

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

            SelectDateProjects_role();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects_roleFormAdd formAdd = new Projects_roleFormAdd();

            formAdd.ShowDialog();

            AddRowProjects_role();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects_roleFormEdit formEdit = new Projects_roleFormEdit();

            formEdit.ShowDialog();

            EditRowProjects_role();
        }

        // Cобытие при 2-ом клике на ячейку позволяет провести редактирование



        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRowProjects_role();
        }

        private void dataGridViewProjects_role_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewProjects_role.Rows[e.RowIndex];

                Program.DataEditProjects_role.Value = view.Cells[1].Value.ToString();

                Projects_roleFormEdit formEdit = new Projects_roleFormEdit();

                formEdit.ShowDialog();

                EditRowProjects_role();
            }
        }
    }
}
