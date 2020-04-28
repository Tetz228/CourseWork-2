namespace CourseWork
{
    partial class AuthorizationForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.ForgotLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxAuthExit = new System.Windows.Forms.PictureBox();
            this.labelDashAuthLog = new System.Windows.Forms.Label();
            this.labelDashAuthPass = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthExit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Lime;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(32, 210);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(180, 40);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.BackColor = System.Drawing.Color.White;
            this.TextBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPass.Location = new System.Drawing.Point(32, 168);
            this.TextBoxPass.Multiline = true;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(180, 26);
            this.TextBoxPass.TabIndex = 8;
            this.TextBoxPass.Click += new System.EventHandler(this.TextBoxPass_Click);
            this.TextBoxPass.Leave += new System.EventHandler(this.TextBoxPass_Leave);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.BackColor = System.Drawing.Color.White;
            this.TextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLog.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLog.Location = new System.Drawing.Point(32, 90);
            this.TextBoxLog.Multiline = true;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(180, 26);
            this.TextBoxLog.TabIndex = 7;
            this.TextBoxLog.Click += new System.EventHandler(this.TextBoxLog_Click);
            this.TextBoxLog.Leave += new System.EventHandler(this.TextBoxLog_Leave);
            // 
            // ForgotLabel
            // 
            this.ForgotLabel.AutoSize = true;
            this.ForgotLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForgotLabel.ForeColor = System.Drawing.Color.Black;
            this.ForgotLabel.Location = new System.Drawing.Point(226, 173);
            this.ForgotLabel.Name = "ForgotLabel";
            this.ForgotLabel.Size = new System.Drawing.Size(103, 13);
            this.ForgotLabel.TabIndex = 13;
            this.ForgotLabel.Text = "Забыли пароль?";
            this.ForgotLabel.MouseLeave += new System.EventHandler(this.ForgotLabel_MouseLeave);
            this.ForgotLabel.MouseHover += new System.EventHandler(this.ForgotLabel_MouseHover);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registrationLabel.Location = new System.Drawing.Point(226, 95);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(91, 13);
            this.registrationLabel.TabIndex = 14;
            this.registrationLabel.Text = "Нет аккаунта?";
            this.registrationLabel.Click += new System.EventHandler(this.registrationLabel_Click);
            this.registrationLabel.MouseLeave += new System.EventHandler(this.registrationLabel_MouseLeave);
            this.registrationLabel.MouseHover += new System.EventHandler(this.registrationLabel_MouseHover);
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Enabled = false;
            this.labelAuth.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(85, 3);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(171, 29);
            this.labelAuth.TabIndex = 17;
            this.labelAuth.Text = "Авторизация";
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::CourseWork.Properties.Resources.Password;
            this.pictureBoxPassword.Location = new System.Drawing.Point(6, 170);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxPassword.TabIndex = 16;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::CourseWork.Properties.Resources.Login;
            this.pictureBoxLogin.Location = new System.Drawing.Point(6, 90);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLogin.TabIndex = 15;
            this.pictureBoxLogin.TabStop = false;
            // 
            // pictureBoxAuthExit
            // 
            this.pictureBoxAuthExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAuthExit.Image = global::CourseWork.Properties.Resources.Exit;
            this.pictureBoxAuthExit.Location = new System.Drawing.Point(303, -1);
            this.pictureBoxAuthExit.Name = "pictureBoxAuthExit";
            this.pictureBoxAuthExit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAuthExit.TabIndex = 18;
            this.pictureBoxAuthExit.TabStop = false;
            this.pictureBoxAuthExit.Click += new System.EventHandler(this.pictureBoxAuthExit_Click);
            // 
            // labelDashAuthLog
            // 
            this.labelDashAuthLog.AutoSize = true;
            this.labelDashAuthLog.Location = new System.Drawing.Point(33, 106);
            this.labelDashAuthLog.Name = "labelDashAuthLog";
            this.labelDashAuthLog.Size = new System.Drawing.Size(178, 13);
            this.labelDashAuthLog.TabIndex = 21;
            this.labelDashAuthLog.Text = "---------------------------------------------------------";
            // 
            // labelDashAuthPass
            // 
            this.labelDashAuthPass.AutoSize = true;
            this.labelDashAuthPass.Location = new System.Drawing.Point(33, 184);
            this.labelDashAuthPass.Name = "labelDashAuthPass";
            this.labelDashAuthPass.Size = new System.Drawing.Size(178, 13);
            this.labelDashAuthPass.TabIndex = 22;
            this.labelDashAuthPass.Text = "---------------------------------------------------------";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Enabled = false;
            this.labelLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.Location = new System.Drawing.Point(33, 55);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(58, 18);
            this.labelLog.TabIndex = 23;
            this.labelLog.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Enabled = false;
            this.labelPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(33, 134);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(69, 18);
            this.labelPass.TabIndex = 24;
            this.labelPass.Text = "Пароль";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 263);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.labelDashAuthPass);
            this.Controls.Add(this.labelDashAuthLog);
            this.Controls.Add(this.pictureBoxAuthExit);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.ForgotLabel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.Label ForgotLabel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.PictureBox pictureBoxAuthExit;
        private System.Windows.Forms.Label labelDashAuthLog;
        private System.Windows.Forms.Label labelDashAuthPass;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPass;
    }
}