using System;
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

            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        // При загрузки формы
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
            DataTable EmployeesTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(EmployeesTable);

            dataGridViewEmployees.DataSource = EmployeesTable.DefaultView;

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
            if (e.KeyCode == Keys.Insert)
            {
                EmployeesFormEdit formEdit = new EmployeesFormEdit();

                formEdit.ShowDialog();

                SelectDateEmployees();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesFormEdit formEdit = new EmployeesFormEdit();

            Program.DataEditEmployeeId.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_id_employee"].Value);
            Program.DataEditEmployeeLname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_employee_lname"].Value);
            Program.DataEditEmployeeFname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_employee_fname"].Value);
            Program.DataEditEmployeeMname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_employee_mname"].Value);
            Program.DataEditEmployeeEmail.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Column_Email"].Value);

            formEdit.ShowDialog();

            SelectDateEmployees();
        }

        // При 2-ом клике на ячейку можно провести редактирование
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
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowEmployee();
           
            e.Cancel = true;
        }
    }
}
