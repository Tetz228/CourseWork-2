using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Security.Cryptography;
using System.Text;
using CourseWork.Main;

namespace CourseWork
{
    public partial class AuthorizationForm : MaterialForm
    {
        // vorobv.bm | z4HfUh
        public AuthorizationForm()
        {
            InitializeComponent();
            
            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // Авторизация в системе
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!ValidationAuth())
                return;
            else
                Authorization();
        }

        // Функция авторизации
        private void Authorization()
        {
            Form main = new MainForm();
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            byte[] passtohash = Encoding.UTF8.GetBytes(TextBoxPass.Text.ToString());

            SqlCommand selectLogPass = new SqlCommand("SELECT id_user, fk_role_user " +
                "login, " +
                "password " +
                "FROM Users " +
                "WHERE login = @log AND password = @pass", connection.GetSqlConnect());

            selectLogPass.Parameters.Add("@log", SqlDbType.VarChar).Value = TextBoxLog.Text;
            selectLogPass.Parameters.Add("@pass", SqlDbType.VarChar).Value = HashPassword(passtohash);

            connection.OpenConnect();

            adapter.SelectCommand = selectLogPass;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                SqlDataReader reader = selectLogPass.ExecuteReader();

                reader.Read();

                Values.AuthIdUser = Convert.ToInt32(reader.GetValue(0));
                Values.AuthRole_user = Convert.ToInt32(reader.GetValue(1));

                main.Left = this.Left;
                main.Top = this.Top;

                this.Hide();

                connection.CloseConnect();

                main.Show();
            }
            else
                MessageBox.Show("Неверный логин или пароль.");

            connection.CloseConnect();
        }
        
        // Проверка полей на пустоту
        public bool ValidationAuth()
        {
            if (string.IsNullOrEmpty(TextBoxLog.Text) && string.IsNullOrEmpty(TextBoxPass.Text))
            {
                labelValidAuthLog.Show();
                labelValidAuthPass.Show();

                return false;
            }    
            if (string.IsNullOrEmpty(TextBoxLog.Text))
            {
                labelValidAuthLog.Show();

                return false;
            }
            else
            if (string.IsNullOrEmpty(TextBoxPass.Text))
            {               
                labelValidAuthPass.Show();

                return false;
            }
            else
                return true;
        }

        // Хеширование пароля
        private string HashPassword(byte[] val)
        {
            using (SHA512Managed sha512 = new SHA512Managed())
            {
                var hash = sha512.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        // Перемещение формы
        Point point;

        private void AuthorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        // Переход в форму регистрации
        private void registrationLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextBoxLog.Text = "";
            TextBoxPass.Text = "";

            labelValidAuthLog.Hide();
            labelValidAuthPass.Hide();

            Form registration = new RegistrationForm();
     
            registration.Left = this.Left;
            registration.Top = this.Top;

            this.Hide();
            
            registration.Show();
        }

        // Переход в форму восстановления пароля
        private void ForgotPassLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextBoxLog.Text = "";
            TextBoxPass.Text = "";

            labelValidAuthLog.Hide();
            labelValidAuthPass.Hide();

            Form fogotPass = new ForgotPassForm();
           
            fogotPass.Left = this.Left; 
            fogotPass.Top = this.Top;

            this.Hide();

            fogotPass.Show();
        }

        // Скрывать Label`ы при вводе в TextBox`ы и при нажатии на Enter происходит авторизация
        private void TextBoxLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidAuthLog.Hide();

            if (e.KeyChar == 13)
                buttonLogin_Click(sender, e);
        }

        private void TextBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidAuthPass.Hide();

            if (e.KeyChar == 13)
                buttonLogin_Click(sender, e);
        }

        //  Показывать / скрывать пароль
        private void buttonShowHidePassword_Click(object sender, EventArgs e)
        {
            if (TextBoxPass.UseSystemPasswordChar == true)
            {
                TextBoxPass.UseSystemPasswordChar = false;
                pictureBoxShowHidePassword.Image = Properties.Resources.ShowPassword;
            }
            else
            {
                TextBoxPass.UseSystemPasswordChar = true;
                pictureBoxShowHidePassword.Image = Properties.Resources.HidePassword;
            } 
        }
    }
}
