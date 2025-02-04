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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.Column_id_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_employee_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_employee_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_employee_mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripEmployees = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.radioButtonEmail = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonMname = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonFname = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonLname = new MaterialSkin.Controls.MaterialRadioButton();
            this.pictureBoxFilters = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.menuStripEmployees.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_employee,
            this.Column_employee_lname,
            this.Column_employee_fname,
            this.Column_employee_mname,
            this.Column_Email});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewEmployees.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.DimGray;
            this.dataGridViewEmployees.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1037, 500);
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
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_employee_lname.DefaultCellStyle = dataGridViewCellStyle26;
            this.Column_employee_lname.HeaderText = "Фамилия";
            this.Column_employee_lname.Name = "Column_employee_lname";
            this.Column_employee_lname.ReadOnly = true;
            // 
            // Column_employee_fname
            // 
            this.Column_employee_fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_employee_fname.DataPropertyName = "employee_fname";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_employee_fname.DefaultCellStyle = dataGridViewCellStyle27;
            this.Column_employee_fname.HeaderText = "Имя";
            this.Column_employee_fname.Name = "Column_employee_fname";
            this.Column_employee_fname.ReadOnly = true;
            // 
            // Column_employee_mname
            // 
            this.Column_employee_mname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_employee_mname.DataPropertyName = "employee_mname";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle28.Format = "d";
            dataGridViewCellStyle28.NullValue = "Не указано";
            this.Column_employee_mname.DefaultCellStyle = dataGridViewCellStyle28;
            this.Column_employee_mname.HeaderText = "Отчество";
            this.Column_employee_mname.Name = "Column_employee_mname";
            this.Column_employee_mname.ReadOnly = true;
            // 
            // Column_Email
            // 
            this.Column_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Email.DataPropertyName = "Email";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle29.Format = "d";
            this.Column_Email.DefaultCellStyle = dataGridViewCellStyle29;
            this.Column_Email.HeaderText = "Email";
            this.Column_Email.Name = "Column_Email";
            this.Column_Email.ReadOnly = true;
            // 
            // menuStripEmployees
            // 
            this.menuStripEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripEmployees.Location = new System.Drawing.Point(0, 0);
            this.menuStripEmployees.Name = "menuStripEmployees";
            this.menuStripEmployees.Size = new System.Drawing.Size(1037, 24);
            this.menuStripEmployees.TabIndex = 9;
            this.menuStripEmployees.Text = "menuStrip1";
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
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.radioButtonEmail);
            this.panelFilters.Controls.Add(this.radioButtonMname);
            this.panelFilters.Controls.Add(this.radioButtonFname);
            this.panelFilters.Controls.Add(this.radioButtonLname);
            this.panelFilters.Location = new System.Drawing.Point(912, 63);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(126, 121);
            this.panelFilters.TabIndex = 19;
            this.panelFilters.Visible = false;
            // 
            // radioButtonEmail
            // 
            this.radioButtonEmail.AutoSize = true;
            this.radioButtonEmail.Depth = 0;
            this.radioButtonEmail.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonEmail.Location = new System.Drawing.Point(0, 91);
            this.radioButtonEmail.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonEmail.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonEmail.Name = "radioButtonEmail";
            this.radioButtonEmail.Ripple = true;
            this.radioButtonEmail.Size = new System.Drawing.Size(63, 30);
            this.radioButtonEmail.TabIndex = 20;
            this.radioButtonEmail.TabStop = true;
            this.radioButtonEmail.Text = "Email";
            this.radioButtonEmail.UseVisualStyleBackColor = true;
            this.radioButtonEmail.Click += new System.EventHandler(this.radioButtonEmail_Click);
            // 
            // radioButtonMname
            // 
            this.radioButtonMname.AutoSize = true;
            this.radioButtonMname.Depth = 0;
            this.radioButtonMname.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonMname.Location = new System.Drawing.Point(0, 60);
            this.radioButtonMname.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonMname.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonMname.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonMname.Name = "radioButtonMname";
            this.radioButtonMname.Ripple = true;
            this.radioButtonMname.Size = new System.Drawing.Size(90, 30);
            this.radioButtonMname.TabIndex = 19;
            this.radioButtonMname.TabStop = true;
            this.radioButtonMname.Text = "Отчество";
            this.radioButtonMname.UseVisualStyleBackColor = true;
            this.radioButtonMname.Click += new System.EventHandler(this.radioButtonMname_Click);
            // 
            // radioButtonFname
            // 
            this.radioButtonFname.AutoSize = true;
            this.radioButtonFname.Depth = 0;
            this.radioButtonFname.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonFname.Location = new System.Drawing.Point(0, 30);
            this.radioButtonFname.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonFname.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonFname.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonFname.Name = "radioButtonFname";
            this.radioButtonFname.Ripple = true;
            this.radioButtonFname.Size = new System.Drawing.Size(57, 30);
            this.radioButtonFname.TabIndex = 18;
            this.radioButtonFname.TabStop = true;
            this.radioButtonFname.Text = "Имя";
            this.radioButtonFname.UseVisualStyleBackColor = true;
            this.radioButtonFname.Click += new System.EventHandler(this.radioButtonFname_Click);
            // 
            // radioButtonLname
            // 
            this.radioButtonLname.AutoSize = true;
            this.radioButtonLname.Depth = 0;
            this.radioButtonLname.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonLname.Location = new System.Drawing.Point(0, 0);
            this.radioButtonLname.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonLname.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonLname.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonLname.Name = "radioButtonLname";
            this.radioButtonLname.Ripple = true;
            this.radioButtonLname.Size = new System.Drawing.Size(89, 30);
            this.radioButtonLname.TabIndex = 17;
            this.radioButtonLname.TabStop = true;
            this.radioButtonLname.Text = "Фамилия";
            this.radioButtonLname.UseVisualStyleBackColor = true;
            this.radioButtonLname.Click += new System.EventHandler(this.radioButtonLname_Click);
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
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.pictureBoxFilters);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStripEmployees);
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
            this.menuStripEmployees.ResumeLayout(false);
            this.menuStripEmployees.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.MenuStrip menuStripEmployees;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_employee_lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_employee_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_employee_mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
        private System.Windows.Forms.Panel panelFilters;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonFname;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonLname;
        private System.Windows.Forms.PictureBox pictureBoxFilters;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonEmail;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonMname;
    }
}