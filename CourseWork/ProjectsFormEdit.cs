using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CourseWork
{
    public partial class ProjectsFormEdit : MaterialForm
    {
        public ProjectsFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы передавать в TextBox`ы текст, полученный с классов, и обрезать строки, если не пустые
        private void ProjectsFormEdit_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();

            textBoxProject_name.Text = Program.DataEditProjectName.Value;
            textBoxProject_target.Text = Program.DataEditProjectTarget.Value;
            textBoxDate_start.Text = Program.DataEditProjectStart.Value;
            textBoxDate_completion.Text = Program.DataEditProjectCompletion.Value;
            comboBox_fk_leader.SelectedValue = Convert.ToInt32(Program.DataEditProjectLeader.Value);

            if(!string.IsNullOrEmpty(textBoxDate_start.Text))
                textBoxDate_start.Text = textBoxDate_start.Text.Substring(0, 10);

            if (!string.IsNullOrEmpty(textBoxDate_completion.Text))
                textBoxDate_completion.Text = textBoxDate_completion.Text.Substring(0, 10);
        }

        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());
            DataTable ProjectTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTableComboBox);

            comboBox_fk_leader.ValueMember = "Id";
            comboBox_fk_leader.DisplayMember = "Employee";

            comboBox_fk_leader.DataSource = ProjectTableComboBox;

            connection.CloseConnect();
        }

        // При нажатии валидация и передача текста в класс
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
                CheckDateNull();
        }

        // При нажатии передать определенный текст в класс
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Функция редактирования строки
        private void EditRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditProject", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            if (string.IsNullOrWhiteSpace(textBoxProject_target.Text))
                command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = textBoxProject_target.Text.Trim();

            if(string.IsNullOrEmpty(textBoxDate_start.Text))
                command.Parameters.AddWithValue("@date_start", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@date_start", SqlDbType.Date).Value = textBoxDate_start.Text;

            if (string.IsNullOrEmpty(textBoxDate_completion.Text))
                command.Parameters.AddWithValue("@date_completion", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@date_completion", SqlDbType.Date).Value = textBoxDate_completion.Text;

            command.Parameters.AddWithValue("@project_name", SqlDbType.NVarChar).Value = textBoxProject_name.Text.Trim();
            command.Parameters.AddWithValue("@fk_leader", SqlDbType.Int).Value = comboBox_fk_leader.SelectedValue;
            command.Parameters.AddWithValue("@id_project", Convert.ToInt32(Program.DataEditProjectId.Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Проверка даты на нулевое значение
        private void CheckDateNull()
        {
            if (!string.IsNullOrWhiteSpace(textBoxDate_start.Text) && !string.IsNullOrWhiteSpace(textBoxDate_completion.Text))
            {
                if (!ValidationDate(textBoxDate_start.Text) && !ValidationDate(textBoxDate_completion.Text))
                {
                    labelValidStart.Show();
                    labelValidCompletion.Show();

                    return;
                }
                else
                {
                    EditRowProject();

                    this.Close();
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textBoxDate_start.Text))
                {
                    if (!ValidationDate(textBoxDate_start.Text))
                    {
                        labelValidStart.Show();

                        return;
                    }
                    else
                    {
                        EditRowProject();

                        this.Close();

                        return;
                    }

                }
                if (!string.IsNullOrWhiteSpace(textBoxDate_completion.Text))
                {
                    if (!ValidationDate(textBoxDate_completion.Text))
                    {
                        labelValidCompletion.Show();

                        return;
                    }
                    else
                    {
                        EditRowProject();

                        this.Close();

                        return;
                    }

                }

                EditRowProject();

                this.Close();
            }
        }

        // Валидация даты
        private bool ValidationDate(string check)
        {
            string pattern = @"[0-9]{2}[-./][0-9]{2}[-./][0-9]{4}";

            Match isMatch = Regex.Match(check, pattern);
            return isMatch.Success;
        }

        // Валидация TextBox`а
        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxProject_name.Text))
            {
                labelValidProject.Show();

                return false;
            }
           
           return true;
        }

        // При вводе в TextBox скрывать label
        private void textBoxProject_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidProject.Hide();
        }

        // При вводе в TextBox скрывать label
        private void textBoxProject_target_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidTarget.Hide();
        }

        // При вводе в TextBox скрывать label
        private void textBoxDate_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidStart.Hide();
        }

        // При вводе в TextBox скрывать label
        private void textBoxDate_completion_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidCompletion.Hide();
        }
    }
}
