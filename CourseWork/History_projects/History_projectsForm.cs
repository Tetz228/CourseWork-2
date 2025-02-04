﻿using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

namespace CourseWork
{
    public partial class History_projectsForm : MaterialForm
    {
        DataTable HistoryTable = new DataTable();

        public History_projectsForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewHistory_projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            if (Values.AuthRole_user == 2)
                MainToolStripMenuItem.Visible = false;
        }

        // При загрузки формы
        private void History_projectsForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewHistory_projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateHistory_projects();

            radioButtonProject.Checked = true;
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateHistory_projects()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectDateHistory_projects", connection.GetSqlConnect());
            HistoryTable = new DataTable();

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);
            
            connection.OpenConnect();

            sqlDA.Fill(HistoryTable);

            dataGridViewHistory_projects.DataSource = HistoryTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string project = "Project like '%{0}%' ";
            string status = "Status like '%{0}%' ";

            if (radioButtonProject.Checked)
                Search(project);
            if (radioButtonStatus.Checked)
                Search(status);
        }

        // Функция по поиску
        private void Search(string f)
        {
            DataView view = HistoryTable.DefaultView;

            view.RowFilter = string.Format(f, textBoxSearch.Text);

            dataGridViewHistory_projects.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowHistoryProject()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteHistoryProjects", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_history_project", Convert.ToInt32(dataGridViewHistory_projects.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateHistory_projects();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_projectsFormAdd formAdd = new History_projectsFormAdd();

            formAdd.ShowDialog();
            
            SelectDateHistory_projects();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewHistory_projects_KeyDown(object sender, KeyEventArgs e)
        {
            if (Values.AuthRole_user != 2)
                if (e.KeyCode == Keys.Insert)
                {
                    History_projectsFormAdd formAdd = new History_projectsFormAdd();

                    formAdd.ShowDialog();

                    SelectDateHistory_projects();
                }       
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_projectsFormEdit formEdit = new History_projectsFormEdit();

            Values.HistoryProjectId = Convert.ToInt32(dataGridViewHistory_projects.CurrentRow.Cells[0].Value);
            Values.HistoryProjectName = Convert.ToString(dataGridViewHistory_projects.CurrentRow.Cells[1].Value);
            Values.HistoryProjectStatus = Convert.ToString(dataGridViewHistory_projects.CurrentRow.Cells[2].Value);
            Values.HistoryProjectDate = Convert.ToString(dataGridViewHistory_projects.CurrentRow.Cells[3].Value); 

            formEdit.ShowDialog();

            SelectDateHistory_projects();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewHistory_projects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Values.AuthRole_user != 2)
                if (e.RowIndex != -1)
                {
                    DataGridViewRow view = dataGridViewHistory_projects.Rows[e.RowIndex];

                    Values.HistoryProjectId = Convert.ToInt32(view.Cells[0].Value);
                    Values.HistoryProjectName = view.Cells[1].Value.ToString();
                    Values.HistoryProjectStatus = view.Cells[2].Value.ToString();
                    Values.HistoryProjectDate = view.Cells[3].Value.ToString();

                    History_projectsFormEdit formEdit = new History_projectsFormEdit();

                    formEdit.ShowDialog();

                    SelectDateHistory_projects();
                }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowHistoryProject();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewHistory_projects_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (Values.AuthRole_user != 2)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowHistoryProject();

               e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        // При клике на pictureBox скрывать панель
        private void pictureBoxFilters_Click(object sender, EventArgs e)
        {
            if (panelFilters.Visible == false)
                panelFilters.Visible = true;
            else
                panelFilters.Visible = false;
        }

        // При клике на переключатели скрывать панель
        private void radioButtonProject_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonStatus_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }
    }
}
