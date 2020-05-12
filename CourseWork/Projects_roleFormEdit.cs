﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class Projects_roleFormEdit : MaterialForm
    {
        public Projects_roleFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        // При загрузки формы передать тест из класса в TextBox
        private void Projects_roleFormEdit_Load(object sender, EventArgs e)
        {
            textBoxEdit.Text = Program.DataEditProjects_role.Value;
        }

        // При нажатии валидация и передача текста в класс
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
                return;
            else
            {
                EditRowProjects_role();
                this.Close();
            }
            
        }

        // Функция редактирования строки
        private void EditRowProjects_role()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditProjects_role", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@project_role_name", SqlDbType.NVarChar).Value = textBoxEdit.Text.Trim();
            command.Parameters.AddWithValue("@id_project_role", Convert.ToInt32(Program.DataEditProjects_roleId.Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

        }

        // Валидация TextBox`а
        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxEdit.Text))
            {
                labelValid.Show();

                return false;
            }
            else
                return true;
        }

        // При нажатии передать определенный текст в класс
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // При вводе в TextBox скрывать label
        private void textBoxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelValid.Hide();
        }
    }
}
