﻿using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

namespace CourseWork
{
    public partial class EmployeesForm : MaterialForm
    {
        DataTable EmployeesTable = new DataTable();

        public EmployeesForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            if (Values.AuthRole_user == 2)
                MainToolStripMenuItem.Visible = false;
        }

        // При загрузки формы
        private void Employees_Load(object sender, EventArgs e)
        {
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateEmployees();

            radioButtonLname.Checked = true;
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateEmployees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * " +
                "FROM Employees", connection.GetSqlConnect());
            EmployeesTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(EmployeesTable);
   
            dataGridViewEmployees.DataSource = EmployeesTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string lname = "employee_lname like '%{0}%' ";
            string fname = "employee_fname like '%{0}%' ";
            string mname = "employee_mname like '%{0}%' ";
            string email = "Email like '%{0}%' ";

            if (radioButtonLname.Checked)
                Search(lname);
            if (radioButtonFname.Checked)
                Search(fname);
            if (radioButtonMname.Checked)
                Search(mname);
            if (radioButtonEmail.Checked)
                Search(email);
        }

        // Функция по поиску
        private void Search(string f)
        {
            DataView view = EmployeesTable.DefaultView;

            view.RowFilter = string.Format(f, textBoxSearch.Text);

            dataGridViewEmployees.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowEmployee()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteEmployees", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_employee", Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateEmployees();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesFormAdd formAdd = new EmployeesFormAdd();

            formAdd.ShowDialog();

            SelectDateEmployees();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            if (Values.AuthRole_user != 2)
                if (e.KeyCode == Keys.Insert)
                {
                    EmployeesFormAdd formAdd = new EmployeesFormAdd();

                    formAdd.ShowDialog();

                    SelectDateEmployees();
                }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesFormEdit formEdit = new EmployeesFormEdit();

            Values.EmployeeId = Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells[0].Value);
            Values.EmployeeLname = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[1].Value);
            Values.EmployeeFname = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[2].Value);
            Values.EmployeeMname = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[3].Value);
            Values.EmployeeEmail = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[4].Value);

            formEdit.ShowDialog();

            SelectDateEmployees();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Values.AuthRole_user != 2)
                if (e.RowIndex != -1)
                {
                    DataGridViewRow view = dataGridViewEmployees.Rows[e.RowIndex];

                    Values.EmployeeId = Convert.ToInt32(view.Cells[0].Value.ToString());
                    Values.EmployeeLname = view.Cells[1].Value.ToString();
                    Values.EmployeeFname = view.Cells[2].Value.ToString();
                    Values.EmployeeMname = view.Cells[3].Value.ToString();
                    Values.EmployeeEmail = view.Cells[4].Value.ToString();

                    EmployeesFormEdit formEdit = new EmployeesFormEdit();

                    formEdit.ShowDialog();

                    SelectDateEmployees();
                }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowEmployee();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewEmployees_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (Values.AuthRole_user != 2)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DeleteRowEmployee();

                e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        // При клике на pictureBox скрывать панель
        private void pictureBoxFilters_Click(object sender, EventArgs e)
        {
            if (panelFilters.Visible == false)
                panelFilters.Visible = true;
            else
                panelFilters.Visible = false;
        }

        // При клике на переключатели скрывать панель
        private void radioButtonLname_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonFname_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonMname_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonEmail_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }
    }
}
