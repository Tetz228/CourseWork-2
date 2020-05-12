using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Text.RegularExpressions;

namespace CourseWork
{
    public partial class ProjectsFormAdd : MaterialForm
    {
        public ProjectsFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы вызов функции заполнения ComboBox`а
        private void ProjectsFormAdd_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();
        }

        // Заполнение ComboBox`а
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());
            DataTable ProjectTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTableComboBox);

            comboBox_fk_leader.ValueMember = "Id";
            comboBox_fk_leader.DisplayMember = "Employee";

            DataRow row = ProjectTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Руководитель";
            ProjectTableComboBox.Rows.InsertAt(row, 0);

            comboBox_fk_leader.DataSource = ProjectTableComboBox;

            connection.CloseConnect();
        }

        // При нажатии валидация, если валидация прошла успешно, то добавление в бд
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
                CheckDateNull();
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Проверка даты на нулевое значение
        private void CheckDateNull()
        {
            if (!string.IsNullOrWhiteSpace(textBoxDate_start.Text) && !string.IsNullOrWhiteSpace(textBoxDate_completion.Text))
            {
                if (!(ValidationDate(textBoxDate_start.Text) && ValidationDate(textBoxDate_completion.Text)))
                {
                    labelValidStart.Show();
                    labelValidCompletion.Show();

                    return;
                }
                else
                {
                    AddRowProject();

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
                        AddRowProject();

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
                        AddRowProject();

                        this.Close();

                        return;
                    }

                }

                AddRowProject();

                this.Close();
            }
        }

        // Функция добавления строки
        private void AddRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddProjects", connection.GetSqlConnect());
            DateTime dateTimeStart;
            DateTime dateTimeCompletion;
            
            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            if (string.IsNullOrWhiteSpace(textBoxProject_target.Text))
                command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = textBoxProject_target.Text.Trim();

            if (string.IsNullOrEmpty(textBoxDate_start.Text))
                command.Parameters.AddWithValue("@date_start", SqlDbType.Date).Value = DBNull.Value;
            else
            {
                dateTimeStart = DateTime.Parse(textBoxDate_start.Text);
                command.Parameters.AddWithValue("@date_start", SqlDbType.Date).Value = dateTimeStart;
            }

            if (string.IsNullOrEmpty(textBoxDate_completion.Text))
                command.Parameters.AddWithValue("@date_completion", SqlDbType.Date).Value = DBNull.Value;
            else
            {
                dateTimeCompletion = DateTime.Parse(textBoxDate_completion.Text);
                command.Parameters.AddWithValue("@date_completion", SqlDbType.Date).Value = dateTimeCompletion;
            }
                

            command.Parameters.AddWithValue("@project_name", SqlDbType.NVarChar).Value = textBoxProject_name.Text.Trim();
            command.Parameters.AddWithValue("@fk_leader", SqlDbType.Int).Value = comboBox_fk_leader.SelectedValue;

            SqlParameter parameter = command.Parameters.AddWithValue("@id_project", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Валидация TextBox`ов
        private bool CheckTextBox()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(textBoxProject_name.Text))
            {
                labelValidProject.Show();

                check = 1;
            }
            if (comboBox_fk_leader.Text == "Руководитель")
            {
                labelValidLeader.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }

        // Валидация даты
        private bool ValidationDate(string check)
        {
            string pattern = @"[0-9]{2}[-./][0-9]{2}[-./][0-9]{4}";

            Match isMatch = Regex.Match(check, pattern);
            return isMatch.Success;
        }

        // При вводе в TextBox скрывать label
        private void textBoxProject_name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            labelValidProject.Hide();
        }

        // При вводе в TextBox скрывать label
        private void textBoxProject_target_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            labelValidTarget.Hide();
        }

        // Ввод только определенных символов и при вводе в TextBox скрывать label
        private void textBoxDate_start_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            labelValidStart.Hide();
        }

        // Ввод только определенных символов и при вводе в TextBox скрывать label
        private void textBoxDate_completion_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // цифры, слеш(/), точка, минус, BACKSPACE
            if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 47 || e.KeyChar == 46 || e.KeyChar == 45 || e.KeyChar == 8))
                e.Handled = true;

            labelValidCompletion.Hide();
        }
    
        // При выборе в ComboBox`е скрывать label
        private void comboBox_fk_leader_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidLeader.Hide();
        }
    }
}
