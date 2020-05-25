using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

namespace CourseWork.MyTask
{
    public partial class MyTaskFormEdit : MaterialForm
    {
        public MyTaskFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MyTaskFormEdit_Load(object sender, EventArgs e)
        {
            SelectStatusComboBox();

            textBox_History_date_task.Text = Values.MyTaskDate;

            int indexStat = ComboBox_fk_status_task.FindString(Values.MyTaskStatus);

            ComboBox_fk_status_task.SelectedIndex = indexStat;

            if (!string.IsNullOrEmpty(textBox_History_date_task.Text))
                textBox_History_date_task.Text = textBox_History_date_task.Text.Substring(0, 10);
        }

        // Вызов проверки даты и сохранение изменений
        private void buttonEdit_Click(object sender, EventArgs e)
        {
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
            ComboBox_fk_status_task.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        // Функция редактирования строки
        private void EditRowMyTask()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditMyTask", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            if (string.IsNullOrWhiteSpace(textBox_History_date_task.Text))
                command.Parameters.AddWithValue("@history_date_task", SqlDbType.Date).Value = DBNull.Value;
            else
                command.Parameters.AddWithValue("@history_date_task", SqlDbType.Date).Value = DateTime.Parse(textBox_History_date_task.Text);

            command.Parameters.AddWithValue("@fk_status_task", SqlDbType.Int).Value = ComboBox_fk_status_task.SelectedValue;

            command.Parameters.AddWithValue("@id_history_task", Values.MyTaskId);

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
            bool date = DateTime.TryParse(textBox_History_date_task.Text, out DateTime dateHistory_date);

            if (!string.IsNullOrWhiteSpace(textBox_History_date_task.Text))
            {
                if (!date)
                {
                    labelValidDate.Show();

                    return;
                }
                else
                {
                    EditRowMyTask();

                    this.Close();
                }
            }
            else
            {
                EditRowMyTask();

                this.Close();
            }
        }

        // При выборе из ComboBox`а "Статус" скрывать label
        private void ComboBox_fk_status_task_SelectedValueChanged(object sender, EventArgs e)
        {
            labelValidStatus.Hide();
        }

        // Скрывать Label при вводе в TextBox
        private void textBox_History_date_task_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidDate.Hide();
        }
    }
}

