namespace CourseWork.Users
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Column_id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_role_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripListUsers = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.radioButtonRoleUsers = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonLogin = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonEmployee = new MaterialSkin.Controls.MaterialRadioButton();
            this.pictureBoxFilters = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.menuStripListUsers.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_user,
            this.Column_login,
            this.Column_password,
            this.fk_role_user,
            this.fk_employee});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.DimGray;
            this.dataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewUsers.TabIndex = 5;
            this.dataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellDoubleClick);
            this.dataGridViewUsers.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewUsers_UserDeletingRow);
            this.dataGridViewUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewUsers_KeyDown);
            // 
            // Column_id_user
            // 
            this.Column_id_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_id_user.DataPropertyName = "Id";
            this.Column_id_user.HeaderText = "Id";
            this.Column_id_user.Name = "Column_id_user";
            this.Column_id_user.ReadOnly = true;
            this.Column_id_user.Visible = false;
            // 
            // Column_login
            // 
            this.Column_login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_login.DataPropertyName = "Login";
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_login.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column_login.HeaderText = "Логин";
            this.Column_login.Name = "Column_login";
            this.Column_login.ReadOnly = true;
            // 
            // Column_password
            // 
            this.Column_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_password.DataPropertyName = "Password";
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.NullValue = "Не указана";
            this.Column_password.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column_password.HeaderText = "Пароль";
            this.Column_password.Name = "Column_password";
            this.Column_password.ReadOnly = true;
            // 
            // fk_role_user
            // 
            this.fk_role_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fk_role_user.DataPropertyName = "RoleUser";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle20.Format = "d";
            dataGridViewCellStyle20.NullValue = "Не указана";
            this.fk_role_user.DefaultCellStyle = dataGridViewCellStyle20;
            this.fk_role_user.HeaderText = "Роль пользователя";
            this.fk_role_user.Name = "fk_role_user";
            this.fk_role_user.ReadOnly = true;
            this.fk_role_user.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fk_role_user.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fk_employee
            // 
            this.fk_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fk_employee.DataPropertyName = "Employee";
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.fk_employee.DefaultCellStyle = dataGridViewCellStyle21;
            this.fk_employee.HeaderText = "Сотрудник";
            this.fk_employee.Name = "fk_employee";
            this.fk_employee.ReadOnly = true;
            this.fk_employee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fk_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStripListUsers
            // 
            this.menuStripListUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripListUsers.Location = new System.Drawing.Point(0, 0);
            this.menuStripListUsers.Name = "menuStripListUsers";
            this.menuStripListUsers.Size = new System.Drawing.Size(1037, 24);
            this.menuStripListUsers.TabIndex = 10;
            this.menuStripListUsers.Text = "menuStrip1";
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
            this.panelFilters.Controls.Add(this.radioButtonRoleUsers);
            this.panelFilters.Controls.Add(this.radioButtonLogin);
            this.panelFilters.Controls.Add(this.radioButtonEmployee);
            this.panelFilters.Location = new System.Drawing.Point(848, 63);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(189, 95);
            this.panelFilters.TabIndex = 19;
            this.panelFilters.Visible = false;
            // 
            // radioButtonRoleUsers
            // 
            this.radioButtonRoleUsers.AutoSize = true;
            this.radioButtonRoleUsers.Depth = 0;
            this.radioButtonRoleUsers.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonRoleUsers.Location = new System.Drawing.Point(0, 30);
            this.radioButtonRoleUsers.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonRoleUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonRoleUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonRoleUsers.Name = "radioButtonRoleUsers";
            this.radioButtonRoleUsers.Ripple = true;
            this.radioButtonRoleUsers.Size = new System.Drawing.Size(155, 30);
            this.radioButtonRoleUsers.TabIndex = 19;
            this.radioButtonRoleUsers.TabStop = true;
            this.radioButtonRoleUsers.Text = "Роль пользователя";
            this.radioButtonRoleUsers.UseVisualStyleBackColor = true;
            this.radioButtonRoleUsers.CheckedChanged += new System.EventHandler(this.radioButtonRoleUsers_CheckedChanged);
            // 
            // radioButtonLogin
            // 
            this.radioButtonLogin.AutoSize = true;
            this.radioButtonLogin.Depth = 0;
            this.radioButtonLogin.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonLogin.Location = new System.Drawing.Point(0, 0);
            this.radioButtonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonLogin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonLogin.Name = "radioButtonLogin";
            this.radioButtonLogin.Ripple = true;
            this.radioButtonLogin.Size = new System.Drawing.Size(68, 30);
            this.radioButtonLogin.TabIndex = 18;
            this.radioButtonLogin.TabStop = true;
            this.radioButtonLogin.Text = "Логин";
            this.radioButtonLogin.UseVisualStyleBackColor = true;
            this.radioButtonLogin.CheckedChanged += new System.EventHandler(this.radioButtonLogin_CheckedChanged);
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Depth = 0;
            this.radioButtonEmployee.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonEmployee.Location = new System.Drawing.Point(0, 60);
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
            this.radioButtonEmployee.CheckedChanged += new System.EventHandler(this.radioButtonEmployee_CheckedChanged);
            // 
            // pictureBoxFilters
            // 
            this.pictureBoxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilters.Image = global::CourseWork.Properties.Resources.Filters;
            this.pictureBoxFilters.Location = new System.Drawing.Point(1007, 30);
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
            this.textBoxSearch.Location = new System.Drawing.Point(739, 31);
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
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.pictureBoxFilters);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStripListUsers);
            this.Controls.Add(this.dataGridViewUsers);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UsersForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Список пользователей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.menuStripListUsers.ResumeLayout(false);
            this.menuStripListUsers.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.MenuStrip menuStripListUsers;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.PictureBox pictureBoxFilters;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonEmployee;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonRoleUsers;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_role_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_employee;
    }
}