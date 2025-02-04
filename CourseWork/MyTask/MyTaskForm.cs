﻿using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

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
            this.dataGridViewMy_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDateHistory_task();

            radioButtonTask.Checked = true;
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateHistory_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectDateMy_take", connection.GetSqlConnect());
            HistoryTable = new DataTable();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_emp", Values.AuthIdUser);

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);

            connection.OpenConnect();

            sqlDA.Fill(HistoryTable);

            dataGridViewMy_task.DataSource = HistoryTable.DefaultView;

            connection.CloseConnect();
        }

        // При вводе в текстовое поле
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string task = "Task like '%{0}%' ";
            string project = "Project like '%{0}%' ";
            string status = "Status like '%{0}%' ";

            if (radioButtonTask.Checked)
                Search(task);
            if (radioButtonProject.Checked)
                Search(project);
            if (radioButtonStatus.Checked)
                Search(status);
        }

        // Функция по поиску
        private void Search(string format)
        {
            DataView view = HistoryTable.DefaultView;

            view.RowFilter = string.Format(format, textBoxSearch.Text);

            dataGridViewMy_task.DataSource = view.ToTable();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Values.MyTaskId = Convert.ToInt32(dataGridViewMy_task.CurrentRow.Cells[0].Value);
            Values.MyTaskStatus = Convert.ToString(dataGridViewMy_task.CurrentRow.Cells[3].Value);
            Values.MyTaskDate = Convert.ToString(dataGridViewMy_task.CurrentRow.Cells[4].Value);

            MyTaskFormEdit formEdit = new MyTaskFormEdit();

            formEdit.ShowDialog();

            SelectDateHistory_task(); 
        }

        private void dataGridViewHistory_task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewMy_task.Rows[e.RowIndex];

                Values.MyTaskId = Convert.ToInt32(view.Cells[0].Value);
                Values.MyTaskStatus = view.Cells[3].Value.ToString();
                Values.MyTaskDate = view.Cells[4].Value.ToString();

                MyTaskFormEdit formEdit = new MyTaskFormEdit();

                formEdit.ShowDialog();

                SelectDateHistory_task();
            }
        }

        // При клике на pictureBox скрывать / показывать панель
        private void pictureBoxFilters_Click(object sender, EventArgs e)
        {
            if (panelFilters.Visible == false)
                panelFilters.Visible = true;
            else
                panelFilters.Visible = false;
        }

        // При клике на переключатели скрывать панель
        private void radioButtonTask_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }

        private void radioButtonStatus_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = false;
        }
    }
}
