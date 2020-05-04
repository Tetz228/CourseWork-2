using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace CourseWork
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            labelDashAuthLog.ForeColor = Color.White;
        }

        // Авторизация в системе
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (ValidationAuth())
                return;
            else
                Authorization();
        }

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

            // Выполняем команду
            adapter.SelectCommand = selectLogPass;

            // Заполняем таблицу
            adapter.Fill(table);

            // Если таблица содержит хоть 1 ряд
            if (table.Rows.Count > 0)
            {
                main.Left = this.Left;
                main.Top = this.Top;
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                labelDashAuthPass.ForeColor = Color.Red;
                labelDashAuthLog.ForeColor = Color.Red;
            }
        }
        
        // Валидация авторизации
        public bool ValidationAuth()
        {
            int check = 0;

            if (string.IsNullOrEmpty(TextBoxLog.Text))
            {
                labelValidAuthLog.Show();
                labelDashAuthLog.ForeColor = Color.Red;
                check = 1;
            }
            else
            if (string.IsNullOrEmpty(TextBoxPass.Text))
            {
                labelValidAuthPass.Show();
                labelDashAuthPass.ForeColor = Color.Red;
                check = 1;
            }

            if (check == 1)
                return true;
            else
                return false;
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

            Form registration = new RegistrationForm();

            // Задает открываемой форме позицию слева, равную позиции текущей формы
            registration.Left = this.Left;
            // Задает открываемой форме позицию сверху, равную позиции текущей формы
            registration.Top = this.Top;
            this.Hide();
            
            registration.Show();
        }

        // При клике на TextBox`ы
        private void TextBoxLog_Click(object sender, EventArgs e)
        {
            labelDashAuthLog.ForeColor = Color.White;
        }

        private void TextBoxPass_Click(object sender, EventArgs e)
        {
            labelDashAuthPass.ForeColor = Color.White;
        }

        // При выходе из TextBox`ов
        private void TextBoxLog_Leave(object sender, EventArgs e)
        {
            labelDashAuthLog.ForeColor = Color.Black;
        }

        private void TextBoxPass_Leave(object sender, EventArgs e)
        {
            labelDashAuthPass.ForeColor = Color.Black;
        }

        // Закрытие приложения
        private void pictureBoxAuthExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        // Сворачивать окно
        private void pictureBoxRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
