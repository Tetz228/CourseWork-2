namespace CourseWork.Projects_task
{
    partial class Projects_taskForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProjects_task = new System.Windows.Forms.DataGridView();
            this.Column_id_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_project = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ComboBox_fk_type_task = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ComboBox_fk_employee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ComboBox_fk_project_role = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStripProjects_task = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects_task)).BeginInit();
            this.menuStripProjects_task.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProjects_task
            // 
            this.dataGridViewProjects_task.AllowUserToAddRows = false;
            this.dataGridViewProjects_task.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewProjects_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects_task.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle89.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle89.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle89.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle89.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle89.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle89.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle89.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle89;
            this.dataGridViewProjects_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_task,
            this.ComboBox_fk_project,
            this.ComboBox_fk_type_task,
            this.ComboBox_fk_employee,
            this.ComboBox_fk_project_role});
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle94.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle94.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle94.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle94.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle94.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle94.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProjects_task.DefaultCellStyle = dataGridViewCellStyle94;
            this.dataGridViewProjects_task.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewProjects_task.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewProjects_task.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProjects_task.MultiSelect = false;
            this.dataGridViewProjects_task.Name = "dataGridViewProjects_task";
            this.dataGridViewProjects_task.ReadOnly = true;
            dataGridViewCellStyle95.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle95.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle95.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle95.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle95.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle95.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle95.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects_task.RowHeadersDefaultCellStyle = dataGridViewCellStyle95;
            dataGridViewCellStyle96.BackColor = System.Drawing.Color.DimGray;
            this.dataGridViewProjects_task.RowsDefaultCellStyle = dataGridViewCellStyle96;
            this.dataGridViewProjects_task.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewProjects_task.TabIndex = 5;
            this.dataGridViewProjects_task.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_task_CellDoubleClick);
            this.dataGridViewProjects_task.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewProjects_task_UserDeletingRow);
            this.dataGridViewProjects_task.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProjects_task_KeyDown);
            // 
            // Column_id_task
            // 
            this.Column_id_task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_id_task.DataPropertyName = "id_task";
            this.Column_id_task.HeaderText = "Id";
            this.Column_id_task.Name = "Column_id_task";
            this.Column_id_task.ReadOnly = true;
            this.Column_id_task.Visible = false;
            // 
            // ComboBox_fk_project
            // 
            this.ComboBox_fk_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_project.DataPropertyName = "fk_project";
            dataGridViewCellStyle90.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle90.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_project.DefaultCellStyle = dataGridViewCellStyle90;
            this.ComboBox_fk_project.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_project.HeaderText = "Проект";
            this.ComboBox_fk_project.Name = "ComboBox_fk_project";
            this.ComboBox_fk_project.ReadOnly = true;
            this.ComboBox_fk_project.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboBox_fk_project.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ComboBox_fk_type_task
            // 
            this.ComboBox_fk_type_task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_type_task.DataPropertyName = "fk_type_task";
            dataGridViewCellStyle91.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle91.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle91.NullValue = "Не указана";
            this.ComboBox_fk_type_task.DefaultCellStyle = dataGridViewCellStyle91;
            this.ComboBox_fk_type_task.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_type_task.HeaderText = "Тип задачи";
            this.ComboBox_fk_type_task.Name = "ComboBox_fk_type_task";
            this.ComboBox_fk_type_task.ReadOnly = true;
            this.ComboBox_fk_type_task.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboBox_fk_type_task.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ComboBox_fk_employee
            // 
            this.ComboBox_fk_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_employee.DataPropertyName = "fk_employee";
            dataGridViewCellStyle92.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle92.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_employee.DefaultCellStyle = dataGridViewCellStyle92;
            this.ComboBox_fk_employee.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_employee.HeaderText = "Сотрудник";
            this.ComboBox_fk_employee.Name = "ComboBox_fk_employee";
            this.ComboBox_fk_employee.ReadOnly = true;
            this.ComboBox_fk_employee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ComboBox_fk_project_role
            // 
            this.ComboBox_fk_project_role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_project_role.DataPropertyName = "fk_project_role";
            dataGridViewCellStyle93.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle93.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle93.Format = "d";
            dataGridViewCellStyle93.NullValue = "Не указана";
            this.ComboBox_fk_project_role.DefaultCellStyle = dataGridViewCellStyle93;
            this.ComboBox_fk_project_role.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ComboBox_fk_project_role.HeaderText = "Роль в проекте";
            this.ComboBox_fk_project_role.Name = "ComboBox_fk_project_role";
            this.ComboBox_fk_project_role.ReadOnly = true;
            this.ComboBox_fk_project_role.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboBox_fk_project_role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // menuStripProjects_task
            // 
            this.menuStripProjects_task.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripProjects_task.Location = new System.Drawing.Point(0, 0);
            this.menuStripProjects_task.Name = "menuStripProjects_task";
            this.menuStripProjects_task.Size = new System.Drawing.Size(1037, 24);
            this.menuStripProjects_task.TabIndex = 11;
            this.menuStripProjects_task.Text = "menuStrip1";
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
            // Projects_taskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.menuStripProjects_task);
            this.Controls.Add(this.dataGridViewProjects_task);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Projects_taskForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Список задач";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Projects_taskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects_task)).EndInit();
            this.menuStripProjects_task.ResumeLayout(false);
            this.menuStripProjects_task.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjects_task;
        private System.Windows.Forms.MenuStrip menuStripProjects_task;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_task;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_project;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_type_task;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_employee;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_project_role;
    }
}