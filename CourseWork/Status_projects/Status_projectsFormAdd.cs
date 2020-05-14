using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace CourseWork
{
    public partial class Status_projectsFormAdd : MaterialForm
    {
        public Status_projectsFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // Вызов проверки и сохранение изменений
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxNull())
                return;
            else
            {
                AddRowStatusProject();

                this.Close();
            }
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Функция добавления строки
        private void AddRowStatusProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddStatus_project", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@status_name_project", SqlDbType.NVarChar).Value = textBoxNameStatus.Text.Trim();

            SqlParameter parameter = command.Parameters.AddWithValue("@id_status_project", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Проверка на пустоту поля
        private bool CheckTextBoxNull()
        {
            if (string.IsNullOrWhiteSpace(textBoxNameStatus.Text))
            {
                labelValid.Show();

                return false;
            }
            else
                return true;
        }

        // Скрывать Label при вводе в TextBox
        private void textBoxNameStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }
    }
}
