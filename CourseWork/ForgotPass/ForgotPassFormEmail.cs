using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
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

        // При нажатии вызов проверок и показ формы ввода кода
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (!ValidationEmail())
            {
                labelValidEmail.Text = "Некорректная почта.";
                labelValidEmail.Show();

                return;
            }
            else
            if (!SearchEmail())
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

        // При нажатии закрытие формы
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Валидация почты
        private bool ValidationEmail()
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(textBoxEmail.Text, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }

        // Поиск почты и id пользователя в бд 
        private bool SearchEmail()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand selectEmail = new SqlCommand("SELECT id_employee, Email FROM Employees WHERE Email = @email", connection.GetSqlConnect());

            selectEmail.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxEmail.Text.Trim();

            connection.OpenConnect();

            adapter.SelectCommand = selectEmail;
            adapter.Fill(table);
  
            if (table.Rows.Count > 0)
            {
                SqlDataReader reader = selectEmail.ExecuteReader();

                reader.Read();

                Program.DataIdForgotPass.Value = reader.GetValue(0).ToString();
                Program.DataEmailForgotPass.Value = textBoxEmail.Text.Trim();

                connection.CloseConnect();

                return true;
            }
            else
            {
                labelValidEmail.Text = "Пользователь с такой почтой не найден.";
                labelValidEmail.Show();

                connection.CloseConnect();

                return false;
            }         
        }

        // При закрытии формы
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

        // При вводе в TextBox скрывать label
        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidEmail.Hide();
        }
    }
}
