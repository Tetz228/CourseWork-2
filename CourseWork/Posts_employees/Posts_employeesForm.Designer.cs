namespace CourseWork
{
    partial class Posts_employeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPostsEmployees = new System.Windows.Forms.DataGridView();
            this.Column_id_post_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_employee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ComboBox_fk_post = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStripPosts_employees = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostsEmployees)).BeginInit();
            this.menuStripPosts_employees.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPostsEmployees
            // 
            this.dataGridViewPostsEmployees.AllowUserToAddRows = false;
            this.dataGridViewPostsEmployees.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewPostsEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPostsEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPostsEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPostsEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPostsEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_post_emp,
            this.ComboBox_fk_employee,
            this.ComboBox_fk_post});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPostsEmployees.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewPostsEmployees.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewPostsEmployees.Location = new System.Drawing.Point(0, 62);
            this.dataGridViewPostsEmployees.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewPostsEmployees.MultiSelect = false;
            this.dataGridViewPostsEmployees.Name = "dataGridViewPostsEmployees";
            this.dataGridViewPostsEmployees.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPostsEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewPostsEmployees.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewPostsEmployees.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewPostsEmployees.TabIndex = 1;
            this.dataGridViewPostsEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPostsEmployees_CellDoubleClick);
            this.dataGridViewPostsEmployees.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewPostsEmployees_UserDeletingRow);
            this.dataGridViewPostsEmployees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPostsEmployees_KeyDown);
            // 
            // Column_id_post_emp
            // 
            this.Column_id_post_emp.DataPropertyName = "id_post_emp";
            this.Column_id_post_emp.HeaderText = "Id";
            this.Column_id_post_emp.Name = "Column_id_post_emp";
            this.Column_id_post_emp.ReadOnly = true;
            this.Column_id_post_emp.Visible = false;
            // 
            // ComboBox_fk_employee
            // 
            this.ComboBox_fk_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_employee.DataPropertyName = "fk_employee";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_employee.DefaultCellStyle = dataGridViewCellStyle8;
            this.ComboBox_fk_employee.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_employee.HeaderText = "Сотрудник";
            this.ComboBox_fk_employee.Name = "ComboBox_fk_employee";
            this.ComboBox_fk_employee.ReadOnly = true;
            // 
            // ComboBox_fk_post
            // 
            this.ComboBox_fk_post.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_post.DataPropertyName = "fk_post";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_post.DefaultCellStyle = dataGridViewCellStyle9;
            this.ComboBox_fk_post.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_post.HeaderText = "Должность";
            this.ComboBox_fk_post.Name = "ComboBox_fk_post";
            this.ComboBox_fk_post.ReadOnly = true;
            // 
            // menuStripPosts_employees
            // 
            this.menuStripPosts_employees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripPosts_employees.Location = new System.Drawing.Point(0, 0);
            this.menuStripPosts_employees.Name = "menuStripPosts_employees";
            this.menuStripPosts_employees.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripPosts_employees.Size = new System.Drawing.Size(1037, 24);
            this.menuStripPosts_employees.TabIndex = 10;
            this.menuStripPosts_employees.Text = "menuStrip1";
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
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "Поиск";
            this.textBoxSearch.Location = new System.Drawing.Point(677, 30);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(262, 23);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Posts_employeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStripPosts_employees);
            this.Controls.Add(this.dataGridViewPostsEmployees);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Posts_employeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Должности сотрудников";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PostsEmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostsEmployees)).EndInit();
            this.menuStripPosts_employees.ResumeLayout(false);
            this.menuStripPosts_employees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPostsEmployees;
        private System.Windows.Forms.MenuStrip menuStripPosts_employees;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_post_emp;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_employee;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_post;
    }
}