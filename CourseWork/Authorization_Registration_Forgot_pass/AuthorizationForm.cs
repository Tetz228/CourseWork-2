using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class AuthorizationForm : MaterialForm
    {
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

            string loginUser = TextBoxLog.Text;
            string passUser = TextBoxPass.Text;

            SqlCommand selectLogPass = new SqlCommand("SELECT login, password FROM Users WHERE login = @log AND password = @pass", connection.GetSqlConnect());
            selectLogPass.Parameters.Add("@log", SqlDbType.VarChar).Value = loginUser;
            selectLogPass.Parameters.Add("@pass", SqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = selectLogPass;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                main.Left = this.Left;
                main.Top = this.Top;
                this.Hide();
                main.Show();
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }
        
        // Валидация авторизации
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

        private void ForgotPassLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("В разработке");
            //TextBoxLog.Text = "";
            //TextBoxPass.Text = "";

            //Form fogotPass = new ForgotPass();

            //// Задает открываемой форме позицию слева, равную позиции текущей формы
            //fogotPass.Left = this.Left;
            //// Задает открываемой форме позицию сверху, равную позиции текущей формы
            //fogotPass.Top = this.Top;
            //this.Hide();

            //fogotPass.Show();
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
