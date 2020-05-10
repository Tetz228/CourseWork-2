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
    public partial class History_projectsFormEdit : MaterialForm
    {
        public History_projectsFormEdit()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void History_projectsFormEdit_Load(object sender, EventArgs e)
        {
            SelectProjectComboBox();

            SelectStatusComboBox();

            ComboBox_fk_project.SelectedValue = Convert.ToInt32(Program.DataEditHistoryProject.Value);
            ComboBox_fk_status_project.SelectedValue = Convert.ToInt32(Program.DataEditHistoryStatus.Value);
            textBox_History_date_project.Text = Program.DataEditHistoryDate.Value;
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
         
            ComboBox_fk_status_project.DataSource = HistoryTableComboBox;

            connection.CloseConnect();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Program.DataEditHistoryProject.Value = ComboBox_fk_project.SelectedValue.ToString();
            Program.DataEditHistoryStatus.Value = ComboBox_fk_status_project.SelectedValue.ToString();
            Program.DataEditHistoryDate.Value = textBox_History_date_project.Text;
        }
    }
}
