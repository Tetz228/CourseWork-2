using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace CourseWork
{
    public partial class RegistrationForm : Form
    {
        private string global;

        public RegistrationForm()
        {
            InitializeComponent();
            
            labelDashLname.ForeColor = Color.White;
        }

        // Вызов всех проверок и переход к панели подтвержения почты 
        private void ButtonReg_Click(object sender, EventArgs e)
        {
            if (ValidationReg())
                return;
            else

                if (CheckLog())
                return;
            else

                if (CheckPass())
                return;
            else

                if (CheckEmail())
                return;
            else

                if (LoginExist())
                return;
            else

                if (!ValidationEmail(TextBoxEmail.Text))
            {
                labelValidEmail.Text = "Некорректная почта";
                labelValidEmail.Show();

                return;
            }
            else

                if (MailExist())
                return;
            else
            {
                СonfirmationСode();

                panelConfirmationMail.Show();

                // Только чтение, чтобы пользователь не мог изменить данные,так как выслан код подтверждения
                TextBoxLname.ReadOnly = true;
                TextBoxFname.ReadOnly = true;
                TextBoxMname.ReadOnly = true;
                TextBoxRegLog.ReadOnly = true;
                TextBoxRegPass.ReadOnly = true;
                TextBoxEmail.ReadOnly = true;
            }
        }

        // Валидация всех TextBox`ов в регистрации
        private bool ValidationReg()
        {
            int check = 0;

            if (string.IsNullOrWhiteSpace(TextBoxLname.Text))
            {
                labelValidLname.Text = "Введите фамилию";
                labelValidLname.Show();

                labelDashLname.ForeColor = Color.Red;

                check = 1;
            }
            if (string.IsNullOrWhiteSpace(TextBoxFname.Text))
            {
                labelValidFname.Text = "Введите имя";
                labelValidFname.Show();

                labelDashFname.ForeColor = Color.Red;

                check = 1;
            }
            if (string.IsNullOrEmpty(TextBoxRegLog.Text))
            {
                labelValidRegLog.Text = "Введите логин";
                labelValidRegLog.Show();

                labelDashRegLog.ForeColor = Color.Red;

                check = 1;
            }
            if (string.IsNullOrEmpty(TextBoxRegPass.Text))
            {
                labelValidRegPass.Text = "Введите пароль";
                labelValidRegPass.Show();

                labelDashRegPass.ForeColor = Color.Red;

                check = 1;
            }
            if (string.IsNullOrEmpty(TextBoxEmail.Text))
            {
                labelValidEmail.Text = "Введите почту";
                labelValidEmail.Show();

                labelDashEmail.ForeColor = Color.Red;

                check = 1;
            }

            if (check == 1)
                return true;
            else
                return false;
        }

        // Проверка логина на нужную длину
        private bool CheckLog()
        {
            if (TextBoxRegLog.Text.Length < 4)
            {
                labelValidRegLog.Text = "Логин должен быть длиной\nот 4 до 25 символов";
                labelValidRegLog.Show();

                return true;
            }
            else
                return false;
        }

        // Проверка пароля на нужную длину
        private bool CheckPass()
        {
            if (TextBoxRegPass.Text.Length < 6)
            {
                labelValidRegPass.Text = "Пароль должен быть длиной\nот 6 до 25 символов";
                labelValidRegPass.Show();

                return true;
            }
            else
                return false;
        }

        // Проверка почты нужную длину
        private bool CheckEmail()
        {
            if (TextBoxEmail.Text.Length < 4)
            {
                labelValidEmail.Text = "Почта должен быть длиной\nот 4 до 31 символов";
                labelValidEmail.Show();

                return true;
            }
            else
                return false;
        }

        // Проверка на уникальность логина
        private bool LoginExist()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT login FROM Users WHERE login = @log", connection.GetSqlConnect());
            selectLog.Parameters.Add("@log", SqlDbType.VarChar).Value = TextBoxRegLog.Text;

            adapter.SelectCommand = selectLog;
            adapter.Fill(table);

            connection.CloseConnect();

            if (table.Rows.Count > 0)
            {
                labelValidRegLog.Text = "Пользователь с таким логином\nуже существует!";
                labelValidRegLog.Show();

                labelDashRegLog.ForeColor = Color.Red;

                return true;
            }
            else
                return false;
        }

        // Валидация почты
        public bool ValidationEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        // Проверка на уникальность почты
        private bool MailExist()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT Email FROM Employees WHERE Email = @email", connection.GetSqlConnect());
            selectLog.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBoxEmail.Text;

            adapter.SelectCommand = selectLog;
            adapter.Fill(table);

            connection.CloseConnect();

            if (table.Rows.Count > 0)
            {
                labelValidEmail.Text = "Пользователь с такой почтой\nуже существует!";
                labelValidEmail.Show();

                labelDashEmail.ForeColor = Color.Red;
                return true;
            }
            else
                return false;
        }

        //Получение кода подтвеждения с помощью глобальной переменной 
        public void СonfirmationСode()
        {
            global = MailConfirmation(TextBoxEmail.Text);
        }

        // Отправка кода подтверждения
        public string MailConfirmation(string email)
        {
            Random random = new Random();

            string kod;

            MailAddress fromMailAddress = new MailAddress("itproject719@gmail.com", "ITProject");

            MailAddress toMailAddress = new MailAddress(email);

            using (MailMessage mailMessager = new MailMessage(fromMailAddress, toMailAddress))

            using (SmtpClient smtp = new SmtpClient("smtp.mail.ru", 465))
            {
                kod = Convert.ToString(random.Next(100000, 999999));

                mailMessager.Subject = "Подтверждение почты";
                mailMessager.Body = "Код подтверждения - " + kod;

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromMailAddress.Address, "%*kHy#l7~x");
                smtp.Send(mailMessager);

                return kod;
            }
        }

        // Повторная отправка кода
        private void linkLabelConfirmationCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            СonfirmationСode();
        }

        //Сравнение введенного кода с полученным кодом в глобальной переменной 
        private void buttonConfirmationMail_Click(object sender, EventArgs e)
        {
            string kod = textBoxConfirmationMail.Text;

            if (kod == global)
                Registration();
            else
                labelConfirmationMail.Show();
        }

        // Регистрация пользователя в базу данных
        private void Registration()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlCommand insertIntoEmp = new SqlCommand("INSERT INTO Employees(employee_lname, employee_fname, employee_mname, Email) VALUES(@employee_lname, @employee_fname, @employee_mname, @Email) ", connection.GetSqlConnect());

            insertIntoEmp.Parameters.Add("@employee_lname", SqlDbType.NVarChar).Value = TextBoxLname.Text;
            insertIntoEmp.Parameters.Add("@employee_fname", SqlDbType.NVarChar).Value = TextBoxFname.Text;
            insertIntoEmp.Parameters.Add("@Email", SqlDbType.NVarChar).Value = TextBoxEmail.Text;

            if (string.IsNullOrWhiteSpace(TextBoxMname.Text))
                insertIntoEmp.Parameters.Add("@employee_mname", SqlDbType.NVarChar).Value = "Не указано";
            else
                insertIntoEmp.Parameters.Add("@employee_mname", SqlDbType.NVarChar).Value = TextBoxMname.Text;

            if (insertIntoEmp.ExecuteNonQuery() == 1)
            {
                SqlCommand selectIdEmp = new SqlCommand("SELECT id_employee FROM Employees WHERE @mail = Email", connection.GetSqlConnect());

                selectIdEmp.Parameters.Add("@mail", SqlDbType.NVarChar).Value = TextBoxEmail.Text;

                string idEmp = selectIdEmp.ExecuteScalar().ToString();

                SqlCommand insertIntoUser = new SqlCommand("INSERT INTO Users(login,password,fk_role_user,fk_employee) VALUES(@log, @pass, @role, @fk_employee)", connection.GetSqlConnect());

                insertIntoUser.Parameters.Add("@log", SqlDbType.VarChar).Value = TextBoxRegLog.Text;
                insertIntoUser.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBoxRegPass.Text;
                insertIntoUser.Parameters.Add("@role", SqlDbType.Int).Value = 2;
                insertIntoUser.Parameters.Add("@fk_employee", SqlDbType.Int).Value = Convert.ToInt32(idEmp);

                //Если команда = 1, то есть она успешно выполняется, то аккаунт будет создан
                if (insertIntoUser.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!");
                    this.Close();
                }
                else
                    MessageBox.Show("Аккаунт не был создан!");
            }

            connection.CloseConnect();
        }



        // Скрывать Label в "Фамилии" и ввод только определенных символов
        private void TextBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidLname.Hide();

            //BACKSPACE, space, русс. и анг. символы, Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z, цифры
            if (!(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar <= 'я' && e.KeyChar >= 'а' || e.KeyChar >= 'А' && e.KeyChar <= 'Я' 
                || e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' 
                || e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026
                || (e.KeyChar >= 48 && e.KeyChar <= 57)))
                e.Handled = true;

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        // Скрывать Label в "Имя" и ввод только определенных символов
        private void TextBoxFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidFname.Hide();

            //BACKSPACE, space, русс. и анг. символы, Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z, цифры, минус, нижнее подчеркивание
            if (!(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar <= 'я' && e.KeyChar >= 'а' || e.KeyChar >= 'А' && e.KeyChar <= 'Я'
                || e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                || e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026
                || (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 45 || e.KeyChar == 95)))
                e.Handled = true;

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        // Ввод только определенных символов
        private void TextBoxMname_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidLname.Hide();

            //BACKSPACE, space, русс. и анг. символы, Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z, цифры, минус, нижнее подчеркивание
            if (!(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar <= 'я' && e.KeyChar >= 'а' || e.KeyChar >= 'А' && e.KeyChar <= 'Я'
                || e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                || e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026
                || (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 45 || e.KeyChar == 95)))
                e.Handled = true;

            if (e.KeyChar == 13)
                ButtonReg_Click(sender, e);
        }

        // Скрывать Label в "Логин" и ввод только определенных символов 
        private void TextBoxRegLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegLog.Hide();

            //BACKSPACE, цифры, буквы верхнего регистра, буквы нижнего регистра, точка, минус, нижнее подчеркивание, Shift
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90) ||
                (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 46 || e.KeyChar == 45 || e.KeyChar == 95 || e.KeyChar == 14 ||
                // Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z
                e.KeyChar == 001 || e.KeyChar == 003 || e.KeyChar == 024 || e.KeyChar == 026))
            {
                e.Handled = true;
            }
        }

        // Запрет на ввод отпределенных символов
        private void TextBoxRegPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidRegPass.Hide();

            //Запрет на ввод space, кириллицы, Ctrl + V
            char key = e.KeyChar;

            if (key == 32 || key <= 'я' && key >= 'а' || key >= 'А' && key <= 'Я' || key == 13 || key == 022)
                e.Handled = true;
        }

        // Ввод только определенных символов
        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidEmail.Hide();

            char key = e.KeyChar;

            //BACKSPACE, цифры, буквы нижнего регистра, точка, минус, нижнее подчеркивание, Shift, @
            if (!(key == 8 || (key >= 48 && key <= 57) || (key >= 97 && key <= 122) ||
                key == 46 || key == 45 || key == 95 || key == 14 || key == 64 || key <= 'я' && key >= 'а'  ||
                // Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z
                key == 001 || key == 003 || key == 024 || key == 026))
            {
                e.Handled = true;
            }
        }

        // Ввод только определенных символов
        private void textBoxConfirmationMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelConfirmationMail.Hide();

            char key = e.KeyChar;

            //Только цифры
            if (!(key >= 48 && key <= 57 ||
                // Ctrl + A, Ctrl + C, Ctrl + X, Ctrl + Z
                key == 001 || key == 003 || key == 024 || key == 026))

                e.Handled = true;
        }

        // Перемещение формы
        Point point;

        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        // Возврат к форме авторизации
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // При закрытии формы
        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Вызываем главную форму, которая открыла текущую, главная форма всегда 0
            Form authorization = Application.OpenForms[0]; 

            authorization.StartPosition = FormStartPosition.Manual; 
            authorization.Left = this.Left;
            authorization.Top = this.Top;
            authorization.Show();
        }

        // При клике на TextBox "Фамилия"
        private void TextBoxFname_Click(object sender, EventArgs e)
        {
            labelDashFname.ForeColor = Color.White;
        }

        // При клике на TextBox "Имя"
        private void TextBoxLname_Click(object sender, EventArgs e)
        {
            labelDashLname.ForeColor = Color.White;
        }

        // При клике на TextBox "Отчество"
        private void TextBoxMname_Click(object sender, EventArgs e)
        {
            labelDashMname.ForeColor = Color.White;
        }

        // При клике на TextBox "Логин"
        private void TextBoxRegLog_Click(object sender, EventArgs e)
        {
            labelDashRegLog.ForeColor = Color.White;
        }

        // При клике на TextBox "Пароль"
        private void TextBoxRegPass_Click(object sender, EventArgs e)
        {
            labelDashRegPass.ForeColor = Color.White;
        }

        // При клике на TextBox "Email"
        private void TextBoxEmail_Click(object sender, EventArgs e)
        {
            labelDashEmail.ForeColor = Color.White;
        }

        // При клике на TextBox "Подтверждение Email`a"
        private void textBoxConfirmationMail_Click(object sender, EventArgs e)
        {
            labelDashConfirmationMail.ForeColor = Color.White;
        }

        // При выходе из TextBox`а "Фамилия"
        private void TextBoxLname_Leave(object sender, EventArgs e)
        {
            labelDashLname.ForeColor = Color.Black;
        }

        // При выходе из TextBox`а "Имя"
        private void TextBoxFname_Leave(object sender, EventArgs e)
        {
            labelDashFname.ForeColor = Color.Black;
        }

        // При выходе из TextBox`а "Отчество"
        private void TextBoxMname_Leave(object sender, EventArgs e)
        {
            labelDashMname.ForeColor = Color.Black;
        }

        // При выходе из TextBox`а "Логин"
        private void TextBoxRegLog_Leave(object sender, EventArgs e)
        {
            labelDashRegLog.ForeColor = Color.Black;
        }

        // При выходе из TextBox`а "Пароль"
        private void TextBoxRegPass_Leave(object sender, EventArgs e)
        {
            labelDashRegPass.ForeColor = Color.Black;
        }

        // При выходе из TextBox`а "Email"
        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            labelDashEmail.ForeColor = Color.Black;
        }

        // При выходе из TextBox`а "Подтверждение Email`a"
        private void textBoxConfirmationMail_Leave(object sender, EventArgs e)
        {
            labelDashConfirmationMail.ForeColor = Color.Black;
        }

        // Сворачивание окна
        private void pictureBoxRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Закрытие приложения
        private void pictureBoxRegExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Exit();
        }

        // При возврате к регистрации
        private void buttonBackConfirmationMail_Click(object sender, EventArgs e)
        {
            // Снятие ограничения "Только чтение" из-за скрытия панели
            TextBoxLname.ReadOnly = false;
            TextBoxFname.ReadOnly = false;
            TextBoxMname.ReadOnly = false;
            TextBoxRegLog.ReadOnly = false;
            TextBoxRegPass.ReadOnly = false;
            TextBoxEmail.ReadOnly = false;

            panelConfirmationMail.Hide();
        }
    }
}