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
    public partial class Posts_employeesFormEdit : MaterialForm
    {
        public Posts_employeesFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Posts_employeesFormEdit_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();
            SelectPostsComboBox();

            ComboBox_fk_employee.SelectedValue = Convert.ToInt32(Program.DataEditPostsEmployeesEmp.Value);     
            ComboBox_fk_post.SelectedValue = Convert.ToInt32(Program.DataEditPostsEmployeesPost.Value);

           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditRowPostsEmployees();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

        // Функция редактирования строки
        private void EditRowPostsEmployees()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditPosts_employees", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@fk_employee", SqlDbType.Int).Value = ComboBox_fk_employee.SelectedValue;
            command.Parameters.AddWithValue("@fk_post", SqlDbType.Int).Value = ComboBox_fk_post.SelectedValue;
            command.Parameters.AddWithValue("@id_post_emp", Convert.ToInt32(Program.DataEditPostsEmployeesId.Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }
    }
}
