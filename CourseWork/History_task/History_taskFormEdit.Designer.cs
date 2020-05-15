namespace CourseWork.History_task
{
    partial class History_taskFormEdit
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
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelValidProject = new System.Windows.Forms.Label();
            this.labelValidStatus = new System.Windows.Forms.Label();
            this.labelValidDate = new System.Windows.Forms.Label();
            this.textBox_History_date_task = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ComboBox_fk_status_task = new System.Windows.Forms.ComboBox();
            this.ComboBox_fk_project_task = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(611, 227);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(95, 36);
            this.buttonBack.TabIndex = 67;
            this.buttonBack.Text = "Отменить";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEdit.Depth = 0;
            this.buttonEdit.Icon = null;
            this.buttonEdit.Location = new System.Drawing.Point(12, 227);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Primary = true;
            this.buttonEdit.Size = new System.Drawing.Size(95, 36);
            this.buttonEdit.TabIndex = 66;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelValidProject
            // 
            this.labelValidProject.AutoSize = true;
            this.labelValidProject.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidProject.ForeColor = System.Drawing.Color.Red;
            this.labelValidProject.Location = new System.Drawing.Point(316, 127);
            this.labelValidProject.Name = "labelValidProject";
            this.labelValidProject.Size = new System.Drawing.Size(145, 13);
            this.labelValidProject.TabIndex = 65;
            this.labelValidProject.Text = "Некорректные данные.";
            this.labelValidProject.Visible = false;
            // 
            // labelValidStatus
            // 
            this.labelValidStatus.AutoSize = true;
            this.labelValidStatus.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidStatus.ForeColor = System.Drawing.Color.Red;
            this.labelValidStatus.Location = new System.Drawing.Point(50, 185);
            this.labelValidStatus.Name = "labelValidStatus";
            this.labelValidStatus.Size = new System.Drawing.Size(145, 13);
            this.labelValidStatus.TabIndex = 64;
            this.labelValidStatus.Text = "Некорректные данные.";
            this.labelValidStatus.Visible = false;
            // 
            // labelValidDate
            // 
            this.labelValidDate.AutoSize = true;
            this.labelValidDate.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidDate.ForeColor = System.Drawing.Color.Red;
            this.labelValidDate.Location = new System.Drawing.Point(485, 182);
            this.labelValidDate.Name = "labelValidDate";
            this.labelValidDate.Size = new System.Drawing.Size(163, 26);
            this.labelValidDate.TabIndex = 63;
            this.labelValidDate.Text = "Некорректная дата.\r\nФормат даты: DD.MM.YYYY\r\n";
            this.labelValidDate.Visible = false;
            // 
            // textBox_History_date_task
            // 
            this.textBox_History_date_task.Depth = 0;
            this.textBox_History_date_task.Hint = "Дата";
            this.textBox_History_date_task.Location = new System.Drawing.Point(487, 156);
            this.textBox_History_date_task.MaxLength = 32767;
            this.textBox_History_date_task.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_History_date_task.Name = "textBox_History_date_task";
            this.textBox_History_date_task.PasswordChar = '\0';
            this.textBox_History_date_task.SelectedText = "";
            this.textBox_History_date_task.SelectionLength = 0;
            this.textBox_History_date_task.SelectionStart = 0;
            this.textBox_History_date_task.Size = new System.Drawing.Size(219, 23);
            this.textBox_History_date_task.TabIndex = 62;
            this.textBox_History_date_task.TabStop = false;
            this.textBox_History_date_task.UseSystemPasswordChar = false;
            this.textBox_History_date_task.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_History_date_task_KeyPress);
            // 
            // ComboBox_fk_status_task
            // 
            this.ComboBox_fk_status_task.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_status_task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_fk_status_task.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_status_task.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_status_task.FormattingEnabled = true;
            this.ComboBox_fk_status_task.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_status_task.Location = new System.Drawing.Point(13, 156);
            this.ComboBox_fk_status_task.Name = "ComboBox_fk_status_task";
            this.ComboBox_fk_status_task.Size = new System.Drawing.Size(219, 26);
            this.ComboBox_fk_status_task.TabIndex = 61;
            this.ComboBox_fk_status_task.SelectedValueChanged += new System.EventHandler(this.ComboBox_fk_status_task_SelectedValueChanged);
            // 
            // ComboBox_fk_project_task
            // 
            this.ComboBox_fk_project_task.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_project_task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_fk_project_task.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_project_task.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_project_task.FormattingEnabled = true;
            this.ComboBox_fk_project_task.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_project_task.Location = new System.Drawing.Point(12, 98);
            this.ComboBox_fk_project_task.Name = "ComboBox_fk_project_task";
            this.ComboBox_fk_project_task.Size = new System.Drawing.Size(694, 26);
            this.ComboBox_fk_project_task.TabIndex = 60;
            this.ComboBox_fk_project_task.SelectedValueChanged += new System.EventHandler(this.ComboBox_fk_project_task_SelectedValueChanged);
            // 
            // History_taskFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 275);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelValidProject);
            this.Controls.Add(this.labelValidStatus);
            this.Controls.Add(this.labelValidDate);
            this.Controls.Add(this.textBox_History_date_task);
            this.Controls.Add(this.ComboBox_fk_status_task);
            this.Controls.Add(this.ComboBox_fk_project_task);
            this.MaximizeBox = false;
            this.Name = "History_taskFormEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить историю задачи";
            this.Load += new System.EventHandler(this.History_taskFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEdit;
        private System.Windows.Forms.Label labelValidProject;
        private System.Windows.Forms.Label labelValidStatus;
        private System.Windows.Forms.Label labelValidDate;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_History_date_task;
        private System.Windows.Forms.ComboBox ComboBox_fk_status_task;
        private System.Windows.Forms.ComboBox ComboBox_fk_project_task;
    }
}