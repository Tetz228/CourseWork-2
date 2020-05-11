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

        // При загрузки формы передавать в TextBox`ы текст, полученный с классов
        private void ProjectsFormEdit_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();

            textBoxProject_name.Text = Program.DataEditProjectName.Value;
            textBoxProject_target.Text = Program.DataEditProjectTarget.Value;
            textBoxDate_start.Text = Program.DataEditProjectStart.Value;
            textBoxDate_completion.Text = Program.DataEditProjectCompletion.Value;
            comboBox_fk_leader.SelectedValue = Convert.ToInt32(Program.DataEditProjectLeader.Value);
        }

        // При закрытии формы передать определенный текст в класс
        private void ProjectsFormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.DataValidEditProject.Value == "true")
                return;
            else
                Program.DataValidEditProject.Value = "false";
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
            {
                Program.DataEditProjectName.Value = textBoxProject_name.Text.Trim();
                Program.DataEditProjectTarget.Value = textBoxProject_target.Text.Trim();
                Program.DataEditProjectStart.Value = textBoxDate_start.Text.Trim();
                Program.DataEditProjectCompletion.Value = textBoxDate_completion.Text.Trim();
                Program.DataEditProjectLeader.Value = comboBox_fk_leader.SelectedValue.ToString();

                this.Close();
            }
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
            
            if (check == 1)
                return false;
            else
            {
                Program.DataValidEditProject.Value = "true";

                return true;
            }
        }

        // При нажатии передать определенный текст в класс
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.DataValidEditProject.Value = "false";

            this.Close();
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
