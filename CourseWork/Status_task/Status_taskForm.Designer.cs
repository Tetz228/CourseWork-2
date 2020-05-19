namespace CourseWork.Status_task
{
    partial class Status_taskForm
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
            this.dataGridViewStatus_task = new System.Windows.Forms.DataGridView();
            this.Column_id_status_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_status_name_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripStatus_task = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus_task)).BeginInit();
            this.menuStripStatus_task.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStatus_task
            // 
            this.dataGridViewStatus_task.AllowUserToAddRows = false;
            this.dataGridViewStatus_task.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStatus_task.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewStatus_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStatus_task.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStatus_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStatus_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatus_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_status_task,
            this.Column_status_name_task});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStatus_task.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewStatus_task.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewStatus_task.Location = new System.Drawing.Point(0, 64);
            this.dataGridViewStatus_task.MultiSelect = false;
            this.dataGridViewStatus_task.Name = "dataGridViewStatus_task";
            this.dataGridViewStatus_task.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStatus_task.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewStatus_task.TabIndex = 8;
            this.dataGridViewStatus_task.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStatus_task_CellDoubleClick);
            this.dataGridViewStatus_task.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewStatus_task_UserDeletingRow);
            this.dataGridViewStatus_task.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewStatus_task_KeyDown);
            // 
            // Column_id_status_task
            // 
            this.Column_id_status_task.DataPropertyName = "id_status_task";
            this.Column_id_status_task.HeaderText = "Id";
            this.Column_id_status_task.Name = "Column_id_status_task";
            this.Column_id_status_task.ReadOnly = true;
            this.Column_id_status_task.Visible = false;
            // 
            // Column_status_name_task
            // 
            this.Column_status_name_task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_status_name_task.DataPropertyName = "status_name_task";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_status_name_task.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_status_name_task.HeaderText = "Название статуса";
            this.Column_status_name_task.MaxInputLength = 35;
            this.Column_status_name_task.Name = "Column_status_name_task";
            this.Column_status_name_task.ReadOnly = true;
            // 
            // menuStripStatus_task
            // 
            this.menuStripStatus_task.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripStatus_task.Location = new System.Drawing.Point(0, 0);
            this.menuStripStatus_task.Name = "menuStripStatus_task";
            this.menuStripStatus_task.Size = new System.Drawing.Size(1037, 24);
            this.menuStripStatus_task.TabIndex = 9;
            this.menuStripStatus_task.Text = "menuStrip1";
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
            this.textBoxSearch.Location = new System.Drawing.Point(763, 33);
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
            // Status_taskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewStatus_task);
            this.Controls.Add(this.menuStripStatus_task);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Status_taskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Статусы задач";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Status_task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus_task)).EndInit();
            this.menuStripStatus_task.ResumeLayout(false);
            this.menuStripStatus_task.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatus_task;
        private System.Windows.Forms.MenuStrip menuStripStatus_task;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_status_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_status_name_task;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
    }
}