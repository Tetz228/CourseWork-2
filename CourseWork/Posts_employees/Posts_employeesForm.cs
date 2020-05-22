using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class Posts_employeesForm : MaterialForm
    {
        DataTable PostsEmployeesTable = new DataTable();

        public Posts_employeesForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewPostsEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            if (Program.DataAuth.Role_user == 2)
                MainToolStripMenuItem.Visible = false;
        }

        // При загрузки формы
        private void PostsEmployeesForm_Load(object sender, EventArgs e)
        {
            SelectDatePostsEmployees();

            radioButtonEmployee.Checked = true;
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDatePostsEmployees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectDatePostsEmployees", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            PostsEmployeesTable = new DataTable();

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);
            
            connection.OpenConnect();

            sqlDA.Fill(PostsEmployeesTable);

            dataGridViewPostsEmployees.DataSource = PostsEmployeesTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string emp = "Employee like '%{0}%' ";
            string post = "Post like '%{0}%' ";

            if (radioButtonEmployee.Checked)
                Search(emp);
            if(radioButtonPost.Checked)
                Search(post);
        }

        // Функция поиска
        private void Search(string f)
        {
            DataView view = PostsEmployeesTable.DefaultView;

            view.RowFilter = string.Format(f, textBoxSearch.Text);

            dataGridViewPostsEmployees.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowPostsEmployees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeletePostsEmployees", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_post_emp", Convert.ToInt32(dataGridViewPostsEmployees.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDatePostsEmployees();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posts_employeesFormAdd formAdd = new Posts_employeesFormAdd();

            formAdd.ShowDialog();

            SelectDatePostsEmployees();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewPostsEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
                if (e.KeyCode == Keys.Insert)
                {
                    Posts_employeesFormAdd formAdd = new Posts_employeesFormAdd();

                    formAdd.ShowDialog();

                    SelectDatePostsEmployees();
                }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posts_employeesFormEdit formEdit = new Posts_employeesFormEdit();

            Program.DataPostsEmployees.Id = Convert.ToInt32(dataGridViewPostsEmployees.CurrentRow.Cells[0].Value);
            Program.DataPostsEmployees.Employees = Convert.ToString(dataGridViewPostsEmployees.CurrentRow.Cells[1].Value);
            Program.DataPostsEmployees.Post = Convert.ToString(dataGridViewPostsEmployees.CurrentRow.Cells[2].Value);
            
            formEdit.ShowDialog();

            SelectDatePostsEmployees();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewPostsEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
                if (e.RowIndex != -1)
                {
                    DataGridViewRow view = dataGridViewPostsEmployees.Rows[e.RowIndex];

                    Program.DataPostsEmployees.Id = Convert.ToInt32(view.Cells[0].Value);
                    Program.DataPostsEmployees.Employees = view.Cells[1].Value.ToString();
                    Program.DataPostsEmployees.Post = view.Cells[2].Value.ToString();

                    Posts_employeesFormEdit formEdit = new Posts_employeesFormEdit();

                    formEdit.ShowDialog();

                    SelectDatePostsEmployees();
                }  
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowPostsEmployees();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewPostsEmployees_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DeleteRowPostsEmployees();

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
        private void radioButtonEmployee_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonPost_Click(object sender, EventArgs e)
        { 
            panelFilters.Visible = false;
        }
    }
}
