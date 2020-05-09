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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProjects_role = new System.Windows.Forms.DataGridView();
            this.Column_id_status_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_status_name_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects_role)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects_role
            // 
            this.dataGridViewProjects_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects_role.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_status_project,
            this.Column_status_name_project});
            this.dataGridViewProjects_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProjects_role.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProjects_role.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProjects_role.Name = "dataGridViewProjects_role";
            this.dataGridViewProjects_role.Size = new System.Drawing.Size(1041, 593);
            this.dataGridViewProjects_role.TabIndex = 7;
            // 
            // Column_id_status_project
            // 
            this.Column_id_status_project.DataPropertyName = "id_project_role";
            this.Column_id_status_project.HeaderText = "Id";
            this.Column_id_status_project.Name = "Column_id_status_project";
            this.Column_id_status_project.Visible = false;
            // 
            // Column_status_name_project
            // 
            this.Column_status_name_project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_status_name_project.DataPropertyName = "project_role_name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_status_name_project.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_status_name_project.HeaderText = "Название роли";
            this.Column_status_name_project.MaxInputLength = 50;
            this.Column_status_name_project.Name = "Column_status_name_project";
            // 
            // Projects_roleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 593);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewProjects_role);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1041, 593);
            this.Name = "Projects_roleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Роли в проектах";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Projects_roleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects_role)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjects_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_status_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_status_name_project;
    }
}