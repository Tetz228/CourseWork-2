namespace CourseWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.Column_id_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_project_target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date_completion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_leader = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStripProjects = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStripProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AllowUserToAddRows = false;
            this.dataGridViewProjects.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_project,
            this.Column_project_name,
            this.Column_project_target,
            this.Column_date_start,
            this.Column_date_completion,
            this.ComboBox_fk_leader});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProjects.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewProjects.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewProjects.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewProjects.MultiSelect = false;
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.ReadOnly = true;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.DimGray;
            this.dataGridViewProjects.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewProjects.Size = new System.Drawing.Size(1037, 513);
            this.dataGridViewProjects.TabIndex = 4;
            this.dataGridViewProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_CellDoubleClick);
            this.dataGridViewProjects.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewProjects_UserDeletingRow);
            this.dataGridViewProjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProjects_KeyDown);
            // 
            // Column_id_project
            // 
            this.Column_id_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_id_project.DataPropertyName = "id_project";
            this.Column_id_project.HeaderText = "Id";
            this.Column_id_project.Name = "Column_id_project";
            this.Column_id_project.ReadOnly = true;
            this.Column_id_project.Visible = false;
            // 
            // Column_project_name
            // 
            this.Column_project_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_project_name.DataPropertyName = "project_name";
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_project_name.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column_project_name.HeaderText = "Название проекта";
            this.Column_project_name.Name = "Column_project_name";
            this.Column_project_name.ReadOnly = true;
            // 
            // Column_project_target
            // 
            this.Column_project_target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_project_target.DataPropertyName = "project_target";
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.NullValue = "Не указана";
            this.Column_project_target.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column_project_target.HeaderText = "Цель проекта";
            this.Column_project_target.Name = "Column_project_target";
            this.Column_project_target.ReadOnly = true;
            // 
            // Column_date_start
            // 
            this.Column_date_start.DataPropertyName = "date_start";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle22.Format = "d";
            dataGridViewCellStyle22.NullValue = "Не указана";
            this.Column_date_start.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column_date_start.HeaderText = "Дата начала";
            this.Column_date_start.Name = "Column_date_start";
            this.Column_date_start.ReadOnly = true;
            this.Column_date_start.Width = 90;
            // 
            // Column_date_completion
            // 
            this.Column_date_completion.DataPropertyName = "date_completion";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle23.Format = "d";
            dataGridViewCellStyle23.NullValue = "Не указана";
            this.Column_date_completion.DefaultCellStyle = dataGridViewCellStyle23;
            this.Column_date_completion.HeaderText = "Дата завершения";
            this.Column_date_completion.Name = "Column_date_completion";
            this.Column_date_completion.ReadOnly = true;
            this.Column_date_completion.Width = 105;
            // 
            // ComboBox_fk_leader
            // 
            this.ComboBox_fk_leader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_leader.DataPropertyName = "fk_leader";
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_leader.DefaultCellStyle = dataGridViewCellStyle24;
            this.ComboBox_fk_leader.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_leader.HeaderText = "Руководитель";
            this.ComboBox_fk_leader.Name = "ComboBox_fk_leader";
            this.ComboBox_fk_leader.ReadOnly = true;
            this.ComboBox_fk_leader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1037, 576);
            this.ControlBox = false;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_leader;
    }
}