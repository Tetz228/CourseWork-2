using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Posts_employeesFormAdd : MaterialForm
    {
        public Posts_employeesFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Posts_employeesFormAdd_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();
            SelectPostsComboBox();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckComboBox())
                return;
            else
            {
                AddRowPosts_employees();

                this.Close();
            } 
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Заполнение ComboBox`а "Сотрудник"
        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, " +
                "CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee " +
                "FROM Employees", connection.GetSqlConnect());
            DataTable EmployeeTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(EmployeeTableComboBox);

            ComboBox_fk_employee.ValueMember = "Id";
            ComboBox_fk_employee.DisplayMember = "Employee";

            DataRow row = EmployeeTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Сотрудник";
            EmployeeTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_employee.DataSource = EmployeeTableComboBox;

            connection.CloseConnect();
        }

        // Заполнение ComboBox`а "Должность"
        private void SelectPostsComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_post AS Id, " +
                "post_name AS Post " +
                "FROM Posts", connection.GetSqlConnect());
            DataTable PostsTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(PostsTableComboBox);

            ComboBox_fk_post.ValueMember = "Id";
            ComboBox_fk_post.DisplayMember = "Post";

            DataRow row = PostsTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Должность";
            PostsTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_post.DataSource = PostsTableComboBox;

            connection.CloseConnect();
        }

        private bool CheckComboBox()
        {
            int check = 0;

            if (ComboBox_fk_employee.Text == "Сотрудник")
            {
                labelEmployee.Show();

                check = 1;
            }
            if (ComboBox_fk_post.Text == "Должность")
            {
                labelPost.Show();

                check = 1;
            }

            if (check == 1)
                return false;
            else
                return true;
        }

        // Функция добавления строки
        private void AddRowPosts_employees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddPosts_employees", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@fk_employee", SqlDbType.Int).Value = ComboBox_fk_employee.SelectedValue;
            command.Parameters.AddWithValue("@fk_post", SqlDbType.Int).Value = ComboBox_fk_post.SelectedValue;

            SqlParameter parameter = command.Parameters.AddWithValue("@id_post_emp", SqlDbType.Int);

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
        
            connection.CloseConnect();
        }
    }
}
