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

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects_roleFormAdd formAdd = new Projects_roleFormAdd();

            formAdd.ShowDialog();

            SelectDateProjects_role();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void Projects_roleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Projects_roleFormAdd formAdd = new Projects_roleFormAdd();

                formAdd.ShowDialog();

                SelectDateProjects_role();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects_roleFormEdit formEdit = new Projects_roleFormEdit();

            Program.DataEditProjects_roleId.Value = Convert.ToString(dataGridViewProjects_role.CurrentRow.Cells["Column_id_project_role"].Value);

            Program.DataEditProjects_roleName.Value = Convert.ToString(dataGridViewProjects_role.CurrentRow.Cells["Column_project_role_name"].Value);

            formEdit.ShowDialog();

            SelectDateProjects_role();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewProjects_role_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Если не выбрана строка, содержащие заголовки
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewProjects_role.Rows[e.RowIndex];

                Program.DataEditProjects_roleId.Value = view.Cells[0].Value.ToString();
                Program.DataEditProjects_roleName.Value = view.Cells[1].Value.ToString();

                Projects_roleFormEdit formEdit = new Projects_roleFormEdit();

                formEdit.ShowDialog();

                SelectDateProjects_role();
            }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProjects_role();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewProjects_role_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowProjects_role();
           
            e.Cancel = true;
        }
    }
}
