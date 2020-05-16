using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;

namespace CourseWork.Users
{
    public partial class UsersFormAdd : MaterialForm
    {
        public UsersFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
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

            DataRow row = EmployeeTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Сотрудник";
            EmployeeTableComboBox.Rows.InsertAt(row, 0);

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

            DataRow row = RoleTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Роль сотрудника";
            RoleTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_role_user.DataSource = RoleTableComboBox;

            connection.CloseConnect();
        }

        // Проверки на пустоту полей
        private bool CheckTextBox()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(textBoxProject_name.Text))
            {
                labelValidProject.Show();

                check = 1;
            }
            if (ComboBox_fk_employee.Text == "Сотрудник")
            {
                labelValidRole.Show();

                check = 1;
            }
            if (ComboBox_fk_role_user.Text == "Роль сотрудника")
            {
                labelValidEmployee.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }
    }
}
