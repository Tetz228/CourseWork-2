using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;
using System.Text;
using CourseWork.Main;

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

        // При загрузки формы
        private void UsersFormAdd_Load(object sender, EventArgs e)
        {       
            SelectEmployeeComboBox();

            SelectRoleComboBox();
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

        // При нажатии вызов всех проверок и добавление в бд
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            if (!CheckTextBoxsAndComboBoxs())
                return;
            else
            if (!CheckLogAndPassLength())
                return;
            else
            if (!functions.ValidationLogin(TextBoxLog.Text.Trim()))
            {
                labelValidLog.Text = "Некорректный логин.";
                labelValidLog.Show();

                return;
            }
            else
            if (!functions.LoginOriginality(TextBoxLog.Text.Trim()))
            {
                labelValidLog.Text = "Пользователь с таким логином\nуже существует!";
                labelValidLog.Show();
                return;
            }
            else
            if (!functions.ValidationPassword(TextBoxPass.Text.Trim()))
            {
                labelValidPass.Text = "Некорректный пароль. Первым\nсимволом не может быть цифра.\nПароль должен быть минимум с\nодной цифрой, одной заглавной\nи одной строчной буквой.";
                labelValidPass.Show();

                return;
            }
            else
            {
                AddRowUser();

                this.Close();
            }
        }

        // Функция добавления
        public void AddRowUser()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddUsers", connection.GetSqlConnect());
            Functions functions = new Functions();

            command.CommandType = CommandType.StoredProcedure;

            byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxPass.Text.Trim());

            connection.OpenConnect();

            command.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = TextBoxLog.Text.Trim();
            command.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = functions.HashPassword(passtohash);
            command.Parameters.AddWithValue("@fk_role", SqlDbType.Int).Value = ComboBox_fk_role_user.SelectedValue;
            command.Parameters.AddWithValue("@fk_employee", SqlDbType.Int).Value = ComboBox_fk_employee.SelectedValue;

            SqlParameter parameter = command.Parameters.AddWithValue("@id_user", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // При нажатии закрытие формы
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Проверки TextBox`ов и ComboBox`ов
        private bool CheckTextBoxsAndComboBoxs()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(TextBoxLog.Text))
            {
                labelValidLog.Text = "Введите логин";
                labelValidLog.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxPass.Text))
            {
                labelValidPass.Text = "Введите пароль";
                labelValidPass.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxPassRepeat.Text))
            {
                labelValidPassRepeat.Text = "Введите ещё раз пароль";
                labelValidPassRepeat.Show();

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

        // Скрывать / показывать пароль
        private void pictureBoxShowHidePassword_Click(object sender, EventArgs e)
        {
            if (TextBoxPass.UseSystemPasswordChar == true)
            {
                TextBoxPass.UseSystemPasswordChar = false;
                TextBoxPassRepeat.UseSystemPasswordChar = false;

                pictureBoxShowHidePassword.Image = Properties.Resources.ShowPassword;
            }
            else
            {
                TextBoxPass.UseSystemPasswordChar = true;
                TextBoxPassRepeat.UseSystemPasswordChar = true;

                pictureBoxShowHidePassword.Image = Properties.Resources.HidePassword;
            }
        }

        // Проверка логина и пароля на нужную длинну
        private bool CheckLogAndPassLength()
        {
            if (TextBoxLog.Text.Length < 4 && TextBoxPass.Text.Length < 6)
            {
                labelValidLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidLog.Show();

                labelValidPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidPass.Show();

                return false;
            }
            else

            if (TextBoxLog.Text.Length < 4)
            {
                labelValidLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidLog.Show();

                return false;
            }
            else

            if (TextBoxPass.Text.Length < 6)
            {
                labelValidPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidPass.Show();

                return false;
            }
            else

            if (TextBoxPass.Text != TextBoxPassRepeat.Text)
            {
                labelValidPassRepeat.Text = "Пароли должны совпадать";
                labelValidPassRepeat.Show();

                return false;
            }

            return true;
        }

        // Скрывать Label`ы при вводе в TextBox`ы или выборе в ComboBox`сах
        private void TextBoxLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidLog.Hide();
        }

        private void TextBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidPass.Hide();
        }

        private void TextBoxPassRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidPassRepeat.Hide();
        }

        private void ComboBox_fk_role_user_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidRole.Hide();
        }

        private void ComboBox_fk_employee_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidEmployee.Hide();
        }
    }
}
