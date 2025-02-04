﻿using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

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

        // При загрузки формы 
        private void ProjectsFormEdit_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();

            textBoxProject_name.Text = Values.ProjectName;
            textBoxProject_target.Text = Values.ProjectTarget;
            textBoxDate_start.Text = Values.ProjectStart;
            textBoxDate_completion.Text = Values.ProjectCompletion;

            int indexEmp = comboBox_fk_leader.FindString(Values.ProjectLeader);

            comboBox_fk_leader.SelectedIndex = indexEmp;

            if (!string.IsNullOrEmpty(textBoxDate_start.Text))
                textBoxDate_start.Text = textBoxDate_start.Text.Substring(0, 10);

            if (!string.IsNullOrEmpty(textBoxDate_completion.Text))
                textBoxDate_completion.Text = textBoxDate_completion.Text.Substring(0, 10);
        }

        // Вызов проверки и сохранение изменений
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
                CheckDateNullAndCorrect();
        }

        // При нажатии закрывать форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Заполнение ComboBox`а "Проект"
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

            comboBox_fk_leader.DataSource = ProjectTableComboBox;

            connection.CloseConnect();
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
                command.Parameters.AddWithValue("@date_start", SqlDbType.Date).Value = DateTime.Parse(textBoxDate_start.Text);

            if (string.IsNullOrEmpty(textBoxDate_completion.Text))
                command.Parameters.AddWithValue("@date_completion", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@date_completion", SqlDbType.Date).Value = DateTime.Parse(textBoxDate_completion.Text);
            
            command.Parameters.AddWithValue("@project_name", SqlDbType.NVarChar).Value = textBoxProject_name.Text.Trim();
            command.Parameters.AddWithValue("@fk_leader", SqlDbType.Int).Value = comboBox_fk_leader.SelectedValue;
            command.Parameters.AddWithValue("@id_project", Values.ProjectId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.CloseConnect();
            }
        }

        // Проверка даты на нулевое значение и на корректность даты
        private void CheckDateNullAndCorrect()
        {
            bool start = DateTime.TryParse(textBoxDate_start.Text, out DateTime dateTimeStart);
            bool completion = DateTime.TryParse(textBoxDate_completion.Text, out DateTime dateTimeCompletion);

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
                    EditRowProject();

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
                        EditRowProject();

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
                        EditRowProject();

                        this.Close();

                        return;
                    }
                }

                EditRowProject();

                this.Close();
            }
        }

        // Проверка на пустоту поля
        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxProject_name.Text))
            {
                labelValidProject.Show();

                return false;
            }
           
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
    }
}
