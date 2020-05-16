namespace CourseWork.Users_roles
{
    partial class Users_rolesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewUsers_roles = new System.Windows.Forms.DataGridView();
            this.Column_id_user_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_user_name_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripUsers_roles = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers_roles)).BeginInit();
            this.menuStripUsers_roles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers_roles
            // 
            this.dataGridViewUsers_roles.AllowUserToAddRows = false;
            this.dataGridViewUsers_roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers_roles.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewUsers_roles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers_roles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers_roles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsers_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers_roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_user_role,
            this.Column_user_name_role});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers_roles.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUsers_roles.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewUsers_roles.Location = new System.Drawing.Point(-1, 63);
            this.dataGridViewUsers_roles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsers_roles.MultiSelect = false;
            this.dataGridViewUsers_roles.Name = "dataGridViewUsers_roles";
            this.dataGridViewUsers_roles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewUsers_roles.Size = new System.Drawing.Size(1040, 515);
            this.dataGridViewUsers_roles.TabIndex = 9;
            this.dataGridViewUsers_roles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_roles_CellDoubleClick);
            this.dataGridViewUsers_roles.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewUsers_roles_UserDeletingRow);
            this.dataGridViewUsers_roles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewUsers_roles_KeyDown);
            // 
            // Column_id_user_role
            // 
            this.Column_id_user_role.DataPropertyName = "id_user_role";
            this.Column_id_user_role.HeaderText = "Id";
            this.Column_id_user_role.Name = "Column_id_user_role";
            this.Column_id_user_role.ReadOnly = true;
            this.Column_id_user_role.Visible = false;
            // 
            // Column_user_name_role
            // 
            this.Column_user_name_role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_user_name_role.DataPropertyName = "user_name_role";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_user_name_role.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_user_name_role.HeaderText = "Название роли";
            this.Column_user_name_role.MaxInputLength = 35;
            this.Column_user_name_role.Name = "Column_user_name_role";
            this.Column_user_name_role.ReadOnly = true;
            // 
            // menuStripUsers_roles
            // 
            this.menuStripUsers_roles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripUsers_roles.Location = new System.Drawing.Point(0, 0);
            this.menuStripUsers_roles.Name = "menuStripUsers_roles";
            this.menuStripUsers_roles.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripUsers_roles.Size = new System.Drawing.Size(1037, 24);
            this.menuStripUsers_roles.TabIndex = 10;
            this.menuStripUsers_roles.Text = "menuStrip1";
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
            // Users_rolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 571);
            this.ControlBox = false;
            this.Controls.Add(this.menuStripUsers_roles);
            this.Controls.Add(this.dataGridViewUsers_roles);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Users_rolesForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Роли пользователей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Users_rolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers_roles)).EndInit();
            this.menuStripUsers_roles.ResumeLayout(false);
            this.menuStripUsers_roles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers_roles;
        private System.Windows.Forms.MenuStrip menuStripUsers_roles;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_user_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_user_name_role;
    }
}