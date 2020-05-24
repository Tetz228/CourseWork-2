using System;
using System.Data;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

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

        // При загрузки формы
        private void Posts_employeesFormEdit_Load(object sender, EventArgs e)
        {
            SelectEmployeeComboBox();

            SelectPostsComboBox();

            int indexEmp = ComboBox_fk_employee.FindString(Values.PostsEmployeesEmployees);
            int indexPost = ComboBox_fk_post.FindString(Values.PostsEmployeesPost);

            ComboBox_fk_employee.SelectedIndex = indexEmp;
            ComboBox_fk_post.SelectedIndex = indexPost;
        }

        // Сохранение изменений в бд
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditRowPostsEmployees();

            this.Close();
        }

        // При нажатии закрыть форму
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
            command.Parameters.AddWithValue("@id_post_emp", Values.PostsEmployeesId);

            command.ExecuteNonQuery();

            connection.CloseConnect();
        }

        // Скрывать Label`ы при выборе значения
        private void ComboBox_fk_employee_SelectedValueChanged(object sender, EventArgs e)
        {
            labelEmployee.Hide();
        }

        private void ComboBox_fk_post_SelectedValueChanged(object sender, EventArgs e)
        {
            labelPost.Hide();
        }
    }
}
