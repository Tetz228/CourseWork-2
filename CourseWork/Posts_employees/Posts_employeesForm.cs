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
    public partial class Posts_employeesForm : MaterialForm
    {
        public Posts_employeesForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewPostsEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        // При загрузки вызов функций добавление в базу, заполнения ComboBox`ов
        private void PostsEmployeesForm_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();

            SelectPostsComboBox();

            SelectDatePostsEmployees();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDatePostsEmployees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Posts_employees", connection.GetSqlConnect());
            DataTable PorstEmployeesTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(PorstEmployeesTable);

            dataGridViewPostsEmployees.DataSource = PorstEmployeesTable.DefaultView;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Сотрудник"
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());
            DataTable EmployeeTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(EmployeeTableComboBox);

            ComboBox_fk_employee.ValueMember = "Id";
            ComboBox_fk_employee.DisplayMember = "Employee";
            ComboBox_fk_employee.DataSource = EmployeeTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Должность"
        private void SelectPostsComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_post AS Id, post_name AS Post FROM Posts", connection.GetSqlConnect());
            DataTable PostsTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(PostsTableComboBox);

            ComboBox_fk_post.ValueMember = "Id";
            ComboBox_fk_post.DisplayMember = "Post";
            ComboBox_fk_post.DataSource = PostsTableComboBox;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowPostsEmployees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeletePostsEmployees", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_post_emp", Convert.ToInt32(dataGridViewPostsEmployees.CurrentRow.Cells["Column_id_post_emp"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDatePostsEmployees();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posts_employeesFormAdd formAdd = new Posts_employeesFormAdd();

            formAdd.ShowDialog();

            SelectDatePostsEmployees();
        }

        // При нажатии на Ins(Insert) на клавиатуре появляется форма добавления
        private void dataGridViewHistory_projects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Posts_employeesFormAdd formAdd = new Posts_employeesFormAdd();

                formAdd.ShowDialog();

                SelectDatePostsEmployees();
            }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения, после чего проверка класса и вызов функции редактирования строки
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posts_employeesFormEdit formEdit = new Posts_employeesFormEdit();

            Program.DataEditPostsEmployeesId.Value = Convert.ToString(dataGridViewPostsEmployees.CurrentRow.Cells["Column_id_post_emp"].Value);
            Program.DataEditPostsEmployeesEmp.Value = Convert.ToString(dataGridViewPostsEmployees.CurrentRow.Cells["ComboBox_fk_employee"].Value);
            Program.DataEditPostsEmployeesPost.Value = Convert.ToString(dataGridViewPostsEmployees.CurrentRow.Cells["ComboBox_fk_post"].Value);
            
            formEdit.ShowDialog();

            SelectDatePostsEmployees();
        }

        // Cобытие при 2-ом клике на ячейку позволяет провести редактирование
        private void dataGridViewPostsEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewPostsEmployees.Rows[e.RowIndex];

                Program.DataEditPostsEmployeesId.Value = view.Cells[0].Value.ToString();
                Program.DataEditPostsEmployeesEmp.Value = view.Cells[1].Value.ToString();
                Program.DataEditPostsEmployeesPost.Value = view.Cells[2].Value.ToString();

                Posts_employeesFormEdit formEdit = new Posts_employeesFormEdit();

                formEdit.ShowDialog();

                SelectDatePostsEmployees();
            }
        }

        // При клике на "Правка" -> "Удалить"
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowPostsEmployees();
            else
                return;
        }

        // При выделение строки и нажание на клавишу Del(Delete)
        private void dataGridViewPostsEmployees_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowPostsEmployees();

            e.Cancel = true;
        } 
    }
}
