using System;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

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

        // При загрузки формы заполнять ComboBox
        private void ProjectsFormAdd_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();
        }

        // При закрытии формы передать определенный текст в класс
        private void ProjectsFormAdd_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (Program.DataValidAddProject.Value == "true")
                return;
            else
                Program.DataValidAddProject.Value = "false";
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

        // При нажатии валидация и передача текста в класс
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                Program.DataAddProjectName.Value = textBoxProject_name.Text.Trim();
                Program.DataAddProjectTarget.Value = textBoxProject_target.Text.Trim();
                Program.DataAddProjectStart.Value = textBoxDate_start.Text.Trim();
                Program.DataAddProjectCompletion.Value = textBoxDate_completion.Text.Trim();
                Program.DataAddProjectLeader.Value = comboBox_fk_leader.SelectedValue.ToString();

                this.Close();
            }
        }

        // При нажатии передать определенный текст в класс
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.DataValidAddProject.Value = "false";

            this.Close();
        }

        // Валидация TextBox`а
        private bool CheckTextBox()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(textBoxProject_name.Text))
            {
                labelValidProject.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(textBoxProject_target.Text))
            {
                labelValidTarget.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(textBoxDate_start.Text))
            {
                labelValidStart.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(textBoxDate_completion.Text))
            {
                labelValidCompletion.Show();

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
            {
                Program.DataValidAddProject.Value = "true";

                return true;
            }
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

        // При вводе в TextBox скрывать label
        private void textBoxDate_start_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            labelValidStart.Hide();
        }

        // При вводе в TextBox скрывать label
        private void textBoxDate_completion_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            labelValidCompletion.Hide();
        }

        // При выборе в ComboBox`е скрывать label
        private void comboBox_fk_leader_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidLeader.Hide();
        }
    }
}
