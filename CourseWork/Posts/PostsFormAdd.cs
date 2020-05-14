using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace CourseWork.Posts
{
    public partial class PostsFormAdd : MaterialForm
    {
        public PostsFormAdd()
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
                AddRowPost();

                this.Close();
            }
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Функция добавления строки
        private void AddRowPost()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddPost", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@post_name", SqlDbType.NVarChar).Value = textBoxNamePost.Text.Trim();

            SqlParameter parameter = command.Parameters.AddWithValue("@id_post", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Проверка на пустоту поля
        private bool CheckTextBoxNull()
        {
            if (string.IsNullOrWhiteSpace(textBoxNamePost.Text))
            {
                labelValid.Show();

                return false;
            }
            else
                return true;
        }

        // Скрывать Label при вводе в TextBox
        private void textBoxNamePost_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }
    }
}
