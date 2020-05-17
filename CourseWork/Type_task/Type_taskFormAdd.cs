using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork.Type_task
{
    public partial class Type_taskFormAdd : MaterialForm
    {
        public Type_taskFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // Вызов проверки и добавление в бд
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxNull())
                return;
            else
            {
                AddRowTypeTask();

                this.Close();
            }
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Функция добавления строки
        private void AddRowTypeTask()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddType_task", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@task_name_type", SqlDbType.NVarChar).Value = textBoxNameType.Text.Trim();
            command.Parameters.AddWithValue("@task_description", SqlDbType.NVarChar).Value = textBoxDescription.Text.Trim();

            SqlParameter parameter = command.Parameters.AddWithValue("@id_type_task", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Проверка на пустоту полей
        private bool CheckTextBoxNull()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(textBoxNameType.Text))
            {
                labelValid.Show();

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                labelValid1.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }

        // Скрывать Label`ы при вводе в TextBox`ы
        private void textBoxNameType_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid1.Hide();
        }
    }
}
