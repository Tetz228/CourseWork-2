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

namespace CourseWork
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            labelDashAuthLog.ForeColor = Color.DeepSkyBlue;
        }

        // Авторизация в систему
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form main = new MainForm();
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string loginUser = TextBoxLog.Text;
            string passUser = TextBoxPass.Text;

            // Делаем запрос к бд и заменяем заглушки на переменные для того, чтобы обезопасить бд
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE login = @log AND password = @pass", connection.GetSqlConnect());
            command.Parameters.Add("@log", SqlDbType.NVarChar).Value = loginUser;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = passUser;

            // Какую команду будем выполнять
            adapter.SelectCommand = command;

            // Заполняем таблицу
            adapter.Fill(table);

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
        private void registrationLabel_Click(object sender, EventArgs e)
        {
            Form registration = new RegistrationForm();

            // Задает открываемой форме позицию слева, равную позиции текущей формы
            registration.Left = this.Left;
            // Задает открываемой форме позицию сверху, равную позиции текущей формы
            registration.Top = this.Top; 
            this.Hide();
            registration.Show();
        }

        // Покраска Label`ов в различных ситуациях
        private void registrationLabel_MouseHover(object sender, EventArgs e)
        {
            registrationLabel.ForeColor = Color.DeepSkyBlue;
        }

        private void registrationLabel_MouseLeave(object sender, EventArgs e)
        {
            registrationLabel.ForeColor = Color.Black;
        }

        private void ForgotLabel_MouseHover(object sender, EventArgs e)
        {
            ForgotLabel.ForeColor = Color.DeepSkyBlue;
        }

        private void ForgotLabel_MouseLeave(object sender, EventArgs e)
        {
            ForgotLabel.ForeColor = Color.Black;
        }

        // При клике на TextBox`ы
        private void TextBoxLog_Click(object sender, EventArgs e)
        {
            labelDashAuthLog.ForeColor = Color.DeepSkyBlue;
        }

        private void TextBoxPass_Click(object sender, EventArgs e)
        {
            labelDashAuthPass.ForeColor = Color.DeepSkyBlue;
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
    }
}
