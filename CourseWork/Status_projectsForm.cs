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
    public partial class Status_projectsForm : Form
    {
        public Status_projectsForm()
        {
            InitializeComponent();
            this.dataGridViewStatus_projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        void InsertDataGridViewStatus_projects()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Status_projects", connection.GetSqlConnect());

            DataTable table = new DataTable();
            sqlDA.Fill(table);

            dataGridViewStatus_projects.DataSource = table;

            connection.CloseConnect();
        }

        private void Status_projects_Load(object sender, EventArgs e)
        {
            this.dataGridViewStatus_projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InsertDataGridViewStatus_projects();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
