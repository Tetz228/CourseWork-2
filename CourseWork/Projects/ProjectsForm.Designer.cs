﻿namespace CourseWork
{
    partial class ProjectsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStripProjects = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column_id_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_project_target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date_completion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.radioButtonProject = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonLeader = new MaterialSkin.Controls.MaterialRadioButton();
            this.pictureBoxFilters = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radioButtonTarget = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonStart = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonCompletion = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStripProjects.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AllowUserToAddRows = false;
            this.dataGridViewProjects.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_project,
            this.Column_project_name,
            this.Column_project_target,
            this.Column_date_start,
            this.Column_date_completion,
            this.ComboBox_fk_leader});
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProjects.DefaultCellStyle = dataGridViewCellStyle61;
            this.dataGridViewProjects.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewProjects.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewProjects.MultiSelect = false;
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.ReadOnly = true;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle62;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.DimGray;
            this.dataGridViewProjects.RowsDefaultCellStyle = dataGridViewCellStyle63;
            this.dataGridViewProjects.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewProjects.TabIndex = 4;
            this.dataGridViewProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_CellDoubleClick);
            this.dataGridViewProjects.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewProjects_UserDeletingRow);
            this.dataGridViewProjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProjects_KeyDown);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.menuStripProjects);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1037, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1037, 24);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStripProjects
            // 
            this.menuStripProjects.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripProjects.Location = new System.Drawing.Point(0, 0);
            this.menuStripProjects.Name = "menuStripProjects";
            this.menuStripProjects.Size = new System.Drawing.Size(1037, 24);
            this.menuStripProjects.TabIndex = 5;
            this.menuStripProjects.Text = "menuStrip1";
            // 
            // MainToolStripMenuItem
            // 
            this.MainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.MainToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
            this.MainToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
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
            // Column_id_project
            // 
            this.Column_id_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_id_project.DataPropertyName = "Id";
            this.Column_id_project.HeaderText = "Id";
            this.Column_id_project.Name = "Column_id_project";
            this.Column_id_project.ReadOnly = true;
            this.Column_id_project.Visible = false;
            // 
            // Column_project_name
            // 
            this.Column_project_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_project_name.DataPropertyName = "Name";
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_project_name.DefaultCellStyle = dataGridViewCellStyle56;
            this.Column_project_name.HeaderText = "Название проекта";
            this.Column_project_name.Name = "Column_project_name";
            this.Column_project_name.ReadOnly = true;
            // 
            // Column_project_target
            // 
            this.Column_project_target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_project_target.DataPropertyName = "Target";
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle57.NullValue = "Не указана";
            this.Column_project_target.DefaultCellStyle = dataGridViewCellStyle57;
            this.Column_project_target.HeaderText = "Цель проекта";
            this.Column_project_target.Name = "Column_project_target";
            this.Column_project_target.ReadOnly = true;
            // 
            // Column_date_start
            // 
            this.Column_date_start.DataPropertyName = "Start";
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle58.Format = "d";
            dataGridViewCellStyle58.NullValue = "Не указана";
            this.Column_date_start.DefaultCellStyle = dataGridViewCellStyle58;
            this.Column_date_start.HeaderText = "Дата начала";
            this.Column_date_start.Name = "Column_date_start";
            this.Column_date_start.ReadOnly = true;
            this.Column_date_start.Width = 90;
            // 
            // Column_date_completion
            // 
            this.Column_date_completion.DataPropertyName = "Completion";
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle59.Format = "d";
            dataGridViewCellStyle59.NullValue = "Не указана";
            this.Column_date_completion.DefaultCellStyle = dataGridViewCellStyle59;
            this.Column_date_completion.HeaderText = "Дата завершения";
            this.Column_date_completion.Name = "Column_date_completion";
            this.Column_date_completion.ReadOnly = true;
            this.Column_date_completion.Width = 105;
            // 
            // ComboBox_fk_leader
            // 
            this.ComboBox_fk_leader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_leader.DataPropertyName = "Employee";
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_leader.DefaultCellStyle = dataGridViewCellStyle60;
            this.ComboBox_fk_leader.HeaderText = "Руководитель";
            this.ComboBox_fk_leader.Name = "ComboBox_fk_leader";
            this.ComboBox_fk_leader.ReadOnly = true;
            this.ComboBox_fk_leader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboBox_fk_leader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.radioButtonCompletion);
            this.panelFilters.Controls.Add(this.radioButtonStart);
            this.panelFilters.Controls.Add(this.radioButtonTarget);
            this.panelFilters.Controls.Add(this.radioButtonProject);
            this.panelFilters.Controls.Add(this.radioButtonLeader);
            this.panelFilters.Location = new System.Drawing.Point(885, 62);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(154, 152);
            this.panelFilters.TabIndex = 19;
            this.panelFilters.Visible = false;
            // 
            // radioButtonProject
            // 
            this.radioButtonProject.AutoSize = true;
            this.radioButtonProject.Depth = 0;
            this.radioButtonProject.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonProject.Location = new System.Drawing.Point(0, 1);
            this.radioButtonProject.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonProject.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonProject.Name = "radioButtonProject";
            this.radioButtonProject.Ripple = true;
            this.radioButtonProject.Size = new System.Drawing.Size(76, 30);
            this.radioButtonProject.TabIndex = 18;
            this.radioButtonProject.TabStop = true;
            this.radioButtonProject.Text = "Проект";
            this.radioButtonProject.UseVisualStyleBackColor = true;
            this.radioButtonProject.Click += new System.EventHandler(this.radioButtonProject_Click);
            // 
            // radioButtonLeader
            // 
            this.radioButtonLeader.AutoSize = true;
            this.radioButtonLeader.Depth = 0;
            this.radioButtonLeader.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonLeader.Location = new System.Drawing.Point(0, 121);
            this.radioButtonLeader.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonLeader.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonLeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonLeader.Name = "radioButtonLeader";
            this.radioButtonLeader.Ripple = true;
            this.radioButtonLeader.Size = new System.Drawing.Size(121, 30);
            this.radioButtonLeader.TabIndex = 17;
            this.radioButtonLeader.TabStop = true;
            this.radioButtonLeader.Text = "Руководитель";
            this.radioButtonLeader.UseVisualStyleBackColor = true;
            this.radioButtonLeader.Click += new System.EventHandler(this.radioButtonLeader_Click);
            // 
            // pictureBoxFilters
            // 
            this.pictureBoxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilters.Image = global::CourseWork.Properties.Resources.Filters;
            this.pictureBoxFilters.Location = new System.Drawing.Point(1008, 30);
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
            this.textBoxSearch.Location = new System.Drawing.Point(740, 31);
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
            // radioButtonTarget
            // 
            this.radioButtonTarget.AutoSize = true;
            this.radioButtonTarget.Depth = 0;
            this.radioButtonTarget.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonTarget.Location = new System.Drawing.Point(0, 31);
            this.radioButtonTarget.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonTarget.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonTarget.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonTarget.Name = "radioButtonTarget";
            this.radioButtonTarget.Ripple = true;
            this.radioButtonTarget.Size = new System.Drawing.Size(62, 30);
            this.radioButtonTarget.TabIndex = 19;
            this.radioButtonTarget.TabStop = true;
            this.radioButtonTarget.Text = "Цель";
            this.radioButtonTarget.UseVisualStyleBackColor = true;
            this.radioButtonTarget.Click += new System.EventHandler(this.radioButtonTarget_Click);
            // 
            // radioButtonStart
            // 
            this.radioButtonStart.AutoSize = true;
            this.radioButtonStart.Depth = 0;
            this.radioButtonStart.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonStart.Location = new System.Drawing.Point(0, 61);
            this.radioButtonStart.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonStart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonStart.Name = "radioButtonStart";
            this.radioButtonStart.Ripple = true;
            this.radioButtonStart.Size = new System.Drawing.Size(110, 30);
            this.radioButtonStart.TabIndex = 20;
            this.radioButtonStart.TabStop = true;
            this.radioButtonStart.Text = "Дата начала";
            this.radioButtonStart.UseVisualStyleBackColor = true;
            this.radioButtonStart.Visible = false;
            // 
            // radioButtonCompletion
            // 
            this.radioButtonCompletion.AutoSize = true;
            this.radioButtonCompletion.Depth = 0;
            this.radioButtonCompletion.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonCompletion.Location = new System.Drawing.Point(0, 91);
            this.radioButtonCompletion.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonCompletion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonCompletion.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonCompletion.Name = "radioButtonCompletion";
            this.radioButtonCompletion.Ripple = true;
            this.radioButtonCompletion.Size = new System.Drawing.Size(144, 30);
            this.radioButtonCompletion.TabIndex = 21;
            this.radioButtonCompletion.TabStop = true;
            this.radioButtonCompletion.Text = "Дата завершения";
            this.radioButtonCompletion.UseVisualStyleBackColor = true;
            this.radioButtonCompletion.Visible = false;
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.pictureBoxFilters);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.dataGridViewProjects);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStripProjects;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1037, 527);
            this.Name = "ProjectsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Список проектов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStripProjects.ResumeLayout(false);
            this.menuStripProjects.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_project_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_project_target;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date_completion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComboBox_fk_leader;
        private System.Windows.Forms.Panel panelFilters;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonCompletion;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonStart;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonTarget;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonProject;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonLeader;
        private System.Windows.Forms.PictureBox pictureBoxFilters;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
    }
}