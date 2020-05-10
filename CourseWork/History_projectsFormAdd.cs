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
    public partial class History_projectsFormAdd : MaterialForm
    {
        public History_projectsFormAdd()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void History_projectsFormAdd_Load(object sender, EventArgs e)
        {
            SelectProjectComboBox();

            SelectStatusComboBox();
        }

        private void SelectProjectComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_project AS Id, project_name AS Project FROM Projects", connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_project.ValueMember = "Id";
            ComboBox_fk_project.DisplayMember = "Project";

            DataRow row = HistoryTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Проект";
            HistoryTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        private void SelectStatusComboBox()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_status_project AS Id, status_name_project AS Status FROM Status_projects", connection.GetSqlConnect());
            DataTable HistoryTableComboBox = new DataTable();

            connection.OpenConnect();

            sqlDA.Fill(HistoryTableComboBox);

            ComboBox_fk_status_project.ValueMember = "Id";
            ComboBox_fk_status_project.DisplayMember = "Status";

            DataRow row = HistoryTableComboBox.NewRow();
            row[0] = 0;
            row[1] = "Статус";
            HistoryTableComboBox.Rows.InsertAt(row, 0);

            ComboBox_fk_status_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Program.DataAddHistoryProject.Value = ComboBox_fk_project.SelectedValue.ToString();
            Program.DataAddHistoryStatus.Value = ComboBox_fk_status_project.SelectedValue.ToString();
            Program.DataAddHistoryDate.Value = textBox_History_date_project.Text;

            this.Close();
        }
    }
}
