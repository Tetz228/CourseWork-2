using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

namespace CourseWork
{
    public partial class History_projectsFormEdit : MaterialForm
    {
        DateTime dateHistory_date;

        public History_projectsFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void History_projectsFormEdit_Load(object sender, EventArgs e)
        {
            SelectHistoryProjectComboBox();

            SelectStatusComboBox();
         
            textBox_History_date_project.Text = Values.HistoryProjectDate;

            int indexProj = ComboBox_fk_project.FindString(Values.HistoryProjectName);
            int indexStat = ComboBox_fk_status_project.FindString(Values.HistoryProjectStatus);

            ComboBox_fk_project.SelectedIndex = indexProj;
            ComboBox_fk_status_project.SelectedIndex = indexStat;

            if (!string.IsNullOrEmpty(textBox_History_date_project.Text))
                textBox_History_date_project.Text = textBox_History_date_project.Text.Substring(0, 10);
        }

        // Вызов проверки даты
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CheckDateNullAndCorrect();
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Заполнение ComboBox`а "Проект"
        private void SelectHistoryProjectComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_project AS Id, " +
                "project_name AS Project " +
                "FROM Projects", connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_project.ValueMember = "Id";
            ComboBox_fk_project.DisplayMember = "Project";

            ComboBox_fk_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Статус"
        private void SelectStatusComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_status_project AS Id, " +
                "status_name_project AS Status " +
                "FROM Status_projects", connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_status_project.ValueMember = "Id";
            ComboBox_fk_status_project.DisplayMember = "Status";
         
            ComboBox_fk_status_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Функция редактирования строки
        private void EditRowHistoryProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditHistoryProjects", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            if (string.IsNullOrWhiteSpace(textBox_History_date_project.Text))
                command.Parameters.AddWithValue("@history_date_project", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@history_date_project", SqlDbType.Date).Value = dateHistory_date = DateTime.Parse(textBox_History_date_project.Text);

            command.Parameters.AddWithValue("@fk_project", SqlDbType.Int).Value = ComboBox_fk_project.SelectedValue;
            command.Parameters.AddWithValue("@fk_status_project", SqlDbType.Int).Value = ComboBox_fk_status_project.SelectedValue;

            command.Parameters.AddWithValue("@id_history_project", Values.HistoryProjectId);

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

        // Проверка даты на нулевое значение и на корректность
        private void CheckDateNullAndCorrect()
        {
            bool date = DateTime.TryParse(textBox_History_date_project.Text, out dateHistory_date);

            if (!string.IsNullOrWhiteSpace(textBox_History_date_project.Text))
            {
                if (!date)
                {
                    labelValidDate.Show();

                    return;
                }
                else
                {
                    EditRowHistoryProject();

                    this.Close();
                }
            }
            else
            {
                EditRowHistoryProject();

                this.Close();
            }
        }

        // Скрывать Label при вводе в TextBox
        private void textBox_History_date_project_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidDate.Hide();
        }
    }
}
