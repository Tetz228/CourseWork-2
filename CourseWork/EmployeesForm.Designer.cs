﻿namespace CourseWork
{
    partial class EmployeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.Column_id_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_employee_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_employee_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_employee_mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripProjects_role = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.menuStripProjects_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_employee,
            this.Column_employee_lname,
            this.Column_employee_fname,
            this.Column_employee_mname,
            this.Column_Email});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewEmployees.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.DimGray;
            this.dataGridViewEmployees.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1038, 513);
            this.dataGridViewEmployees.TabIndex = 5;
            this.dataGridViewEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellDoubleClick);
            this.dataGridViewEmployees.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewEmployees_UserDeletingRow);
            this.dataGridViewEmployees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEmployees_KeyDown);
            // 
            // Column_id_employee
            // 
            this.Column_id_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_id_employee.DataPropertyName = "id_employee";
            this.Column_id_employee.HeaderText = "Id";
            this.Column_id_employee.Name = "Column_id_employee";
            this.Column_id_employee.ReadOnly = true;
            this.Column_id_employee.Visible = false;
            // 
            // Column_employee_lname
            // 
            this.Column_employee_lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_employee_lname.DataPropertyName = "employee_lname";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_employee_lname.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column_employee_lname.HeaderText = "Фамилия";
            this.Column_employee_lname.Name = "Column_employee_lname";
            this.Column_employee_lname.ReadOnly = true;
            // 
            // Column_employee_fname
            // 
            this.Column_employee_fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_employee_fname.DataPropertyName = "employee_fname";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.NullValue = "Не указана";
            this.Column_employee_fname.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column_employee_fname.HeaderText = "Имя";
            this.Column_employee_fname.Name = "Column_employee_fname";
            this.Column_employee_fname.ReadOnly = true;
            // 
            // Column_employee_mname
            // 
            this.Column_employee_mname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_employee_mname.DataPropertyName = "employee_mname";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = "Не указана";
            this.Column_employee_mname.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column_employee_mname.HeaderText = "Отчество";
            this.Column_employee_mname.Name = "Column_employee_mname";
            this.Column_employee_mname.ReadOnly = true;
            // 
            // Column_Email
            // 
            this.Column_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Email.DataPropertyName = "Email";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = "Не указана";
            this.Column_Email.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column_Email.HeaderText = "Email";
            this.Column_Email.Name = "Column_Email";
            this.Column_Email.ReadOnly = true;
            // 
            // menuStripProjects_role
            // 
            this.menuStripProjects_role.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripProjects_role.Location = new System.Drawing.Point(0, 0);
            this.menuStripProjects_role.Name = "menuStripProjects_role";
            this.menuStripProjects_role.Size = new System.Drawing.Size(1037, 24);
            this.menuStripProjects_role.TabIndex = 9;
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
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 576);
            this.ControlBox = false;
            this.Controls.Add(this.menuStripProjects_role);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EmployeesForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Список сотрудников";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.menuStripProjects_role.ResumeLayout(false);
            this.menuStripProjects_role.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_employee_lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_employee_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_employee_mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
        private System.Windows.Forms.MenuStrip menuStripProjects_role;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}