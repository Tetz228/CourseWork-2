﻿using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using CourseWork.Main;

namespace CourseWork.History_task
{
    public partial class History_taskForm : MaterialForm
    {
        DataTable HistoryTable = new DataTable();

        public History_taskForm()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            this.dataGridViewHistory_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            if (Values.AuthRole_user == 2)
                MainToolStripMenuItem.Visible = false;
        }

        // При загрузки формы
        private void History_taskForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewHistory_task.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            radioButtonTask.Checked = true;

            SelectDateHistory_task();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDateHistory_task()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("SelectDateHistory_take", connection.GetSqlConnect());
            HistoryTable = new DataTable();

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDA = new SqlDataAdapter(command);

            connection.OpenConnect();

            sqlDA.Fill(HistoryTable);

            dataGridViewHistory_task.DataSource = HistoryTable.DefaultView;

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
        private void Search(string f)
        {
            DataView view = HistoryTable.DefaultView;

            view.RowFilter = string.Format(f, textBoxSearch.Text);

            dataGridViewHistory_task.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowHistoryTask()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeleteHistoryTask", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_history_task", Convert.ToInt32(dataGridViewHistory_task.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDateHistory_task();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_taskFormAdd formAdd = new History_taskFormAdd();

            formAdd.ShowDialog();

            SelectDateHistory_task();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewHistory_task_KeyDown(object sender, KeyEventArgs e)
        {
            if (Values.AuthRole_user != 2)
            {
                if (e.KeyCode == Keys.Insert)
                {
                    History_taskFormAdd formAdd = new History_taskFormAdd();

                    formAdd.ShowDialog();

                    SelectDateHistory_task();
                }
            }  
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_taskFormEdit formEdit = new History_taskFormEdit();

            Values.HistoryTaskId = Convert.ToInt32(dataGridViewHistory_task.CurrentRow.Cells[0].Value);
            Values.HistoryTaskName = Convert.ToString(dataGridViewHistory_task.CurrentRow.Cells[1].Value);
            Values.HistoryTaskProject = Convert.ToString(dataGridViewHistory_task.CurrentRow.Cells[2].Value);
            Values.HistoryTaskStatus = Convert.ToString(dataGridViewHistory_task.CurrentRow.Cells[3].Value);
            Values.HistoryTaskDate = Convert.ToString(dataGridViewHistory_task.CurrentRow.Cells[4].Value);

            formEdit.ShowDialog();

            SelectDateHistory_task();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewHistory_task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Values.AuthRole_user != 2)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow view = dataGridViewHistory_task.Rows[e.RowIndex];

                    Values.HistoryTaskId = Convert.ToInt32(view.Cells[0].Value);
                    Values.HistoryTaskName = view.Cells[1].Value.ToString();
                    Values.HistoryTaskProject = view.Cells[2].Value.ToString();
                    Values.HistoryTaskStatus = view.Cells[3].Value.ToString();
                    Values.HistoryTaskDate = view.Cells[4].Value.ToString();

                    History_taskFormEdit formEdit = new History_taskFormEdit();

                    formEdit.ShowDialog();

                    SelectDateHistory_task();
                }
            }  
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowHistoryTask();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewHistory_task_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (Values.AuthRole_user != 2)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DeleteRowHistoryTask();

                e.Cancel = true;
            }
            else
                e.Cancel = true;
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
