namespace CourseWork.Projects_task
{
    partial class Projects_taskFormEdit
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
            this.buttonBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelValidRole = new System.Windows.Forms.Label();
            this.comboBox_fk_project_role = new System.Windows.Forms.ComboBox();
            this.labelValidEmployee = new System.Windows.Forms.Label();
            this.comboBox_fk_employee = new System.Windows.Forms.ComboBox();
            this.labelValidType = new System.Windows.Forms.Label();
            this.comboBox_fk_type_task = new System.Windows.Forms.ComboBox();
            this.labelValidProject = new System.Windows.Forms.Label();
            this.comboBox_fk_project = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(530, 328);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(77, 36);
            this.buttonBack.TabIndex = 69;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(12, 328);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(95, 36);
            this.buttonAdd.TabIndex = 68;
            this.buttonAdd.Text = "Изменить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelValidRole
            // 
            this.labelValidRole.AutoSize = true;
            this.labelValidRole.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidRole.ForeColor = System.Drawing.Color.Red;
            this.labelValidRole.Location = new System.Drawing.Point(239, 291);
            this.labelValidRole.Name = "labelValidRole";
            this.labelValidRole.Size = new System.Drawing.Size(145, 13);
            this.labelValidRole.TabIndex = 67;
            this.labelValidRole.Text = "Некорректные данные.";
            this.labelValidRole.Visible = false;
            // 
            // comboBox_fk_project_role
            // 
            this.comboBox_fk_project_role.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_fk_project_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fk_project_role.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_fk_project_role.ForeColor = System.Drawing.Color.White;
            this.comboBox_fk_project_role.FormattingEnabled = true;
            this.comboBox_fk_project_role.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_fk_project_role.Location = new System.Drawing.Point(12, 262);
            this.comboBox_fk_project_role.Name = "comboBox_fk_project_role";
            this.comboBox_fk_project_role.Size = new System.Drawing.Size(595, 26);
            this.comboBox_fk_project_role.TabIndex = 66;
            this.comboBox_fk_project_role.SelectedValueChanged += new System.EventHandler(this.comboBox_fk_project_role_SelectedValueChanged);
            // 
            // labelValidEmployee
            // 
            this.labelValidEmployee.AutoSize = true;
            this.labelValidEmployee.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidEmployee.ForeColor = System.Drawing.Color.Red;
            this.labelValidEmployee.Location = new System.Drawing.Point(239, 232);
            this.labelValidEmployee.Name = "labelValidEmployee";
            this.labelValidEmployee.Size = new System.Drawing.Size(145, 13);
            this.labelValidEmployee.TabIndex = 65;
            this.labelValidEmployee.Text = "Некорректные данные.";
            this.labelValidEmployee.Visible = false;
            // 
            // comboBox_fk_employee
            // 
            this.comboBox_fk_employee.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_fk_employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fk_employee.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_fk_employee.ForeColor = System.Drawing.Color.White;
            this.comboBox_fk_employee.FormattingEnabled = true;
            this.comboBox_fk_employee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_fk_employee.Location = new System.Drawing.Point(12, 203);
            this.comboBox_fk_employee.Name = "comboBox_fk_employee";
            this.comboBox_fk_employee.Size = new System.Drawing.Size(595, 26);
            this.comboBox_fk_employee.TabIndex = 64;
            this.comboBox_fk_employee.SelectedValueChanged += new System.EventHandler(this.comboBox_fk_employee_SelectedValueChanged);
            // 
            // labelValidType
            // 
            this.labelValidType.AutoSize = true;
            this.labelValidType.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidType.ForeColor = System.Drawing.Color.Red;
            this.labelValidType.Location = new System.Drawing.Point(239, 172);
            this.labelValidType.Name = "labelValidType";
            this.labelValidType.Size = new System.Drawing.Size(145, 13);
            this.labelValidType.TabIndex = 63;
            this.labelValidType.Text = "Некорректные данные.";
            this.labelValidType.Visible = false;
            // 
            // comboBox_fk_type_task
            // 
            this.comboBox_fk_type_task.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_fk_type_task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fk_type_task.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_fk_type_task.ForeColor = System.Drawing.Color.White;
            this.comboBox_fk_type_task.FormattingEnabled = true;
            this.comboBox_fk_type_task.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_fk_type_task.Location = new System.Drawing.Point(12, 143);
            this.comboBox_fk_type_task.Name = "comboBox_fk_type_task";
            this.comboBox_fk_type_task.Size = new System.Drawing.Size(595, 26);
            this.comboBox_fk_type_task.TabIndex = 62;
            this.comboBox_fk_type_task.SelectedValueChanged += new System.EventHandler(this.comboBox_fk_type_task_SelectedValueChanged);
            // 
            // labelValidProject
            // 
            this.labelValidProject.AutoSize = true;
            this.labelValidProject.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidProject.ForeColor = System.Drawing.Color.Red;
            this.labelValidProject.Location = new System.Drawing.Point(239, 113);
            this.labelValidProject.Name = "labelValidProject";
            this.labelValidProject.Size = new System.Drawing.Size(145, 13);
            this.labelValidProject.TabIndex = 61;
            this.labelValidProject.Text = "Некорректные данные.";
            this.labelValidProject.Visible = false;
            // 
            // comboBox_fk_project
            // 
            this.comboBox_fk_project.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_fk_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fk_project.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_fk_project.ForeColor = System.Drawing.Color.White;
            this.comboBox_fk_project.FormattingEnabled = true;
            this.comboBox_fk_project.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_fk_project.Location = new System.Drawing.Point(12, 84);
            this.comboBox_fk_project.Name = "comboBox_fk_project";
            this.comboBox_fk_project.Size = new System.Drawing.Size(595, 26);
            this.comboBox_fk_project.TabIndex = 60;
            this.comboBox_fk_project.SelectedValueChanged += new System.EventHandler(this.comboBox_fk_project_SelectedValueChanged);
            // 
            // Projects_taskFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 379);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelValidRole);
            this.Controls.Add(this.comboBox_fk_project_role);
            this.Controls.Add(this.labelValidEmployee);
            this.Controls.Add(this.comboBox_fk_employee);
            this.Controls.Add(this.labelValidType);
            this.Controls.Add(this.comboBox_fk_type_task);
            this.Controls.Add(this.labelValidProject);
            this.Controls.Add(this.comboBox_fk_project);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Projects_taskFormEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить задачу";
            this.Load += new System.EventHandler(this.Projects_taskFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton buttonBack;
        private MaterialSkin.Controls.MaterialFlatButton buttonAdd;
        private System.Windows.Forms.Label labelValidRole;
        private System.Windows.Forms.ComboBox comboBox_fk_project_role;
        private System.Windows.Forms.Label labelValidEmployee;
        private System.Windows.Forms.ComboBox comboBox_fk_employee;
        private System.Windows.Forms.Label labelValidType;
        private System.Windows.Forms.ComboBox comboBox_fk_type_task;
        private System.Windows.Forms.Label labelValidProject;
        private System.Windows.Forms.ComboBox comboBox_fk_project;
    }
}