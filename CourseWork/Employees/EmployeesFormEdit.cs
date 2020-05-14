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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EmployeesFormEdit : MaterialForm
    {
        string checkEmail;

        public EmployeesFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void EmployeesFormEdit_Load(object sender, EventArgs e)
        {
            textBoxLname.Text = Program.DataEditEmployeeLname.Value;
            textBoxFname.Text = Program.DataEditEmployeeFname.Value;
            textBoxMname.Text = Program.DataEditEmployeeMname.Value;
            textBoxEmail.Text = Program.DataEditEmployeeEmail.Value;

            checkEmail = textBoxEmail.Text;
        }

        // Вызов всех проверок и изменение строки
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
            if (!CheckEmailChange(textBoxEmail.Text))
            {
                return;
            }
            else
            {
                EditRowEmployees();

                this.Close();
            }
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Функция редактирования строки
        private void EditRowEmployees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditEmployees", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@employee_lname", SqlDbType.NVarChar).Value = textBoxLname.Text.Trim();
            command.Parameters.AddWithValue("@employee_fname", SqlDbType.NVarChar).Value = textBoxFname.Text.Trim();
            command.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = textBoxEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(textBoxMname.Text))
                command.Parameters.AddWithValue("@employee_mname", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@employee_mname", SqlDbType.NVarChar).Value = textBoxMname.Text.Trim();

            command.Parameters.AddWithValue("@id_employee", Convert.ToInt32(Program.DataEditEmployeeId.Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Проверки на пустоту полей
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

        public bool CheckEmailChange(string email)
        {
            if (email != checkEmail)
            {
                if (!MailOriginality(email))
                    return false;
                else
                    return true;
            }
            else
                return true;
        }

        // Валидация фамилии, имени, отчества
        public bool ValidationLFMname(string LFMname)
        {
            string pattern = @"[A-Za-zА-Яа-я]{1,30}";

            Match isMatch = Regex.Match(LFMname, pattern);

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

        // Скрывать Label`ы при вводе в TextBox`ы
        private void TextBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelLname.Hide();
        }

        private void TextBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelFname.Hide();
        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelEmail.Hide();
        }
    }
}
