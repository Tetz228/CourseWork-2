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

namespace CourseWork
{
    public partial class ForgotPassForm : Form
    {


        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void SearchUser()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string email = TextBoxEmail.Text;

            SqlCommand selectEmail = new SqlCommand("SELECT Email FROM Employees WHERE Email = @email", connection.GetSqlConnect());
            selectEmail.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            // Выполняем команду
            adapter.SelectCommand = selectEmail;

            // Заполняем таблицу
            adapter.Fill(table);

            // Если таблица содержит хоть 1 ряд
            if (table.Rows.Count > 0)
            {
                //СonfirmationСode();
                panelEntryСode.Show();  
            } 
            else
                labelValidEmail.Show();
        }

        private void ChangePassword()
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string email = TextBoxEmail.Text;

            SqlCommand selectEmail = new SqlCommand("SELECT password, Email " +
                "from Users " +
                "left join Employees ON fk_employee = id_employee " +
                "where Email = '@email'", connection.GetSqlConnect());
            selectEmail.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            // Выполняем команду
            adapter.SelectCommand = selectEmail;

            // Заполняем таблицу
            adapter.Fill(table);

            // Если таблица содержит хоть 1 ряд
            if (table.Rows.Count > 0)
            {
                //СonfirmationСode();
                MessageBox.Show("Nashel");
            }
            else
                labelValidEmail.Show();
            
        }

        //Получение кода подтвеждения с помощью глобальной переменной 
        private void СonfirmationСode()
        {
            RegistrationForm registration = new RegistrationForm();

            //global = registration.SendingCode(TextBoxEmail.Text);
        }

        private void pictureBoxForgotExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Further_Click(object sender, EventArgs e)
        {
            SearchUser();
            //panelEntryСode.Show();
        }

        private void TextBoxEmail_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValidEmail.Hide();
        }

        private void panelFurther_Click(object sender, EventArgs e)
        {
            string kod = TextBoxCode.Text;

            //if (kod == global)
                panelNewPass.Show();
            //else
            //    labelCode.Show();
        }

        private void TextBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelCode.Hide();
        }

        private void buttonBackCode_Click(object sender, EventArgs e)
        {
            panelEntryСode.Hide();
        }

        private void buttonBackEmail_Click(object sender, EventArgs e)
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

        private void buttonBackPass_Click(object sender, EventArgs e)
        {
            panelNewPass.Hide();
        }
    }
}
