namespace CourseWork.Users
{
    partial class UsersFormEdit
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
            this.buttonEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBoxShowHidePassword = new System.Windows.Forms.PictureBox();
            this.TextBoxPassRepeat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelValidPassRepeat = new System.Windows.Forms.Label();
            this.TextBoxPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextBoxLog = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelValidPass = new System.Windows.Forms.Label();
            this.labelValidLog = new System.Windows.Forms.Label();
            this.labelValidRole = new System.Windows.Forms.Label();
            this.ComboBox_fk_role_user = new System.Windows.Forms.ComboBox();
            this.labelValidEmployee = new System.Windows.Forms.Label();
            this.ComboBox_fk_employee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowHidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(587, 255);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(77, 36);
            this.buttonBack.TabIndex = 75;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEdit.Depth = 0;
            this.buttonEdit.Icon = null;
            this.buttonEdit.Location = new System.Drawing.Point(13, 255);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Primary = true;
            this.buttonEdit.Size = new System.Drawing.Size(95, 36);
            this.buttonEdit.TabIndex = 74;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // pictureBoxShowHidePassword
            // 
            this.pictureBoxShowHidePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxShowHidePassword.Image = global::CourseWork.Properties.Resources.HidePassword;
            this.pictureBoxShowHidePassword.Location = new System.Drawing.Point(424, 93);
            this.pictureBoxShowHidePassword.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxShowHidePassword.Name = "pictureBoxShowHidePassword";
            this.pictureBoxShowHidePassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxShowHidePassword.TabIndex = 73;
            this.pictureBoxShowHidePassword.TabStop = false;
            // 
            // TextBoxPassRepeat
            // 
            this.TextBoxPassRepeat.Depth = 0;
            this.TextBoxPassRepeat.Hint = "Ещё раз пароль*";
            this.TextBoxPassRepeat.Location = new System.Drawing.Point(484, 94);
            this.TextBoxPassRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassRepeat.MaxLength = 35;
            this.TextBoxPassRepeat.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxPassRepeat.Name = "TextBoxPassRepeat";
            this.TextBoxPassRepeat.PasswordChar = '\0';
            this.TextBoxPassRepeat.SelectedText = "";
            this.TextBoxPassRepeat.SelectionLength = 0;
            this.TextBoxPassRepeat.SelectionStart = 0;
            this.TextBoxPassRepeat.Size = new System.Drawing.Size(180, 23);
            this.TextBoxPassRepeat.TabIndex = 72;
            this.TextBoxPassRepeat.TabStop = false;
            this.TextBoxPassRepeat.UseSystemPasswordChar = true;
            // 
            // labelValidPassRepeat
            // 
            this.labelValidPassRepeat.AutoSize = true;
            this.labelValidPassRepeat.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidPassRepeat.ForeColor = System.Drawing.Color.Red;
            this.labelValidPassRepeat.Location = new System.Drawing.Point(481, 121);
            this.labelValidPassRepeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValidPassRepeat.Name = "labelValidPassRepeat";
            this.labelValidPassRepeat.Size = new System.Drawing.Size(154, 13);
            this.labelValidPassRepeat.TabIndex = 71;
            this.labelValidPassRepeat.Text = "Введите ещё раз пароль";
            this.labelValidPassRepeat.Visible = false;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Depth = 0;
            this.TextBoxPass.Hint = "Пароль*";
            this.TextBoxPass.Location = new System.Drawing.Point(236, 95);
            this.TextBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPass.MaxLength = 35;
            this.TextBoxPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '\0';
            this.TextBoxPass.SelectedText = "";
            this.TextBoxPass.SelectionLength = 0;
            this.TextBoxPass.SelectionStart = 0;
            this.TextBoxPass.Size = new System.Drawing.Size(180, 23);
            this.TextBoxPass.TabIndex = 70;
            this.TextBoxPass.TabStop = false;
            this.TextBoxPass.UseSystemPasswordChar = true;
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Depth = 0;
            this.TextBoxLog.Hint = "Логин*";
            this.TextBoxLog.Location = new System.Drawing.Point(13, 95);
            this.TextBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLog.MaxLength = 30;
            this.TextBoxLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.PasswordChar = '\0';
            this.TextBoxLog.SelectedText = "";
            this.TextBoxLog.SelectionLength = 0;
            this.TextBoxLog.SelectionStart = 0;
            this.TextBoxLog.Size = new System.Drawing.Size(180, 23);
            this.TextBoxLog.TabIndex = 69;
            this.TextBoxLog.TabStop = false;
            this.TextBoxLog.UseSystemPasswordChar = false;
            // 
            // labelValidPass
            // 
            this.labelValidPass.AutoSize = true;
            this.labelValidPass.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidPass.ForeColor = System.Drawing.Color.Red;
            this.labelValidPass.Location = new System.Drawing.Point(233, 122);
            this.labelValidPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValidPass.Name = "labelValidPass";
            this.labelValidPass.Size = new System.Drawing.Size(102, 13);
            this.labelValidPass.TabIndex = 68;
            this.labelValidPass.Text = "Введите пароль";
            this.labelValidPass.Visible = false;
            // 
            // labelValidLog
            // 
            this.labelValidLog.AutoSize = true;
            this.labelValidLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidLog.ForeColor = System.Drawing.Color.Red;
            this.labelValidLog.Location = new System.Drawing.Point(10, 122);
            this.labelValidLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValidLog.Name = "labelValidLog";
            this.labelValidLog.Size = new System.Drawing.Size(177, 13);
            this.labelValidLog.TabIndex = 67;
            this.labelValidLog.Text = "Минимальная длинна логина";
            this.labelValidLog.Visible = false;
            // 
            // labelValidRole
            // 
            this.labelValidRole.AutoSize = true;
            this.labelValidRole.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidRole.ForeColor = System.Drawing.Color.Red;
            this.labelValidRole.Location = new System.Drawing.Point(52, 221);
            this.labelValidRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValidRole.Name = "labelValidRole";
            this.labelValidRole.Size = new System.Drawing.Size(141, 13);
            this.labelValidRole.TabIndex = 66;
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
            this.ComboBox_fk_role_user.Location = new System.Drawing.Point(13, 191);
            this.ComboBox_fk_role_user.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_fk_role_user.Name = "ComboBox_fk_role_user";
            this.ComboBox_fk_role_user.Size = new System.Drawing.Size(222, 26);
            this.ComboBox_fk_role_user.TabIndex = 65;
            // 
            // labelValidEmployee
            // 
            this.labelValidEmployee.AutoSize = true;
            this.labelValidEmployee.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidEmployee.ForeColor = System.Drawing.Color.Red;
            this.labelValidEmployee.Location = new System.Drawing.Point(401, 221);
            this.labelValidEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValidEmployee.Name = "labelValidEmployee";
            this.labelValidEmployee.Size = new System.Drawing.Size(141, 13);
            this.labelValidEmployee.TabIndex = 64;
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
            this.ComboBox_fk_employee.Location = new System.Drawing.Point(292, 191);
            this.ComboBox_fk_employee.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_fk_employee.Name = "ComboBox_fk_employee";
            this.ComboBox_fk_employee.Size = new System.Drawing.Size(372, 26);
            this.ComboBox_fk_employee.TabIndex = 63;
            // 
            // UsersFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 302);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureBoxShowHidePassword);
            this.Controls.Add(this.TextBoxPassRepeat);
            this.Controls.Add(this.labelValidPassRepeat);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLog);
            this.Controls.Add(this.labelValidPass);
            this.Controls.Add(this.labelValidLog);
            this.Controls.Add(this.labelValidRole);
            this.Controls.Add(this.ComboBox_fk_role_user);
            this.Controls.Add(this.labelValidEmployee);
            this.Controls.Add(this.ComboBox_fk_employee);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "UsersFormEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить пользователя";
            this.Load += new System.EventHandler(this.UsersFormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowHidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton buttonBack;
        private MaterialSkin.Controls.MaterialFlatButton buttonEdit;
        private System.Windows.Forms.PictureBox pictureBoxShowHidePassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxPassRepeat;
        private System.Windows.Forms.Label labelValidPassRepeat;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxLog;
        private System.Windows.Forms.Label labelValidPass;
        private System.Windows.Forms.Label labelValidLog;
        private System.Windows.Forms.Label labelValidRole;
        private System.Windows.Forms.ComboBox ComboBox_fk_role_user;
        private System.Windows.Forms.Label labelValidEmployee;
        private System.Windows.Forms.ComboBox ComboBox_fk_employee;
    }
}