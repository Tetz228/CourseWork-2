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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPostsEmployees = new System.Windows.Forms.DataGridView();
            this.Column_id_post_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_fk_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_fk_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripPosts_employees = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBoxFilters = new System.Windows.Forms.PictureBox();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.radioButtonEmployee = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonPost = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostsEmployees)).BeginInit();
            this.menuStripPosts_employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).BeginInit();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPostsEmployees
            // 
            this.dataGridViewPostsEmployees.AllowUserToAddRows = false;
            this.dataGridViewPostsEmployees.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewPostsEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPostsEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPostsEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewPostsEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPostsEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_post_emp,
            this.Column_fk_employee,
            this.Column_fk_post});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPostsEmployees.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewPostsEmployees.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewPostsEmployees.Location = new System.Drawing.Point(0, 62);
            this.dataGridViewPostsEmployees.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewPostsEmployees.MultiSelect = false;
            this.dataGridViewPostsEmployees.Name = "dataGridViewPostsEmployees";
            this.dataGridViewPostsEmployees.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPostsEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewPostsEmployees.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewPostsEmployees.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewPostsEmployees.TabIndex = 1;
            this.dataGridViewPostsEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPostsEmployees_CellDoubleClick);
            this.dataGridViewPostsEmployees.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewPostsEmployees_UserDeletingRow);
            this.dataGridViewPostsEmployees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPostsEmployees_KeyDown);
            // 
            // Column_id_post_emp
            // 
            this.Column_id_post_emp.DataPropertyName = "Id";
            this.Column_id_post_emp.HeaderText = "Id";
            this.Column_id_post_emp.Name = "Column_id_post_emp";
            this.Column_id_post_emp.ReadOnly = true;
            this.Column_id_post_emp.Visible = false;
            // 
            // Column_fk_employee
            // 
            this.Column_fk_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_fk_employee.DataPropertyName = "Employee";
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Column_fk_employee.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column_fk_employee.HeaderText = "Сотрудник";
            this.Column_fk_employee.Name = "Column_fk_employee";
            this.Column_fk_employee.ReadOnly = true;
            this.Column_fk_employee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_fk_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_fk_post
            // 
            this.Column_fk_post.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_fk_post.DataPropertyName = "Post";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Column_fk_post.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column_fk_post.HeaderText = "Должность";
            this.Column_fk_post.Name = "Column_fk_post";
            this.Column_fk_post.ReadOnly = true;
            this.Column_fk_post.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_fk_post.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.textBoxSearch.Location = new System.Drawing.Point(738, 31);
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
            // pictureBoxFilters
            // 
            this.pictureBoxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilters.Image = global::CourseWork.Properties.Resources.Filters;
            this.pictureBoxFilters.Location = new System.Drawing.Point(1006, 30);
            this.pictureBoxFilters.Name = "pictureBoxFilters";
            this.pictureBoxFilters.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxFilters.TabIndex = 13;
            this.pictureBoxFilters.TabStop = false;
            this.pictureBoxFilters.Click += new System.EventHandler(this.pictureBoxFilters_Click);
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.radioButtonPost);
            this.panelFilters.Controls.Add(this.radioButtonEmployee);
            this.panelFilters.Location = new System.Drawing.Point(911, 62);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(126, 63);
            this.panelFilters.TabIndex = 16;
            this.panelFilters.Visible = false;
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Depth = 0;
            this.radioButtonEmployee.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonEmployee.Location = new System.Drawing.Point(0, 0);
            this.radioButtonEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Ripple = true;
            this.radioButtonEmployee.Size = new System.Drawing.Size(99, 30);
            this.radioButtonEmployee.TabIndex = 17;
            this.radioButtonEmployee.TabStop = true;
            this.radioButtonEmployee.Text = "Сотрудник";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
            this.radioButtonEmployee.Click += new System.EventHandler(this.radioButtonEmployee_Click);
            // 
            // radioButtonPost
            // 
            this.radioButtonPost.AutoSize = true;
            this.radioButtonPost.Depth = 0;
            this.radioButtonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonPost.Location = new System.Drawing.Point(0, 30);
            this.radioButtonPost.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonPost.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonPost.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonPost.Name = "radioButtonPost";
            this.radioButtonPost.Ripple = true;
            this.radioButtonPost.Size = new System.Drawing.Size(103, 30);
            this.radioButtonPost.TabIndex = 18;
            this.radioButtonPost.TabStop = true;
            this.radioButtonPost.Text = "Должность";
            this.radioButtonPost.UseVisualStyleBackColor = true;
            this.radioButtonPost.Click += new System.EventHandler(this.radioButtonPost_Click);
            // 
            // Posts_employeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.pictureBoxFilters);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBoxFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_post_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_fk_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_fk_post;
        private System.Windows.Forms.Panel panelFilters;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonPost;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonEmployee;
    }
}