using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

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
            if (radioButtonEmployee.Checked)
                SearchEmployee();
            if (radioButtonRoleUsers.Checked)
                SearchRoleUser();
            if(radioButtonLogin.Checked)
                SearchLogin();
        }

        // Фильтр: Сотрудник
        private void SearchEmployee()
        {
            DataView view = UserTable.DefaultView;

            view.RowFilter = string.Format("Employee like '%{0}%' ", textBoxSearch.Text);

            dataGridViewUsers.DataSource = view.ToTable();
        }

        // Фильтр: Роль сотрудника
        private void SearchRoleUser()
        {
            DataView view = UserTable.DefaultView;

            view.RowFilter = string.Format("RoleUser like '%{0}%' ", textBoxSearch.Text);

            dataGridViewUsers.DataSource = view.ToTable();
        }

        // Фильтр: Логин
        private void SearchLogin()
        {
            DataView view = UserTable.DefaultView;

            view.RowFilter = string.Format("Login like '%{0}%' ", textBoxSearch.Text);

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
            Program.DataEditUserId.Value  = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[0].Value);
            Program.DataEditUserLogin.Value = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[1].Value);
            Program.DataEditUserPassword.Value = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[2].Value);
            Program.DataEditUserRole.Value = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[3].Value);
            Program.DataEditUserEmployee.Value = Convert.ToString(dataGridViewUsers.CurrentRow.Cells[4].Value);

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

                Program.DataEditUserId.Value = view.Cells[0].Value.ToString();
                Program.DataEditUserLogin.Value = view.Cells[1].Value.ToString();
                Program.DataEditUserPassword.Value = view.Cells[2].Value.ToString();
                Program.DataEditUserRole.Value = view.Cells[3].Value.ToString();
                Program.DataEditUserEmployee.Value = view.Cells[4].Value.ToString();                

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
