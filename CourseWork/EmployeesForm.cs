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
    public partial class EmployeesForm : MaterialForm
    {
        public EmployeesForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateEmployees();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateEmployees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Employees", connection.GetSqlConnect());
            DataTable ProjectTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTable);

            dataGridViewEmployees.DataSource = ProjectTable.DefaultView;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowEmployee()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteEmployees", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_employee", Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells["Column_id_employee"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateEmployees();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления, после чего вызов функции добавления строки
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesFormAdd formAdd = new EmployeesFormAdd();

            formAdd.ShowDialog();

            SelectDateEmployees();
        }

        // При нажатии на Ins(Insert) на клавиатуре появляется форма добавления
        private void dataGridViewEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                //EmployeesFormEdit formEdit = new EmployeesFormEdit();

                //formAdd.ShowDialog();

                SelectDateEmployees();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения, после чего проверка класса и вызов функции редактирования строки
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsFormEdit formEdit = new ProjectsFormEdit();

            Program.DataEditEmployeeId.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_id_employee"].Value);
            Program.DataEditEmployeeLname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_employee_lname"].Value);
            Program.DataEditEmployeeFname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_employee_fname"].Value);
            Program.DataEditEmployeeMname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_employee_mname"].Value);
            Program.DataEditEmployeeEmail.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_Email"].Value);

            formEdit.ShowDialog();

            SelectDateEmployees();
        }

        // Cобытие при 2-ом клике на ячейку позволяет провести редактирование
        private void dataGridViewEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewEmployees.Rows[e.RowIndex];
                Program.DataEditEmployeeId.Value = view.Cells[0].Value.ToString();
                Program.DataEditEmployeeLname.Value = view.Cells[1].Value.ToString();
                Program.DataEditEmployeeFname.Value = view.Cells[2].Value.ToString();
                Program.DataEditEmployeeMname.Value = view.Cells[3].Value.ToString();
                Program.DataEditEmployeeEmail.Value = view.Cells[4].Value.ToString();

                ProjectsFormEdit formEdit = new ProjectsFormEdit();

                formEdit.ShowDialog();

                SelectDateEmployees();
            }
        }

        // При клике на "Правка" -> "Удалить"
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowEmployee();
            else
                return;
        }

        // При выделение строки и нажание на клавишу Del(Delete)
        private void dataGridViewEmployees_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowEmployee();
            else
                e.Cancel = true;

            e.Cancel = true;
        }
    }
}
