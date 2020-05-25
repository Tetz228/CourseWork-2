using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

namespace CourseWork
{
    public partial class EmployeesFormEdit : MaterialForm
    {
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
            textBoxLname.Text = Values.EmployeeLname;
            textBoxFname.Text = Values.EmployeeFname;
            textBoxMname.Text = Values.EmployeeMname;
            textBoxEmail.Text = Values.EmployeeEmail;
        }

        // Вызов всех проверок и изменение строки
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            if (!CheckTextBox())
                return;
            else
            if (!functions.ValidationEmail(textBoxEmail.Text.Trim()))
            {
                labelEmail.Text = "Некорректная почта.";
                labelEmail.Show();
                return;
            }
            else
            if (textBoxEmail.Text != Values.EmployeeEmail)
            {
                if (!functions.MailOriginality(textBoxEmail.Text.Trim()))
                    return;
                else
                {
                    EditRowEmployees();

                    this.Close();
                }
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

            command.Parameters.AddWithValue("@id_employee", Values.EmployeeId);

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
