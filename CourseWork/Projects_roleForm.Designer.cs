﻿namespace CourseWork
{
    partial class Projects_roleForm
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
            this.dataGridViewProjects_role = new System.Windows.Forms.DataGridView();
            this.menuStripProjects_role = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column_id_project_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_project_role_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects_role)).BeginInit();
            this.menuStripProjects_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProjects_role
            // 
            this.dataGridViewProjects_role.AllowUserToAddRows = false;
            this.dataGridViewProjects_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects_role.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_project_role,
            this.Column_project_role_name});
            this.dataGridViewProjects_role.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewProjects_role.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProjects_role.Name = "dataGridViewProjects_role";
            this.dataGridViewProjects_role.Size = new System.Drawing.Size(1041, 530);
            this.dataGridViewProjects_role.TabIndex = 7;
            this.dataGridViewProjects_role.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_role_CellDoubleClick);
            // 
            // menuStripProjects_role
            // 
            this.menuStripProjects_role.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripProjects_role.Location = new System.Drawing.Point(0, 0);
            this.menuStripProjects_role.Name = "menuStripProjects_role";
            this.menuStripProjects_role.Size = new System.Drawing.Size(1041, 24);
            this.menuStripProjects_role.TabIndex = 8;
            this.menuStripProjects_role.Text = "menuStrip1";
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
            // Column_id_project_role
            // 
            this.Column_id_project_role.DataPropertyName = "id_project_role";
            this.Column_id_project_role.HeaderText = "Id";
            this.Column_id_project_role.Name = "Column_id_project_role";
            this.Column_id_project_role.Visible = false;
            // 
            // Column_project_role_name
            // 
            this.Column_project_role_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_project_role_name.DataPropertyName = "project_role_name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_project_role_name.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_project_role_name.HeaderText = "Название роли";
            this.Column_project_role_name.MaxInputLength = 50;
            this.Column_project_role_name.Name = "Column_project_role_name";
            // 
            // Projects_roleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 593);
            this.ControlBox = false;
            this.Controls.Add(this.menuStripProjects_role);
            this.Controls.Add(this.dataGridViewProjects_role);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1041, 593);
            this.Name = "Projects_roleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Роли в проектах";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Projects_roleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects_role)).EndInit();
            this.menuStripProjects_role.ResumeLayout(false);
            this.menuStripProjects_role.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjects_role;
        private System.Windows.Forms.MenuStrip menuStripProjects_role;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_project_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_project_role_name;
    }
}