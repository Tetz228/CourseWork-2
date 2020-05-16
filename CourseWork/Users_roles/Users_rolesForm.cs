using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseWork.Users_roles
{
    public partial class Users_rolesForm : MaterialForm
    {
        public Users_rolesForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateUsers_roles()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable PostsTable = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Users_roles", connection.GetSqlConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.OpenConnect();

            adapter.Fill(PostsTable);

            dataGridViewUsers_roles.DataSource = PostsTable.DefaultView;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowUsers_roles()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteUsers_roles", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_user_role", Convert.ToInt32(dataGridViewUsers_roles.CurrentRow.Cells["Column_id_user_role"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateUsers_roles();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users_rolesFormAdd formAdd = new Users_rolesFormAdd();

            formAdd.ShowDialog();

            SelectDateUsers_roles();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewUsers_roles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Users_rolesFormAdd formAdd = new Users_rolesFormAdd();

                formAdd.ShowDialog();

                SelectDateUsers_roles();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users_rolesFormEdit formEdit = new Users_rolesFormEdit();

            Program.DataEditUsers_rolesId.Value = Convert.ToString(dataGridViewUsers_roles.CurrentRow.Cells["Column_id_user_role"].Value);
            Program.DataEditUsers_rolesName.Value = Convert.ToString(dataGridViewUsers_roles.CurrentRow.Cells["Column_user_name_role"].Value);

            formEdit.ShowDialog();

            SelectDateUsers_roles();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewUsers_roles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewUsers_roles.Rows[e.RowIndex];

                Program.DataEditUsers_rolesId.Value = view.Cells[0].Value.ToString();
                Program.DataEditUsers_rolesName.Value = view.Cells[1].Value.ToString();

                Users_rolesFormEdit formEdit = new Users_rolesFormEdit();

                formEdit.ShowDialog();

                SelectDateUsers_roles();
            }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowUsers_roles();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewUsers_roles_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowUsers_roles();

            e.Cancel = true;
        }
    }
}
