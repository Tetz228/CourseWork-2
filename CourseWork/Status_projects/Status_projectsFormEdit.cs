using System;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CourseWork
{
    public partial class Status_projectsFormEdit : MaterialForm
    {
        public Status_projectsFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void Status_projectsFormEdit_Load(object sender, EventArgs e)
        {
            textBoxEdit.Text = Program.DataEditStatus_project.Value;
        }

        // Функция редактирования строки
        private void EditRowStatusProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditStatus_project", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@status_name_project", SqlDbType.NVarChar).Value = textBoxEdit.Text.Trim();
            command.Parameters.AddWithValue("@id_status_project", Convert.ToInt32(Program.DataEditStatus_projectId.Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Вызов проверки и сохранение изменений
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                EditRowStatusProject();

                this.Close();
            }
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Проверка на пустоту поля
        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxEdit.Text))
            {
                labelValid.Show();

                return false;
            }
            else
                return true;
        }

        // Скрывать Label при вводе в TextBox
        private void textBoxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }
    }
}
