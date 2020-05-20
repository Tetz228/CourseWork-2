namespace CourseWork
{
    partial class History_projectsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHistory_projects = new System.Windows.Forms.DataGridView();
            this.Column_id_history_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_status_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_history_date_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripHistory_projects = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.radioButtonStatus = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonProject = new MaterialSkin.Controls.MaterialRadioButton();
            this.pictureBoxFilters = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory_projects)).BeginInit();
            this.menuStripHistory_projects.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistory_projects
            // 
            this.dataGridViewHistory_projects.AllowUserToAddRows = false;
            this.dataGridViewHistory_projects.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewHistory_projects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistory_projects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory_projects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewHistory_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewHistory_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_history_project,
            this.ComboBox_fk_project,
            this.ComboBox_fk_status_project,
            this.Column_history_date_project});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistory_projects.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewHistory_projects.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewHistory_projects.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewHistory_projects.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHistory_projects.MultiSelect = false;
            this.dataGridViewHistory_projects.Name = "dataGridViewHistory_projects";
            this.dataGridViewHistory_projects.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory_projects.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewHistory_projects.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewHistory_projects.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewHistory_projects.TabIndex = 0;
            this.dataGridViewHistory_projects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_projects_CellDoubleClick);
            this.dataGridViewHistory_projects.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewHistory_projects_UserDeletingRow);
            this.dataGridViewHistory_projects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewHistory_projects_KeyDown);
            // 
            // Column_id_history_project
            // 
            this.Column_id_history_project.DataPropertyName = "Id";
            this.Column_id_history_project.HeaderText = "Id";
            this.Column_id_history_project.Name = "Column_id_history_project";
            this.Column_id_history_project.ReadOnly = true;
            this.Column_id_history_project.Visible = false;
            // 
            // ComboBox_fk_project
            // 
            this.ComboBox_fk_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_project.DataPropertyName = "Project";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_project.DefaultCellStyle = dataGridViewCellStyle9;
            this.ComboBox_fk_project.HeaderText = "Проект";
            this.ComboBox_fk_project.Name = "ComboBox_fk_project";
            this.ComboBox_fk_project.ReadOnly = true;
            this.ComboBox_fk_project.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboBox_fk_project.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ComboBox_fk_status_project
            // 
            this.ComboBox_fk_status_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_status_project.DataPropertyName = "Status";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_status_project.DefaultCellStyle = dataGridViewCellStyle10;
            this.ComboBox_fk_status_project.HeaderText = "Статус проекта";
            this.ComboBox_fk_status_project.Name = "ComboBox_fk_status_project";
            this.ComboBox_fk_status_project.ReadOnly = true;
            this.ComboBox_fk_status_project.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboBox_fk_status_project.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_history_date_project
            // 
            this.Column_history_date_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_history_date_project.DataPropertyName = "Date";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle11.NullValue = "Не указана";
            this.Column_history_date_project.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column_history_date_project.HeaderText = "Дата";
            this.Column_history_date_project.Name = "Column_history_date_project";
            this.Column_history_date_project.ReadOnly = true;
            this.Column_history_date_project.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_history_date_project.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStripHistory_projects
            // 
            this.menuStripHistory_projects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripHistory_projects.Location = new System.Drawing.Point(0, 0);
            this.menuStripHistory_projects.Name = "menuStripHistory_projects";
            this.menuStripHistory_projects.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripHistory_projects.Size = new System.Drawing.Size(1037, 24);
            this.menuStripHistory_projects.TabIndex = 9;
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
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.radioButtonStatus);
            this.panelFilters.Controls.Add(this.radioButtonProject);
            this.panelFilters.Location = new System.Drawing.Point(912, 63);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(126, 62);
            this.panelFilters.TabIndex = 19;
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
            this.radioButtonStatus.Click += new System.EventHandler(this.radioButtonStatus_Click);
            // 
            // radioButtonProject
            // 
            this.radioButtonProject.AutoSize = true;
            this.radioButtonProject.Depth = 0;
            this.radioButtonProject.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonProject.Location = new System.Drawing.Point(0, 0);
            this.radioButtonProject.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonProject.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonProject.Name = "radioButtonProject";
            this.radioButtonProject.Ripple = true;
            this.radioButtonProject.Size = new System.Drawing.Size(76, 30);
            this.radioButtonProject.TabIndex = 17;
            this.radioButtonProject.TabStop = true;
            this.radioButtonProject.Text = "Проект";
            this.radioButtonProject.UseVisualStyleBackColor = true;
            this.radioButtonProject.Click += new System.EventHandler(this.radioButtonProject_Click);
            // 
            // pictureBoxFilters
            // 
            this.pictureBoxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilters.Image = global::CourseWork.Properties.Resources.Filters;
            this.pictureBoxFilters.Location = new System.Drawing.Point(1007, 31);
            this.pictureBoxFilters.Name = "pictureBoxFilters";
            this.pictureBoxFilters.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxFilters.TabIndex = 18;
            this.pictureBoxFilters.TabStop = false;
            this.pictureBoxFilters.Click += new System.EventHandler(this.pictureBoxFilters_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "Поиск";
            this.textBoxSearch.Location = new System.Drawing.Point(739, 32);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(262, 23);
            this.textBoxSearch.TabIndex = 17;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // History_projectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.pictureBoxFilters);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStripHistory_projects);
            this.Controls.Add(this.dataGridViewHistory_projects);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "History_projectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "История проектов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.History_projectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory_projects)).EndInit();
            this.menuStripHistory_projects.ResumeLayout(false);
            this.menuStripHistory_projects.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory_projects;
        private System.Windows.Forms.MenuStrip menuStripHistory_projects;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_history_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComboBox_fk_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComboBox_fk_status_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_history_date_project;
        private System.Windows.Forms.Panel panelFilters;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonStatus;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonProject;
        private System.Windows.Forms.PictureBox pictureBoxFilters;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
    }
}