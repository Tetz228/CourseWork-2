namespace CourseWork.MyTask
{
    partial class MyTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHistory_task = new System.Windows.Forms.DataGridView();
            this.Column_id_history_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_project_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_status_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_history_date_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.radioButtonStatus = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonTask = new MaterialSkin.Controls.MaterialRadioButton();
            this.pictureBoxFilters = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.menuStripHistory_projects = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory_task)).BeginInit();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).BeginInit();
            this.menuStripHistory_projects.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHistory_task
            // 
            this.dataGridViewHistory_task.AllowUserToAddRows = false;
            this.dataGridViewHistory_task.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewHistory_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistory_task.CausesValidation = false;
            this.dataGridViewHistory_task.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewHistory_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistory_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewHistory_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_history_task,
            this.ComboBox_fk_project_task,
            this.ComboBox_fk_status_task,
            this.Column_history_date_task});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistory_task.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewHistory_task.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewHistory_task.Location = new System.Drawing.Point(0, 62);
            this.dataGridViewHistory_task.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHistory_task.MultiSelect = false;
            this.dataGridViewHistory_task.Name = "dataGridViewHistory_task";
            this.dataGridViewHistory_task.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory_task.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewHistory_task.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewHistory_task.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewHistory_task.TabIndex = 2;
            // 
            // Column_id_history_task
            // 
            this.Column_id_history_task.DataPropertyName = "Id";
            this.Column_id_history_task.HeaderText = "Id";
            this.Column_id_history_task.Name = "Column_id_history_task";
            this.Column_id_history_task.ReadOnly = true;
            this.Column_id_history_task.Visible = false;
            // 
            // ComboBox_fk_project_task
            // 
            this.ComboBox_fk_project_task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_project_task.DataPropertyName = "Task";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_project_task.DefaultCellStyle = dataGridViewCellStyle2;
            this.ComboBox_fk_project_task.HeaderText = "Задача";
            this.ComboBox_fk_project_task.Name = "ComboBox_fk_project_task";
            this.ComboBox_fk_project_task.ReadOnly = true;
            this.ComboBox_fk_project_task.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboBox_fk_project_task.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ComboBox_fk_status_task
            // 
            this.ComboBox_fk_status_task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_status_task.DataPropertyName = "Status";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_status_task.DefaultCellStyle = dataGridViewCellStyle3;
            this.ComboBox_fk_status_task.HeaderText = "Статус задачи";
            this.ComboBox_fk_status_task.Name = "ComboBox_fk_status_task";
            this.ComboBox_fk_status_task.ReadOnly = true;
            this.ComboBox_fk_status_task.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboBox_fk_status_task.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_history_date_task
            // 
            this.Column_history_date_task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_history_date_task.DataPropertyName = "Date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle4.NullValue = "Не указана";
            this.Column_history_date_task.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_history_date_task.HeaderText = "Дата";
            this.Column_history_date_task.Name = "Column_history_date_task";
            this.Column_history_date_task.ReadOnly = true;
            this.Column_history_date_task.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_history_date_task.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.radioButtonStatus);
            this.panelFilters.Controls.Add(this.radioButtonTask);
            this.panelFilters.Location = new System.Drawing.Point(911, 61);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(126, 62);
            this.panelFilters.TabIndex = 26;
            this.panelFilters.Visible = false;
            // 
            // radioButtonStatus
            // 
            this.radioButtonStatus.AutoSize = true;
            this.radioButtonStatus.Depth = 0;
            this.radioButtonStatus.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonStatus.Location = new System.Drawing.Point(0, 30);
            this.radioButtonStatus.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonStatus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonStatus.Name = "radioButtonStatus";
            this.radioButtonStatus.Ripple = true;
            this.radioButtonStatus.Size = new System.Drawing.Size(73, 30);
            this.radioButtonStatus.TabIndex = 18;
            this.radioButtonStatus.TabStop = true;
            this.radioButtonStatus.Text = "Статус";
            this.radioButtonStatus.UseVisualStyleBackColor = true;
            // 
            // radioButtonTask
            // 
            this.radioButtonTask.AutoSize = true;
            this.radioButtonTask.Depth = 0;
            this.radioButtonTask.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonTask.Location = new System.Drawing.Point(0, 0);
            this.radioButtonTask.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonTask.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonTask.Name = "radioButtonTask";
            this.radioButtonTask.Ripple = true;
            this.radioButtonTask.Size = new System.Drawing.Size(76, 30);
            this.radioButtonTask.TabIndex = 17;
            this.radioButtonTask.TabStop = true;
            this.radioButtonTask.Text = "Задача";
            this.radioButtonTask.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFilters
            // 
            this.pictureBoxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilters.Image = global::CourseWork.Properties.Resources.Filters;
            this.pictureBoxFilters.Location = new System.Drawing.Point(1006, 29);
            this.pictureBoxFilters.Name = "pictureBoxFilters";
            this.pictureBoxFilters.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxFilters.TabIndex = 25;
            this.pictureBoxFilters.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "Поиск";
            this.textBoxSearch.Location = new System.Drawing.Point(738, 30);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(262, 23);
            this.textBoxSearch.TabIndex = 24;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            // 
            // menuStripHistory_projects
            // 
            this.menuStripHistory_projects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripHistory_projects.Location = new System.Drawing.Point(0, 0);
            this.menuStripHistory_projects.Name = "menuStripHistory_projects";
            this.menuStripHistory_projects.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripHistory_projects.Size = new System.Drawing.Size(1037, 24);
            this.menuStripHistory_projects.TabIndex = 23;
            this.menuStripHistory_projects.Text = "menuStrip1";
            // 
            // MainToolStripMenuItem
            // 
            this.MainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.MainToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
            this.MainToolStripMenuItem.Size = new System.Drawing.Size(66, 18);
            this.MainToolStripMenuItem.Text = "Правка";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.EditToolStripMenuItem.Text = "Изменить";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // MyTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.pictureBoxFilters);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStripHistory_projects);
            this.Controls.Add(this.dataGridViewHistory_task);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MyTaskForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Мои задачи";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MyTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory_task)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).EndInit();
            this.menuStripHistory_projects.ResumeLayout(false);
            this.menuStripHistory_projects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_history_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComboBox_fk_project_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComboBox_fk_status_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_history_date_task;
        private System.Windows.Forms.Panel panelFilters;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonStatus;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonTask;
        private System.Windows.Forms.PictureBox pictureBoxFilters;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        private System.Windows.Forms.MenuStrip menuStripHistory_projects;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}