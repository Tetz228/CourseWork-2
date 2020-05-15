namespace CourseWork
{
    partial class Status_projectsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStatus_projects = new System.Windows.Forms.DataGridView();
            this.Column_id_status_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_status_name_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripStatus_projects = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus_projects)).BeginInit();
            this.menuStripStatus_projects.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStatus_projects
            // 
            this.dataGridViewStatus_projects.AllowUserToAddRows = false;
            this.dataGridViewStatus_projects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStatus_projects.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewStatus_projects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStatus_projects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStatus_projects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStatus_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatus_projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_status_project,
            this.Column_status_name_project});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStatus_projects.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStatus_projects.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewStatus_projects.Location = new System.Drawing.Point(0, 64);
            this.dataGridViewStatus_projects.MultiSelect = false;
            this.dataGridViewStatus_projects.Name = "dataGridViewStatus_projects";
            this.dataGridViewStatus_projects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStatus_projects.Size = new System.Drawing.Size(1037, 507);
            this.dataGridViewStatus_projects.TabIndex = 6;
            this.dataGridViewStatus_projects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStatus_projects_CellDoubleClick);
            this.dataGridViewStatus_projects.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewStatus_projects_UserDeletingRow);
            this.dataGridViewStatus_projects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewStatus_projects_KeyDown);
            // 
            // Column_id_status_project
            // 
            this.Column_id_status_project.DataPropertyName = "id_status_project";
            this.Column_id_status_project.HeaderText = "Id";
            this.Column_id_status_project.Name = "Column_id_status_project";
            this.Column_id_status_project.ReadOnly = true;
            this.Column_id_status_project.Visible = false;
            // 
            // Column_status_name_project
            // 
            this.Column_status_name_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_status_name_project.DataPropertyName = "status_name_project";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_status_name_project.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_status_name_project.HeaderText = "Название статуса";
            this.Column_status_name_project.MaxInputLength = 35;
            this.Column_status_name_project.Name = "Column_status_name_project";
            this.Column_status_name_project.ReadOnly = true;
            // 
            // menuStripStatus_projects
            // 
            this.menuStripStatus_projects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripStatus_projects.Location = new System.Drawing.Point(0, 0);
            this.menuStripStatus_projects.Name = "menuStripStatus_projects";
            this.menuStripStatus_projects.Size = new System.Drawing.Size(1037, 24);
            this.menuStripStatus_projects.TabIndex = 7;
            this.menuStripStatus_projects.Text = "menuStrip1";
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
            // Status_projectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 571);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewStatus_projects);
            this.Controls.Add(this.menuStripStatus_projects);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Status_projectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Статусы проектов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Status_projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus_projects)).EndInit();
            this.menuStripStatus_projects.ResumeLayout(false);
            this.menuStripStatus_projects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewStatus_projects;
        private System.Windows.Forms.MenuStrip menuStripStatus_projects;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_status_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_status_name_project;
    }
}