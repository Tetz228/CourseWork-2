using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ProjectsFormAdd : MaterialForm
    {
        DateTime dateTimeStart;
        DateTime dateTimeCompletion;

        public ProjectsFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void ProjectsFormAdd_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();
        }

        // Заполнение ComboBox`а "Сотрудник"
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, " +
                "CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee " +
                "FROM Employees", connection.GetSqlConnect());
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

        // Вызов провероки TextBox`ов и добавление в бд
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
                CheckDateNullAndCorrect();
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Проверка даты на нулевое значение и на корректность
        private void CheckDateNullAndCorrect()
        {
            bool start = DateTime.TryParse(textBoxDate_start.Text, out dateTimeStart);
            bool completion = DateTime.TryParse(textBoxDate_completion.Text, out dateTimeCompletion);

            if (!string.IsNullOrWhiteSpace(textBoxDate_start.Text) && !string.IsNullOrWhiteSpace(textBoxDate_completion.Text))
            {
                if (!(start && completion))
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
                    if (!start)
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
                    if (!completion)
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
            
            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            if (string.IsNullOrWhiteSpace(textBoxProject_target.Text))
                command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = textBoxProject_target.Text.Trim();

            if (string.IsNullOrWhiteSpace(textBoxDate_start.Text))
                command.Parameters.AddWithValue("@date_start", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@date_start", SqlDbType.Date).Value = dateTimeStart = DateTime.Parse(textBoxDate_start.Text);

            if (string.IsNullOrWhiteSpace(textBoxDate_completion.Text))
                command.Parameters.AddWithValue("@date_completion", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@date_completion", SqlDbType.Date).Value = dateTimeCompletion = DateTime.Parse(textBoxDate_completion.Text);

            command.Parameters.AddWithValue("@project_name", SqlDbType.NVarChar).Value = textBoxProject_name.Text.Trim();
            command.Parameters.AddWithValue("@fk_leader", SqlDbType.Int).Value = comboBox_fk_leader.SelectedValue;

            SqlParameter parameter = command.Parameters.AddWithValue("@id_project", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Дата должна быть в диапозоне 01.01.1753 - 31.12.9999.");
            }
            finally
            {
                connection.CloseConnect();
            }
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

        // Скрывать Label`ы при вводе в TextBox`ы
        private void textBoxProject_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidProject.Hide();
        }

        private void textBoxDate_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidStart.Hide();
        }

        private void textBoxDate_completion_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidCompletion.Hide();
        }

        private void comboBox_fk_leader_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidLeader.Hide();
        }
    }
}
