using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork
{
    public partial class ProjectsForm : MaterialForm
    {
        public ProjectsForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectEmployeeComboBox();

            SelectDateProject();
        }

        private void SelectDateProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Projects", connection.GetSqlConnect());
            DataTable ProjectTable = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTable);

            dataGridViewProjects.DataSource = ProjectTable.DefaultView;

            connection.CloseConnect();
        }

        private void SelectEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());
            DataTable ProjectTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(ProjectTableComboBox);

            ComboBox_fk_leader.ValueMember = "Id";
            ComboBox_fk_leader.DisplayMember = "Employee";
            ComboBox_fk_leader.DataSource = ProjectTableComboBox;

            connection.CloseConnect();
        }

        private void AddRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("AddProjects", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.Add("@project_name", SqlDbType.NVarChar,100).Value = Program.DataAddProjectName.Value;
            command.Parameters.Add("@project_target", SqlDbType.NVarChar, 200).Value = Program.DataAddProjectTarget.Value;
            command.Parameters.Add("@date_start", SqlDbType.VarChar, 10).Value = Program.DataAddProjectStart.Value;
            command.Parameters.Add("@date_completion", SqlDbType.VarChar, 10).Value = Program.DataAddProjectCompletion.Value;
            command.Parameters.Add("@fk_leader", SqlDbType.Int).Value = Convert.ToInt32(Program.DataAddProjectLeader.Value);
            
            SqlParameter parameter = command.Parameters.Add("@id_project", SqlDbType.Int, 0, "id_project");

            parameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            SelectDateProject();

            connection.CloseConnect();
        }

        private void EditRowProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("EditProject", connection.GetSqlConnect());

            command.CommandType = CommandType.StoredProcedure;

            connection.OpenConnect();

            command.Parameters.AddWithValue("@project_name", SqlDbType.NVarChar).Value = Program.DataEditProjectName.Value;
            command.Parameters.AddWithValue("@project_target", SqlDbType.NVarChar).Value = Program.DataEditProjectTarget.Value;
            command.Parameters.AddWithValue("@date_start", SqlDbType.VarChar).Value = Program.DataEditProjectStart.Value;
            command.Parameters.AddWithValue("@date_completion", SqlDbType.VarChar).Value = Program.DataEditProjectCompletion.Value;
            command.Parameters.AddWithValue("@fk_leader", SqlDbType.Int).Value = Convert.ToInt32(Program.DataEditProjectLeader.Value);
            command.Parameters.AddWithValue("@id_project", Convert.ToInt32(dataGridViewProjects.CurrentRow.Cells["Column_id_project"].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateProject();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsFormAdd formAdd = new ProjectsFormAdd();

            formAdd.ShowDialog();

           AddRowProject();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectsFormEdit formEdit = new ProjectsFormEdit();

            formEdit.ShowDialog();

           // EditRowProject();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.CurrentRow.Cells["Column_id_project"].Value != DBNull.Value)
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionDB connection = new ConnectionDB();
                    SqlCommand command = new SqlCommand("DeleteProjects", connection.GetSqlConnect());

                    connection.OpenConnect();

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id_project", Convert.ToInt32(dataGridViewProjects.CurrentRow.Cells["Column_id_project"].Value));

                    command.ExecuteNonQuery();

                    connection.CloseConnect();
                }
                else
                    return;
            else
            {
                MessageBox.Show("Вы не выбрали строку. Выберите строку и повторите удаление.");
                return;
            }

            SelectDateProject();
        }

        private void dataGridViewProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewProjects.Rows[e.RowIndex];

                Program.DataEditProjectName.Value = view.Cells[1].Value.ToString();
                Program.DataEditProjectTarget.Value = view.Cells[2].Value.ToString();
                Program.DataEditProjectStart.Value = view.Cells[3].Value.ToString();
                Program.DataEditProjectCompletion.Value = view.Cells[4].Value.ToString();
                Program.DataEditProjectLeader.Value = view.Cells[5].Value.ToString();

                ProjectsFormEdit formEdit = new ProjectsFormEdit();

                formEdit.ShowDialog();

                EditRowProject();
            }
        }
    }
}
