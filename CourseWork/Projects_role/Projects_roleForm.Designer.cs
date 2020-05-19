namespace CourseWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProjects_role = new System.Windows.Forms.DataGridView();
            this.Column_id_project_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_project_role_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripProjects_role = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects_role)).BeginInit();
            this.menuStripProjects_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProjects_role
            // 
            this.dataGridViewProjects_role.AllowUserToAddRows = false;
            this.dataGridViewProjects_role.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewProjects_role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects_role.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects_role.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProjects_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects_role.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_project_role,
            this.Column_project_role_name});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProjects_role.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProjects_role.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewProjects_role.Location = new System.Drawing.Point(0, 62);
            this.dataGridViewProjects_role.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProjects_role.MultiSelect = false;
            this.dataGridViewProjects_role.Name = "dataGridViewProjects_role";
            this.dataGridViewProjects_role.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewProjects_role.TabIndex = 7;
            this.dataGridViewProjects_role.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_role_CellDoubleClick);
            this.dataGridViewProjects_role.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewProjects_role_UserDeletingRow);
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_project_role_name.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_project_role_name.HeaderText = "Название роли";
            this.Column_project_role_name.MaxInputLength = 50;
            this.Column_project_role_name.Name = "Column_project_role_name";
            // 
            // menuStripProjects_role
            // 
            this.menuStripProjects_role.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripProjects_role.Location = new System.Drawing.Point(0, 0);
            this.menuStripProjects_role.Name = "menuStripProjects_role";
            this.menuStripProjects_role.Size = new System.Drawing.Size(1037, 24);
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
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "Поиск";
            this.textBoxSearch.Location = new System.Drawing.Point(763, 32);
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
            // Projects_roleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStripProjects_role);
            this.Controls.Add(this.dataGridViewProjects_role);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Projects_roleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Роли в проектах";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Projects_roleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Projects_roleForm_KeyDown);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
    }
}