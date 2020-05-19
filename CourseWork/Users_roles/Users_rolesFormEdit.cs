using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseWork.Users_roles
{
    public partial class Users_rolesFormEdit : MaterialForm
    {
        public Users_rolesFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы
        private void Users_rolesFormEdit_Load(object sender, EventArgs e)
        {
            textBoxNameRole.Text = Program.DataEditUsers_rolesName.Value;
        }

        // Вызов проверки и сохранение изменений
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxNull())
                return;
            else
            {
                EditRowUsers_roles();

                this.Close();
            }
        }

        // При нажатии закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Функция добавления строки
        private void EditRowUsers_roles()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditUsers_roles", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@user_name_role", SqlDbType.NVarChar).Value = textBoxNameRole.Text.Trim();
            command.Parameters.AddWithValue("@id_user_role", SqlDbType.NVarChar).Value = Program.DataEditUsers_rolesId.Value;

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Проверка на пустоту поля
        private bool CheckTextBoxNull()
        {
            if (string.IsNullOrWhiteSpace(textBoxNameRole.Text))
            {
                labelValid.Show();

                return false;
            }
            else
                return true;
        }

        // Скрывать Label при вводе в TextBox
        private void textBoxNameRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }
    }
}
