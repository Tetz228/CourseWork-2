using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using CourseWork.Main;

namespace CourseWork.Users
{
    public partial class UsersForm : MaterialForm
    {
        DataTable UserTable = new DataTable();

        public UsersForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        // При загрузки формы
        private void Users_Load(object sender, EventArgs e)
        {
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            radioButtonLogin.Checked = true;

            SelectDateUsers();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateUsers()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectDateUsers", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            UserTable = new DataTable();

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);

            connection.OpenConnect();

            sqlDA.Fill(UserTable);

            dataGridViewUsers.DataSource = UserTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string emp = "Employee like '%{0}%' ";
            string role = "RoleUser like '%{0}%' ";
            string log = "Login like '%{0}%' ";

            if (radioButtonEmployee.Checked)
                Search(emp);
            if (radioButtonRoleUsers.Checked)
                Search(role);
            if(radioButtonLogin.Checked)
                Search(log);
        }

        // Функция поиска
        private void Search(string f)
        {
            DataView view = UserTable.DefaultView;

            view.RowFilter = string.Format(f, textBoxSearch.Text);

            dataGridViewUsers.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowUser()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteUsers", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_user", Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateUsers();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersFormAdd formAdd = new UsersFormAdd();

            formAdd.ShowDialog();

            SelectDateUsers();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                UsersFormAdd formAdd = new UsersFormAdd();

                formAdd.ShowDialog();

                SelectDateUsers();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Values.UserId  = Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells[0].Value);
            Values.UserLogin = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[1].Value);
            Values.UserPassword = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[2].Value);
            Values.UserRole = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[3].Value);
            Values.UserEmployee = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[4].Value);

            UsersFormEdit formEdit = new UsersFormEdit();

            formEdit.ShowDialog();

            SelectDateUsers();
        }
    
        // При 2-ом клике на ячейку можно провести редактирование 
        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewUsers.Rows[e.RowIndex];

                Values.UserId = Convert.ToInt32(view.Cells[0].Value);
                Values.UserLogin = view.Cells[1].Value.ToString();
                Values.UserPassword = view.Cells[2].Value.ToString();
                Values.UserRole = view.Cells[3].Value.ToString();
                Values.UserEmployee = view.Cells[4].Value.ToString();                

                UsersFormEdit formEdit = new UsersFormEdit();

                formEdit.ShowDialog();

                SelectDateUsers();
            }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowUser();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowUser();

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
        private void radioButtonLogin_CheckedChanged(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonRoleUsers_CheckedChanged(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonEmployee_CheckedChanged(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }
    }
}
