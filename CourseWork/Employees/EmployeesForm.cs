using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

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
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Employees", connection.GetSqlConnect());
            EmployeesTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(EmployeesTable);
   
            dataGridViewEmployees.DataSource = EmployeesTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonLname.Checked)
                SearchLname();
            if (radioButtonFname.Checked)
                SearchFname();
            if (radioButtonMname.Checked)
                SearchMname();
            if (radioButtonEmail.Checked)
                SearchEmail();
        }

        // Фильтр: Фамилия
        private void SearchLname()
        {
            DataView view = EmployeesTable.DefaultView;

            view.RowFilter = string.Format("employee_lname like '%{0}%' ", textBoxSearch.Text);

            dataGridViewEmployees.DataSource = view.ToTable();
        }

        // Фильтр: Имя
        private void SearchFname()
        {
            DataView view = EmployeesTable.DefaultView;

            view.RowFilter = string.Format("employee_fname like '%{0}%' ", textBoxSearch.Text);

            dataGridViewEmployees.DataSource = view.ToTable();
        }

        // Фильтр: Отчество
        private void SearchMname()
        {
            DataView view = EmployeesTable.DefaultView;

            view.RowFilter = string.Format("employee_mname like '%{0}%' ", textBoxSearch.Text);

            dataGridViewEmployees.DataSource = view.ToTable();
        }

        // Фильтр: Email
        private void SearchEmail()
        {
            DataView view = EmployeesTable.DefaultView;

            view.RowFilter = string.Format("Email like '%{0}%' ", textBoxSearch.Text);

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

            Program.DataEditEmployeeId.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[0].Value);
            Program.DataEditEmployeeLname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[1].Value);
            Program.DataEditEmployeeFname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[2].Value);
            Program.DataEditEmployeeMname.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[3].Value);
            Program.DataEditEmployeeEmail.Value = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[4].Value);

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

        // При клике на pictureBox скрывать панель
        private void pictureBoxFilters_Click(object sender, EventArgs e)
        {
            if (panelFilters.Visible == false)
                panelFilters.Visible = true;
            else
                panelFilters.Visible = false;
        }
    }
}
