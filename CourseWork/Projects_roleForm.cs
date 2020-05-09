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
    public partial class Projects_roleForm : Form
    {
        public Projects_roleForm()
        {
            InitializeComponent();
        }

        private void InsertDataGridViewProjects_role()
        {
            ConnectionDB connection = new ConnectionDB();

            connection.OpenConnect();

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Projects_role", connection.GetSqlConnect());

            DataTable table = new DataTable();
            sqlDA.Fill(table);

            dataGridViewProjects_role.DataSource = table;

            connection.CloseConnect();
        }

        private void Projects_roleForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewProjects_role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InsertDataGridViewProjects_role();
        }
    }
}
