using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace CourseWork.History_task
{
    public partial class History_taskFormAdd : MaterialForm
    {
        DateTime dateHistory_date;

        public History_taskFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);  
        }

        // При загрузки формы
        private void History_taskFormAdd_Load(object sender, EventArgs e)
        {
            SelectTaskComboBox();

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
            SqlDataAdapter sqlDA = new SqlDataAdapter(
                "SELECT id_status_task AS Id, " +
                "status_name_task AS Status " +
                "FROM Status_task",
                connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_status_task.ValueMember = "Id";
            ComboBox_fk_status_task.DisplayMember = "Status";

            DataRow row = HistoryTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Статус";
            HistoryTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_status_task.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Задача"
        private void SelectTaskComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectHistory_taskComboBox", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_project_task.ValueMember = "Id";
            ComboBox_fk_project_task.DisplayMember = "Task";

            DataRow row = HistoryTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Задача";
            HistoryTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_project_task.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Функция добавления строки
        private void AddRowHistoryTask()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddHistoryTask", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            if (string.IsNullOrWhiteSpace(textBox_History_date_task.Text))
                command.Parameters.AddWithValue("@history_date_task", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@history_date_task", SqlDbType.Date).Value = dateHistory_date = DateTime.Parse(textBox_History_date_task.Text);

            command.Parameters.AddWithValue("@fk_project_task", SqlDbType.Int).Value = ComboBox_fk_project_task.SelectedValue;
            command.Parameters.AddWithValue("@fk_status_task", SqlDbType.Int).Value = ComboBox_fk_status_task.SelectedValue;

            SqlParameter parameter = command.Parameters.AddWithValue("@id_history_task", SqlDbType.Int);

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

            if (ComboBox_fk_project_task.Text == "Задача")
            {
                labelValidProject.Show();

                check = 1;
            }
            if (ComboBox_fk_status_task.Text == "Статус")
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
            bool date = DateTime.TryParse(textBox_History_date_task.Text, out dateHistory_date);

            if (!string.IsNullOrWhiteSpace(textBox_History_date_task.Text))
            {
                if (!date)
                {
                    labelValidDate.Show();

                    return;
                }
                else
                {
                    AddRowHistoryTask();

                    this.Close();
                }
            }
            else
            {
                AddRowHistoryTask();

                this.Close();
            }
        }

        // При выборе из ComboBox`а "Статус" скрывать label
        private void ComboBox_fk_status_task_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidStatus.Hide();
        }

        // При выборе из ComboBox`а "Задача" скрывать label
        private void ComboBox_fk_project_task_SelectedValueChanged(object sender, EventArgs e)
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
