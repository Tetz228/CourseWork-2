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

namespace CourseWork.MyTask
{
    public partial class MyTaskForm : MaterialForm
    {
        DataTable HistoryTable = new DataTable();

        public MyTaskForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MyTaskForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewHistory_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateHistory_task();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateHistory_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectDateMyHistory_take", connection.GetSqlConnect());
            HistoryTable = new DataTable();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_emp", Program.DataAuth.IdUser);

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);

            connection.OpenConnect();

            sqlDA.Fill(HistoryTable);

            dataGridViewHistory_task.DataSource = HistoryTable.DefaultView;

            connection.CloseConnect();
        }
    }
}
