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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHistory_projects = new System.Windows.Forms.DataGridView();
            this.Column_id_history_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_project = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ComboBox_fk_status_project = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_history_date_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripHistory_projects = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory_projects)).BeginInit();
            this.menuStripHistory_projects.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHistory_projects
            // 
            this.dataGridViewHistory_projects.AllowUserToAddRows = false;
            this.dataGridViewHistory_projects.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewHistory_projects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistory_projects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory_projects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistory_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewHistory_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_history_project,
            this.ComboBox_fk_project,
            this.ComboBox_fk_status_project,
            this.Column_history_date_project});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistory_projects.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewHistory_projects.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewHistory_projects.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewHistory_projects.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHistory_projects.MultiSelect = false;
            this.dataGridViewHistory_projects.Name = "dataGridViewHistory_projects";
            this.dataGridViewHistory_projects.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory_projects.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewHistory_projects.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewHistory_projects.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewHistory_projects.TabIndex = 0;
            this.dataGridViewHistory_projects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_projects_CellDoubleClick);
            this.dataGridViewHistory_projects.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewHistory_projects_UserDeletingRow);
            this.dataGridViewHistory_projects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewHistory_projects_KeyDown);
            // 
            // Column_id_history_project
            // 
            this.Column_id_history_project.DataPropertyName = "id_history_project";
            this.Column_id_history_project.HeaderText = "Id";
            this.Column_id_history_project.Name = "Column_id_history_project";
            this.Column_id_history_project.ReadOnly = true;
            this.Column_id_history_project.Visible = false;
            // 
            // ComboBox_fk_project
            // 
            this.ComboBox_fk_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_project.DataPropertyName = "fk_project";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_project.DefaultCellStyle = dataGridViewCellStyle2;
            this.ComboBox_fk_project.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_project.HeaderText = "Проект";
            this.ComboBox_fk_project.Name = "ComboBox_fk_project";
            this.ComboBox_fk_project.ReadOnly = true;
            // 
            // ComboBox_fk_status_project
            // 
            this.ComboBox_fk_status_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_status_project.DataPropertyName = "fk_status_project";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_status_project.DefaultCellStyle = dataGridViewCellStyle3;
            this.ComboBox_fk_status_project.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_status_project.HeaderText = "Статус проекта";
            this.ComboBox_fk_status_project.Name = "ComboBox_fk_status_project";
            this.ComboBox_fk_status_project.ReadOnly = true;
            // 
            // Column_history_date_project
            // 
            this.Column_history_date_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_history_date_project.DataPropertyName = "history_date_project";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle4.NullValue = "Не указана";
            this.Column_history_date_project.DefaultCellStyle = dataGridViewCellStyle4;
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
            // History_projectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_project;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_status_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_history_date_project;
    }
}