using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CourseWork
{
    public partial class EmployeesFormAdd : MaterialForm
    {
        public EmployeesFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
                if (!ValidationEmail(textBoxEmail.Text))
                {
                    labelEmail.Text = "Некорректная почта.";
                    labelEmail.Show();
                    return;
                } 
            else
                if (!MailOriginality(textBoxEmail.Text))
                {
                    labelEmail.Text = "Пользователь с такой почтой уже существует.";
                    labelEmail.Show();
                    return;
                }
            else
                AddRowEmployee();

            this.Close();
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Функция добавления строки
        private void AddRowEmployee()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddEmployees", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@employee_lname", SqlDbType.NVarChar).Value = textBoxLname.Text.Trim();
            command.Parameters.AddWithValue("@employee_fname", SqlDbType.NVarChar).Value = textBoxFname.Text.Trim();
            command.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = textBoxEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(textBoxMname.Text))
                command.Parameters.AddWithValue("@employee_mname", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@employee_mname", SqlDbType.NVarChar).Value = textBoxMname.Text.Trim();

            SqlParameter parameter = command.Parameters.AddWithValue("@id_employee", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Валидация TextBox`а
        private bool CheckTextBox()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(textBoxLname.Text))
            {
                labelLname.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(textBoxFname.Text))
            {
                labelFname.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                labelEmail.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }

        // Валидация почты
        public bool ValidationEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        // Проверка на уникальность почты
        private bool MailOriginality(string email)
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT Email FROM Employees WHERE Email = @email", connection.GetSqlConnect());
            selectLog.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;

            adapter.SelectCommand = selectLog;
            adapter.Fill(table);

            connection.CloseConnect();

            if (table.Rows.Count > 0)
            {
                labelEmail.Text = "Пользователь с такой почтой\nуже существует!";
                labelEmail.Show();

                return false;
            }
            else
                return true;
        }

        private void textBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelLname.Hide();
        }

        private void textBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelFname.Hide();
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelEmail.Hide();
        }
    }
}
