namespace CourseWork
{
    partial class RegistrationForm
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
            this.labelValidLname = new System.Windows.Forms.Label();
            this.labelValidFname = new System.Windows.Forms.Label();
            this.labelValidRegLog = new System.Windows.Forms.Label();
            this.labelValidRegPass = new System.Windows.Forms.Label();
            this.labelValidEmail = new System.Windows.Forms.Label();
            this.TextBoxLname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextBoxFname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextBoxMname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextBoxRegLog = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextBoxRegPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextBoxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonReg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TextBoxRegPassRepeat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelValidRegPassRepeat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValidLname
            // 
            this.labelValidLname.AutoSize = true;
            this.labelValidLname.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidLname.ForeColor = System.Drawing.Color.Red;
            this.labelValidLname.Location = new System.Drawing.Point(9, 120);
            this.labelValidLname.Name = "labelValidLname";
            this.labelValidLname.Size = new System.Drawing.Size(114, 13);
            this.labelValidLname.TabIndex = 27;
            this.labelValidLname.Text = "Введите фамилию";
            this.labelValidLname.Visible = false;
            // 
            // labelValidFname
            // 
            this.labelValidFname.AutoSize = true;
            this.labelValidFname.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidFname.ForeColor = System.Drawing.Color.Red;
            this.labelValidFname.Location = new System.Drawing.Point(206, 120);
            this.labelValidFname.Name = "labelValidFname";
            this.labelValidFname.Size = new System.Drawing.Size(81, 13);
            this.labelValidFname.TabIndex = 28;
            this.labelValidFname.Text = "Введите имя";
            this.labelValidFname.Visible = false;
            // 
            // labelValidRegLog
            // 
            this.labelValidRegLog.AutoSize = true;
            this.labelValidRegLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidRegLog.ForeColor = System.Drawing.Color.Red;
            this.labelValidRegLog.Location = new System.Drawing.Point(9, 180);
            this.labelValidRegLog.Name = "labelValidRegLog";
            this.labelValidRegLog.Size = new System.Drawing.Size(177, 13);
            this.labelValidRegLog.TabIndex = 29;
            this.labelValidRegLog.Text = "Минимальная длинна логина";
            this.labelValidRegLog.Visible = false;
            // 
            // labelValidRegPass
            // 
            this.labelValidRegPass.AutoSize = true;
            this.labelValidRegPass.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidRegPass.ForeColor = System.Drawing.Color.Red;
            this.labelValidRegPass.Location = new System.Drawing.Point(209, 180);
            this.labelValidRegPass.Name = "labelValidRegPass";
            this.labelValidRegPass.Size = new System.Drawing.Size(102, 13);
            this.labelValidRegPass.TabIndex = 30;
            this.labelValidRegPass.Text = "Введите пароль";
            this.labelValidRegPass.Visible = false;
            // 
            // labelValidEmail
            // 
            this.labelValidEmail.AutoSize = true;
            this.labelValidEmail.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidEmail.ForeColor = System.Drawing.Color.Red;
            this.labelValidEmail.Location = new System.Drawing.Point(9, 243);
            this.labelValidEmail.Name = "labelValidEmail";
            this.labelValidEmail.Size = new System.Drawing.Size(93, 13);
            this.labelValidEmail.TabIndex = 31;
            this.labelValidEmail.Text = "Введите почту";
            this.labelValidEmail.Visible = false;
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Depth = 0;
            this.TextBoxLname.Hint = "Фамилия*";
            this.TextBoxLname.Location = new System.Drawing.Point(12, 94);
            this.TextBoxLname.MaxLength = 30;
            this.TextBoxLname.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.PasswordChar = '\0';
            this.TextBoxLname.SelectedText = "";
            this.TextBoxLname.SelectionLength = 0;
            this.TextBoxLname.SelectionStart = 0;
            this.TextBoxLname.Size = new System.Drawing.Size(180, 23);
            this.TextBoxLname.TabIndex = 36;
            this.TextBoxLname.TabStop = false;
            this.TextBoxLname.UseSystemPasswordChar = false;
            this.TextBoxLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLname_KeyPress);
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Depth = 0;
            this.TextBoxFname.Hint = "Имя*";
            this.TextBoxFname.Location = new System.Drawing.Point(209, 94);
            this.TextBoxFname.MaxLength = 30;
            this.TextBoxFname.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.PasswordChar = '\0';
            this.TextBoxFname.SelectedText = "";
            this.TextBoxFname.SelectionLength = 0;
            this.TextBoxFname.SelectionStart = 0;
            this.TextBoxFname.Size = new System.Drawing.Size(180, 23);
            this.TextBoxFname.TabIndex = 37;
            this.TextBoxFname.TabStop = false;
            this.TextBoxFname.UseSystemPasswordChar = false;
            this.TextBoxFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFname_KeyPress);
            // 
            // TextBoxMname
            // 
            this.TextBoxMname.Depth = 0;
            this.TextBoxMname.Hint = "Отчество";
            this.TextBoxMname.Location = new System.Drawing.Point(406, 94);
            this.TextBoxMname.MaxLength = 30;
            this.TextBoxMname.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxMname.Name = "TextBoxMname";
            this.TextBoxMname.PasswordChar = '\0';
            this.TextBoxMname.SelectedText = "";
            this.TextBoxMname.SelectionLength = 0;
            this.TextBoxMname.SelectionStart = 0;
            this.TextBoxMname.Size = new System.Drawing.Size(180, 23);
            this.TextBoxMname.TabIndex = 38;
            this.TextBoxMname.TabStop = false;
            this.TextBoxMname.UseSystemPasswordChar = false;
            this.TextBoxMname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMname_KeyPress);
            // 
            // TextBoxRegLog
            // 
            this.TextBoxRegLog.Depth = 0;
            this.TextBoxRegLog.Hint = "Логин*";
            this.TextBoxRegLog.Location = new System.Drawing.Point(12, 154);
            this.TextBoxRegLog.MaxLength = 30;
            this.TextBoxRegLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxRegLog.Name = "TextBoxRegLog";
            this.TextBoxRegLog.PasswordChar = '\0';
            this.TextBoxRegLog.SelectedText = "";
            this.TextBoxRegLog.SelectionLength = 0;
            this.TextBoxRegLog.SelectionStart = 0;
            this.TextBoxRegLog.Size = new System.Drawing.Size(180, 23);
            this.TextBoxRegLog.TabIndex = 39;
            this.TextBoxRegLog.TabStop = false;
            this.TextBoxRegLog.UseSystemPasswordChar = false;
            this.TextBoxRegLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRegLog_KeyPress);
            // 
            // TextBoxRegPass
            // 
            this.TextBoxRegPass.Depth = 0;
            this.TextBoxRegPass.Hint = "Пароль*";
            this.TextBoxRegPass.Location = new System.Drawing.Point(209, 154);
            this.TextBoxRegPass.MaxLength = 35;
            this.TextBoxRegPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxRegPass.Name = "TextBoxRegPass";
            this.TextBoxRegPass.PasswordChar = '\0';
            this.TextBoxRegPass.SelectedText = "";
            this.TextBoxRegPass.SelectionLength = 0;
            this.TextBoxRegPass.SelectionStart = 0;
            this.TextBoxRegPass.Size = new System.Drawing.Size(180, 23);
            this.TextBoxRegPass.TabIndex = 40;
            this.TextBoxRegPass.TabStop = false;
            this.TextBoxRegPass.UseSystemPasswordChar = true;
            this.TextBoxRegPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRegPass_KeyPress);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Depth = 0;
            this.TextBoxEmail.Hint = "Email*";
            this.TextBoxEmail.Location = new System.Drawing.Point(12, 217);
            this.TextBoxEmail.MaxLength = 31;
            this.TextBoxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.SelectedText = "";
            this.TextBoxEmail.SelectionLength = 0;
            this.TextBoxEmail.SelectionStart = 0;
            this.TextBoxEmail.Size = new System.Drawing.Size(180, 23);
            this.TextBoxEmail.TabIndex = 41;
            this.TextBoxEmail.TabStop = false;
            this.TextBoxEmail.UseSystemPasswordChar = false;
            this.TextBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEmail_KeyPress);
            // 
            // buttonReg
            // 
            this.buttonReg.AutoSize = true;
            this.buttonReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReg.Depth = 0;
            this.buttonReg.Icon = null;
            this.buttonReg.Location = new System.Drawing.Point(7, 272);
            this.buttonReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Primary = true;
            this.buttonReg.Size = new System.Drawing.Size(179, 36);
            this.buttonReg.TabIndex = 42;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.Depth = 0;
            this.buttonExit.Icon = null;
            this.buttonExit.Location = new System.Drawing.Point(518, 272);
            this.buttonExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Primary = true;
            this.buttonExit.Size = new System.Drawing.Size(68, 36);
            this.buttonExit.TabIndex = 43;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TextBoxRegPassRepeat
            // 
            this.TextBoxRegPassRepeat.Depth = 0;
            this.TextBoxRegPassRepeat.Hint = "Ещё раз пароль*";
            this.TextBoxRegPassRepeat.Location = new System.Drawing.Point(406, 154);
            this.TextBoxRegPassRepeat.MaxLength = 35;
            this.TextBoxRegPassRepeat.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxRegPassRepeat.Name = "TextBoxRegPassRepeat";
            this.TextBoxRegPassRepeat.PasswordChar = '\0';
            this.TextBoxRegPassRepeat.SelectedText = "";
            this.TextBoxRegPassRepeat.SelectionLength = 0;
            this.TextBoxRegPassRepeat.SelectionStart = 0;
            this.TextBoxRegPassRepeat.Size = new System.Drawing.Size(180, 23);
            this.TextBoxRegPassRepeat.TabIndex = 45;
            this.TextBoxRegPassRepeat.TabStop = false;
            this.TextBoxRegPassRepeat.UseSystemPasswordChar = true;
            this.TextBoxRegPassRepeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRegPassRepeat_KeyPress);
            // 
            // labelValidRegPassRepeat
            // 
            this.labelValidRegPassRepeat.AutoSize = true;
            this.labelValidRegPassRepeat.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidRegPassRepeat.ForeColor = System.Drawing.Color.Red;
            this.labelValidRegPassRepeat.Location = new System.Drawing.Point(406, 180);
            this.labelValidRegPassRepeat.Name = "labelValidRegPassRepeat";
            this.labelValidRegPassRepeat.Size = new System.Drawing.Size(154, 13);
            this.labelValidRegPassRepeat.TabIndex = 44;
            this.labelValidRegPassRepeat.Text = "Введите ещё раз пароль";
            this.labelValidRegPassRepeat.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(596, 317);
            this.Controls.Add(this.TextBoxRegPassRepeat);
            this.Controls.Add(this.labelValidRegPassRepeat);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxRegPass);
            this.Controls.Add(this.TextBoxRegLog);
            this.Controls.Add(this.TextBoxMname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.labelValidEmail);
            this.Controls.Add(this.labelValidRegPass);
            this.Controls.Add(this.labelValidRegLog);
            this.Controls.Add(this.labelValidFname);
            this.Controls.Add(this.labelValidLname);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Регистрация нового пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelValidLname;
        private System.Windows.Forms.Label labelValidFname;
        private System.Windows.Forms.Label labelValidRegLog;
        private System.Windows.Forms.Label labelValidRegPass;
        private System.Windows.Forms.Label labelValidEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxLname;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxFname;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxMname;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxRegLog;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxRegPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxEmail;
        private MaterialSkin.Controls.MaterialRaisedButton buttonReg;
        private MaterialSkin.Controls.MaterialRaisedButton buttonExit;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxRegPassRepeat;
        private System.Windows.Forms.Label labelValidRegPassRepeat;
    }
}