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

            SelectEmployeeComboBox();

            SelectRoleComboBox();

            SelectDateUsers();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateUsers()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Users", connection.GetSqlConnect());
            DataTable ProjectTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTable);

            dataGridViewUsers.DataSource = ProjectTable.DefaultView;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Сотрудник"
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());
            DataTable EmployeeTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(EmployeeTableComboBox);

            ComboBox_fk_employee.ValueMember = "Id";
            ComboBox_fk_employee.DisplayMember = "Employee";
            ComboBox_fk_employee.DataSource = EmployeeTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Роль сотрудника"
        private void SelectRoleComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_user_role AS Id, user_name_role AS Role FROM Users_roles", connection.GetSqlConnect());
            DataTable RoleTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(RoleTableComboBox);

            ComboBox_fk_role_user.ValueMember = "Id";
            ComboBox_fk_role_user.DisplayMember = "Role";
            ComboBox_fk_role_user.DataSource = RoleTableComboBox;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowUser()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteUsers", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_user", Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells["Column_id_user"].Value));

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
            Program.DataEditUserId.Value  = Convert.ToString(dataGridViewUsers.CurrentRow.Cells["Column_id_user"].Value);
            Program.DataEditUserLogin.Value = Convert.ToString(dataGridViewUsers.CurrentRow.Cells["Column_login"].Value);
            Program.DataEditUserPassword.Value = Convert.ToString(dataGridViewUsers.CurrentRow.Cells["Column_password"].Value);
            Program.DataEditUserRole.Value = Convert.ToString(dataGridViewUsers.CurrentRow.Cells["ComboBox_fk_role_user"].Value);
            Program.DataEditUserEmployee.Value = Convert.ToString(dataGridViewUsers.CurrentRow.Cells["ComboBox_fk_employee"].Value);
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
    }
}
