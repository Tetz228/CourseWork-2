using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class Projects_roleForm : MaterialForm
    {
        DataTable table = new DataTable();

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
            table = new DataTable();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Projects_role", connection.GetSqlConnect());

            connection.OpenConnect();

            sqlDA.Fill(table);

            dataGridViewProjects_role.DataSource = table;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView view = table.DefaultView;

            view.RowFilter = string.Format("project_role_name like '%{0}%' ", textBoxSearch.Text);

            dataGridViewProjects_role.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowProjects_role()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteProjects_role", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_project_role", Convert.ToInt32(dataGridViewProjects_role.CurrentRow.Cells[0].Value));

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

            Program.DataEditProjects_roleId.Value = Convert.ToString(dataGridViewProjects_role.CurrentRow.Cells[0].Value);
            Program.DataEditProjects_roleName.Value = Convert.ToString(dataGridViewProjects_role.CurrentRow.Cells[1].Value);

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
