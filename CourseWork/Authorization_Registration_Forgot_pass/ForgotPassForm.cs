using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MaterialSkin.Controls;
using MaterialSkin;
using CourseWork.Authorization_Registration_Forgot_pass;

namespace CourseWork
{
    public partial class ForgotPassForm : MaterialForm
    {
        

        public ForgotPassForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ForgotPassForm_Load(object sender, EventArgs e)
        {
            MainLabel.Text = "Введите адрес электронной почты, который\nвы использовали для регистрации.";
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (!ValidationEmail(textBoxEmail.Text))
            {
                labelValidEmail.Text = "Некорректная почта";
                labelValidEmail.Show();

                return;
            }
                
            else
            if(!SearchEmail())
                return;
            else
            {
                ForgotPassFormCode formCode = new ForgotPassFormCode();

                formCode.Left = this.Left;
                formCode.Top = this.Top;

                this.Hide();

                formCode.ShowDialog();
            }
        }

        private bool SearchEmail()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand selectEmail = new SqlCommand("SELECT Email FROM Employees WHERE Email = @email", connection.GetSqlConnect());
            selectEmail.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxEmail.Text.Trim();

            // Выполняем команду
            adapter.SelectCommand = selectEmail;

            // Заполняем таблицу
            adapter.Fill(table);

            // Если таблица содержит хоть 1 ряд
            if (table.Rows.Count > 0)
            {
                Program.DataEmailPass.Value = textBoxEmail.Text.Trim();

                return true;
            }
            else
            {
                labelValidEmail.Text = "Пользователь не найден";
                labelValidEmail.Show();

                return false;
            } 
        }

        private void ChangePassword()
        {
            //ConnectionDB connection = new ConnectionDB();
            //DataTable table = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter();

            //string email = TextBoxEmail.Text;

            //SqlCommand selectEmail = new SqlCommand("SELECT password, Email " +
            //    "from Users " +
            //    "left join Employees ON fk_employee = id_employee " +
            //    "where Email = '@email'", connection.GetSqlConnect());
            //selectEmail.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            //// Выполняем команду
            //adapter.SelectCommand = selectEmail;

            //// Заполняем таблицу
            //adapter.Fill(table);

            //// Если таблица содержит хоть 1 ряд
            //if (table.Rows.Count > 0)
            //{
            //    //СonfirmationСode();
            //    MessageBox.Show("Nashel");
            //}
            //else
            //    labelValidEmail.Show();
            
        }

        // Валидация почты
        private bool ValidationEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form authorization = Application.OpenForms[0];

            authorization.StartPosition = FormStartPosition.Manual;
            authorization.Left = this.Left;
            authorization.Top = this.Top;
            authorization.Show();
        }

        // Перемещение формы
        Point point;

        private void ForgotPass_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void ForgotPass_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidEmail.Hide();
        }
    }
}
