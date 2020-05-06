namespace CourseWork
{
    partial class ProjectsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.Column_id_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_project_target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date_completion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_fk_leader = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(932, 14);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(933, 77);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_project,
            this.Column_project_name,
            this.Column_project_target,
            this.Column_date_start,
            this.Column_date_completion,
            this.ComboBox_fk_leader});
            this.dataGridViewProjects.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.Size = new System.Drawing.Size(925, 526);
            this.dataGridViewProjects.TabIndex = 4;
            this.dataGridViewProjects.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_CellValueChanged);
            this.dataGridViewProjects.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewProjects_UserDeletingRow);
            // 
            // Column_id_project
            // 
            this.Column_id_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_id_project.DataPropertyName = "id_project";
            this.Column_id_project.HeaderText = "Id";
            this.Column_id_project.Name = "Column_id_project";
            this.Column_id_project.Visible = false;
            // 
            // Column_project_name
            // 
            this.Column_project_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_project_name.DataPropertyName = "project_name";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_project_name.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column_project_name.HeaderText = "Название проекта";
            this.Column_project_name.Name = "Column_project_name";
            // 
            // Column_project_target
            // 
            this.Column_project_target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_project_target.DataPropertyName = "project_target";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_project_target.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column_project_target.HeaderText = "Цель проекта";
            this.Column_project_target.Name = "Column_project_target";
            // 
            // Column_date_start
            // 
            this.Column_date_start.DataPropertyName = "date_start";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Column_date_start.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column_date_start.HeaderText = "Дата начала";
            this.Column_date_start.Name = "Column_date_start";
            this.Column_date_start.Width = 90;
            // 
            // Column_date_completion
            // 
            this.Column_date_completion.DataPropertyName = "date_completion";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Column_date_completion.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column_date_completion.HeaderText = "Дата завершения";
            this.Column_date_completion.Name = "Column_date_completion";
            this.Column_date_completion.Width = 105;
            // 
            // ComboBox_fk_leader
            // 
            this.ComboBox_fk_leader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComboBox_fk_leader.DataPropertyName = "fk_leader";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ComboBox_fk_leader.DefaultCellStyle = dataGridViewCellStyle20;
            this.ComboBox_fk_leader.HeaderText = "Руководитель";
            this.ComboBox_fk_leader.Name = "ComboBox_fk_leader";
            // 
            // Projects
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1037, 527);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewProjects);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1037, 527);
            this.Name = "Projects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Список проектов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_project_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_project_target;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date_completion;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBox_fk_leader;
    }
}