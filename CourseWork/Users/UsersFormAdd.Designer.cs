namespace CourseWork.Users
{
    partial class UsersFormAdd
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
            this.labelValidEmployee = new System.Windows.Forms.Label();
            this.ComboBox_fk_employee = new System.Windows.Forms.ComboBox();
            this.labelValidRole = new System.Windows.Forms.Label();
            this.ComboBox_fk_role_user = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelValidEmployee
            // 
            this.labelValidEmployee.AutoSize = true;
            this.labelValidEmployee.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidEmployee.ForeColor = System.Drawing.Color.Red;
            this.labelValidEmployee.Location = new System.Drawing.Point(375, 178);
            this.labelValidEmployee.Name = "labelValidEmployee";
            this.labelValidEmployee.Size = new System.Drawing.Size(141, 13);
            this.labelValidEmployee.TabIndex = 51;
            this.labelValidEmployee.Text = "Некорректные данные";
            this.labelValidEmployee.Visible = false;
            // 
            // ComboBox_fk_employee
            // 
            this.ComboBox_fk_employee.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_fk_employee.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_employee.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_employee.FormattingEnabled = true;
            this.ComboBox_fk_employee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_employee.Location = new System.Drawing.Point(348, 149);
            this.ComboBox_fk_employee.Name = "ComboBox_fk_employee";
            this.ComboBox_fk_employee.Size = new System.Drawing.Size(189, 26);
            this.ComboBox_fk_employee.TabIndex = 50;
            // 
            // labelValidRole
            // 
            this.labelValidRole.AutoSize = true;
            this.labelValidRole.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidRole.ForeColor = System.Drawing.Color.Red;
            this.labelValidRole.Location = new System.Drawing.Point(375, 124);
            this.labelValidRole.Name = "labelValidRole";
            this.labelValidRole.Size = new System.Drawing.Size(141, 13);
            this.labelValidRole.TabIndex = 53;
            this.labelValidRole.Text = "Некорректные данные";
            this.labelValidRole.Visible = false;
            // 
            // ComboBox_fk_role_user
            // 
            this.ComboBox_fk_role_user.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_role_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_fk_role_user.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_role_user.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_role_user.FormattingEnabled = true;
            this.ComboBox_fk_role_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_role_user.Location = new System.Drawing.Point(348, 95);
            this.ComboBox_fk_role_user.Name = "ComboBox_fk_role_user";
            this.ComboBox_fk_role_user.Size = new System.Drawing.Size(189, 26);
            this.ComboBox_fk_role_user.TabIndex = 52;
            // 
            // UsersFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 298);
            this.Controls.Add(this.labelValidRole);
            this.Controls.Add(this.ComboBox_fk_role_user);
            this.Controls.Add(this.labelValidEmployee);
            this.Controls.Add(this.ComboBox_fk_employee);
            this.MaximizeBox = false;
            this.Name = "UsersFormAdd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValidEmployee;
        private System.Windows.Forms.ComboBox ComboBox_fk_employee;
        private System.Windows.Forms.Label labelValidRole;
        private System.Windows.Forms.ComboBox ComboBox_fk_role_user;
    }
}