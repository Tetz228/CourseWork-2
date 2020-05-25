using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class History_projectsFormAdd : MaterialForm
    {
        public History_projectsFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void History_projectsFormAdd_Load(object sender, EventArgs e)
        {
            SelectProjectComboBox();

            SelectStatusComboBox();
        }

        // Валидация TextBox`ов и добавление в бд
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

        // Заполнение ComboBox`а "Статус"
        private void SelectStatusComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_status_project AS Id," +
                "status_name_project AS Status " +
                "FROM Status_projects", connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_status_project.ValueMember = "Id";
            ComboBox_fk_status_project.DisplayMember = "Status";

            DataRow row = HistoryTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Статус";
            HistoryTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_status_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Проект"
        private void SelectProjectComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_project AS Id," +
                "project_name AS Project " +
                "FROM Projects", connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_project.ValueMember = "Id";
            ComboBox_fk_project.DisplayMember = "Project";

            DataRow row = HistoryTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Проект";
            HistoryTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Функция добавления строки
        private void AddRowHistoryProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddHistoryProjects", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();        

            if(string.IsNullOrWhiteSpace(textBox_History_date_project.Text))
                command.Parameters.AddWithValue("@history_date_project", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@history_date_project", SqlDbType.Date).Value = DateTime.Parse(textBox_History_date_project.Text);              

            command.Parameters.AddWithValue("@fk_project", SqlDbType.Int).Value = ComboBox_fk_project.SelectedValue;
            command.Parameters.AddWithValue("@fk_status_project", SqlDbType.Int).Value = ComboBox_fk_status_project.SelectedValue;
            
            SqlParameter parameter = command.Parameters.AddWithValue("@id_history_project", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

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

        // Валидация TextBox`ов
        private bool CheckTextBox()
        {
            int check = 0;

            if (ComboBox_fk_project.Text == "Проект")
            {
                labelValidProject.Show();

                check = 1;
            }
            if (ComboBox_fk_status_project.Text == "Статус")
            {
                labelValidStatus.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }

        // Проверка даты на нулевое значение и на корректность
        private void CheckDateNullAndCorrect()
        {
            bool date = DateTime.TryParse(textBox_History_date_project.Text, out DateTime dateHistory_date);
            
            if (!string.IsNullOrWhiteSpace(textBox_History_date_project.Text))
            {
                if (!date)
                {
                    labelValidDate.Show();

                    return;
                }
                else
                {
                    AddRowHistoryProject();

                    this.Close();
                }
            }
            else
            {
                AddRowHistoryProject();

                this.Close();
            }
        }

        // При выборе из ComboBox`а "Статус" скрывать label
        private void ComboBox_fk_status_project_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidStatus.Hide();
        }

        // При выборе из ComboBox`а "Проект" скрывать label
        private void ComboBox_fk_project_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidProject.Hide();
        }

        // Скрывать Label при вводе в TextBox
        private void textBox_History_date_project_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidDate.Hide();
        }
    }
}
