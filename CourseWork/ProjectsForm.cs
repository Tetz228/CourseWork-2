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

namespace CourseWork
{
    public partial class ProjectsForm : Form
    {
        public ProjectsForm()
        {
            InitializeComponent();
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        void InsertEmployeeComboBox()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_employee AS Id, CONCAT(employee_lname, ' ', LEFT(employee_fname,1), '. ', IIF(employee_mname != 'Не указано', LEFT(employee_mname,1) + '. ', '- '), ' ', Email) AS Employee FROM Employees", connection.GetSqlConnect());

            DataTable table = new DataTable();
            sqlDA.Fill(table);

            ComboBox_fk_leader.ValueMember = "Id";
            ComboBox_fk_leader.DisplayMember = "Employee";
            ComboBox_fk_leader.DataSource = table;

            connection.CloseConnect();
        }

        void InsertDataGridViewStatus_projects()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Projects", connection.GetSqlConnect());

            DataTable table = new DataTable();
            sqlDA.Fill(table);

            dataGridViewProjects.DataSource = table;

            connection.CloseConnect();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InsertEmployeeComboBox();
            InsertDataGridViewStatus_projects();
        }

        private void dataGridViewProjects_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProjects.CurrentRow != null)
            {
                ConnectionDB connection = new ConnectionDB();

                connection.OpenConnect();

                SqlCommand command = new SqlCommand("InsertProjects", connection.GetSqlConnect());
                command.CommandType = CommandType.StoredProcedure;

                DataGridViewRow viewRow = dataGridViewProjects.CurrentRow;

                if (viewRow.Cells["Column_id_project"].Value == DBNull.Value)
                    command.Parameters.AddWithValue("@id_project", 0);
                else
                    command.Parameters.AddWithValue("@id_project", Convert.ToInt32(viewRow.Cells["Column_id_project"].Value));

                command.Parameters.AddWithValue("@project_name", viewRow.Cells["Column_project_name"].Value == DBNull.Value ? "" : viewRow.Cells["Column_project_name"].Value.ToString());
                command.Parameters.AddWithValue("@project_target", viewRow.Cells["Column_project_target"].Value == DBNull.Value ? "Не указано" : viewRow.Cells["Column_project_target"].Value.ToString());       
                command.Parameters.AddWithValue("@date_start", viewRow.Cells["Column_date_start"].Value == DBNull.Value ? "Не указано" : viewRow.Cells["Column_date_start"].Value.ToString());
                command.Parameters.AddWithValue("@date_completion", viewRow.Cells["Column_date_completion"].Value == DBNull.Value ? "Не указано" : viewRow.Cells["Column_date_completion"].Value.ToString());
                command.Parameters.AddWithValue("@fk_leader", Convert.ToInt32(viewRow.Cells["ComboBox_fk_leader"].Value == DBNull.Value ? "1" : viewRow.Cells["ComboBox_fk_leader"].Value.ToString()));
                command.ExecuteNonQuery();

                InsertEmployeeComboBox();

                //InsertDataGridViewStatus_projects();

                connection.CloseConnect();
            }
        }

        private void DeleteRow()
        {
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewProjects_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewProjects.CurrentRow.Cells["Column_id_project"].Value != DBNull.Value)
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionDB connection = new ConnectionDB();

                    connection.OpenConnect();

                    SqlCommand command = new SqlCommand("DeleteProjects", connection.GetSqlConnect());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_project", Convert.ToInt32(dataGridViewProjects.CurrentRow.Cells["Column_id_project"].Value));
                    command.ExecuteNonQuery();

                    //InsertDataGridViewStatus_projects();

                    connection.CloseConnect();
                }
                else
                    e.Cancel = true;
            else
                e.Cancel = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
