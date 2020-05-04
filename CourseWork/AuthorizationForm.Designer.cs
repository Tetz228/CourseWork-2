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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.labelAuth = new System.Windows.Forms.Label();
            this.labelDashAuthLog = new System.Windows.Forms.Label();
            this.labelDashAuthPass = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.registrationLabelLink = new System.Windows.Forms.LinkLabel();
            this.ForgotPassLabelLink = new System.Windows.Forms.LinkLabel();
            this.labelValidAuthPass = new System.Windows.Forms.Label();
            this.labelValidAuthLog = new System.Windows.Forms.Label();
            this.pictureBoxAuthRollUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxAuthExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthRollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthExit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.Location = new System.Drawing.Point(92, 271);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(180, 40);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TextBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPass.ForeColor = System.Drawing.Color.White;
            this.TextBoxPass.Location = new System.Drawing.Point(31, 210);
            this.TextBoxPass.MaxLength = 25;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(234, 20);
            this.TextBoxPass.TabIndex = 2;
            this.TextBoxPass.UseSystemPasswordChar = true;
            this.TextBoxPass.WordWrap = false;
            this.TextBoxPass.Click += new System.EventHandler(this.TextBoxPass_Click);
            this.TextBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPass_KeyPress);
            this.TextBoxPass.Leave += new System.EventHandler(this.TextBoxPass_Leave);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLog.ForeColor = System.Drawing.Color.White;
            this.TextBoxLog.Location = new System.Drawing.Point(31, 117);
            this.TextBoxLog.MaxLength = 25;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(234, 20);
            this.TextBoxLog.TabIndex = 1;
            this.TextBoxLog.WordWrap = false;
            this.TextBoxLog.Click += new System.EventHandler(this.TextBoxLog_Click);
            this.TextBoxLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLog_KeyPress);
            this.TextBoxLog.Leave += new System.EventHandler(this.TextBoxLog_Leave);
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.ForeColor = System.Drawing.Color.White;
            this.labelAuth.Location = new System.Drawing.Point(86, 9);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(216, 32);
            this.labelAuth.TabIndex = 17;
            this.labelAuth.Text = "Авторизация";
            // 
            // labelDashAuthLog
            // 
            this.labelDashAuthLog.AutoSize = true;
            this.labelDashAuthLog.Location = new System.Drawing.Point(28, 136);
            this.labelDashAuthLog.Name = "labelDashAuthLog";
            this.labelDashAuthLog.Size = new System.Drawing.Size(244, 13);
            this.labelDashAuthLog.TabIndex = 21;
            this.labelDashAuthLog.Text = "-------------------------------------------------------------------------------";
            // 
            // labelDashAuthPass
            // 
            this.labelDashAuthPass.AutoSize = true;
            this.labelDashAuthPass.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDashAuthPass.Location = new System.Drawing.Point(28, 229);
            this.labelDashAuthPass.Name = "labelDashAuthPass";
            this.labelDashAuthPass.Size = new System.Drawing.Size(244, 15);
            this.labelDashAuthPass.TabIndex = 22;
            this.labelDashAuthPass.Text = "-------------------------------------------------------------------------------";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.ForeColor = System.Drawing.Color.White;
            this.labelLog.Location = new System.Drawing.Point(28, 87);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(58, 18);
            this.labelLog.TabIndex = 23;
            this.labelLog.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(28, 179);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(69, 18);
            this.labelPass.TabIndex = 24;
            this.labelPass.Text = "Пароль";
            // 
            // registrationLabelLink
            // 
            this.registrationLabelLink.ActiveLinkColor = System.Drawing.Color.White;
            this.registrationLabelLink.AutoSize = true;
            this.registrationLabelLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationLabelLink.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.registrationLabelLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.registrationLabelLink.LinkColor = System.Drawing.Color.Black;
            this.registrationLabelLink.Location = new System.Drawing.Point(278, 121);
            this.registrationLabelLink.Name = "registrationLabelLink";
            this.registrationLabelLink.Size = new System.Drawing.Size(91, 13);
            this.registrationLabelLink.TabIndex = 4;
            this.registrationLabelLink.TabStop = true;
            this.registrationLabelLink.Text = "Нет аккаунта?";
            this.registrationLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationLabelLink_LinkClicked);
            // 
            // ForgotPassLabelLink
            // 
            this.ForgotPassLabelLink.ActiveLinkColor = System.Drawing.Color.White;
            this.ForgotPassLabelLink.AutoSize = true;
            this.ForgotPassLabelLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPassLabelLink.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ForgotPassLabelLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ForgotPassLabelLink.LinkColor = System.Drawing.Color.Black;
            this.ForgotPassLabelLink.Location = new System.Drawing.Point(278, 217);
            this.ForgotPassLabelLink.Name = "ForgotPassLabelLink";
            this.ForgotPassLabelLink.Size = new System.Drawing.Size(103, 13);
            this.ForgotPassLabelLink.TabIndex = 5;
            this.ForgotPassLabelLink.TabStop = true;
            this.ForgotPassLabelLink.Text = "Забыли пароль?";
            this.ForgotPassLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassLabelLink_LinkClicked);
            // 
            // labelValidAuthPass
            // 
            this.labelValidAuthPass.AutoSize = true;
            this.labelValidAuthPass.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidAuthPass.ForeColor = System.Drawing.Color.Red;
            this.labelValidAuthPass.Location = new System.Drawing.Point(28, 244);
            this.labelValidAuthPass.Name = "labelValidAuthPass";
            this.labelValidAuthPass.Size = new System.Drawing.Size(138, 13);
            this.labelValidAuthPass.TabIndex = 32;
            this.labelValidAuthPass.Text = "Некорректный пароль";
            this.labelValidAuthPass.Visible = false;
            // 
            // labelValidAuthLog
            // 
            this.labelValidAuthLog.AutoSize = true;
            this.labelValidAuthLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidAuthLog.ForeColor = System.Drawing.Color.Red;
            this.labelValidAuthLog.Location = new System.Drawing.Point(28, 149);
            this.labelValidAuthLog.Name = "labelValidAuthLog";
            this.labelValidAuthLog.Size = new System.Drawing.Size(129, 13);
            this.labelValidAuthLog.TabIndex = 31;
            this.labelValidAuthLog.Text = "Некорректный логин";
            this.labelValidAuthLog.Visible = false;
            // 
            // pictureBoxAuthRollUp
            // 
            this.pictureBoxAuthRollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAuthRollUp.Image = global::CourseWork.Properties.Resources.RollUp;
            this.pictureBoxAuthRollUp.Location = new System.Drawing.Point(331, -2);
            this.pictureBoxAuthRollUp.Name = "pictureBoxAuthRollUp";
            this.pictureBoxAuthRollUp.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAuthRollUp.TabIndex = 33;
            this.pictureBoxAuthRollUp.TabStop = false;
            this.pictureBoxAuthRollUp.Click += new System.EventHandler(this.pictureBoxRollUp_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::CourseWork.Properties.Resources.Password1;
            this.pictureBoxPassword.Location = new System.Drawing.Point(2, 211);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPassword.TabIndex = 27;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::CourseWork.Properties.Resources.Login1;
            this.pictureBoxLogin.Location = new System.Drawing.Point(2, 116);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxLogin.TabIndex = 26;
            this.pictureBoxLogin.TabStop = false;
            // 
            // pictureBoxAuthExit
            // 
            this.pictureBoxAuthExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAuthExit.Image = global::CourseWork.Properties.Resources.Exit;
            this.pictureBoxAuthExit.Location = new System.Drawing.Point(358, -2);
            this.pictureBoxAuthExit.Name = "pictureBoxAuthExit";
            this.pictureBoxAuthExit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAuthExit.TabIndex = 25;
            this.pictureBoxAuthExit.TabStop = false;
            this.pictureBoxAuthExit.Click += new System.EventHandler(this.pictureBoxAuthExit_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(387, 323);
            this.Controls.Add(this.pictureBoxAuthRollUp);
            this.Controls.Add(this.labelValidAuthPass);
            this.Controls.Add(this.labelValidAuthLog);
            this.Controls.Add(this.ForgotPassLabelLink);
            this.Controls.Add(this.registrationLabelLink);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.pictureBoxAuthExit);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.labelDashAuthPass);
            this.Controls.Add(this.labelDashAuthLog);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthRollUp)).EndInit();
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
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label labelDashAuthLog;
        private System.Windows.Forms.Label labelDashAuthPass;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.PictureBox pictureBoxAuthExit;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.LinkLabel registrationLabelLink;
        private System.Windows.Forms.LinkLabel ForgotPassLabelLink;
        private System.Windows.Forms.Label labelValidAuthPass;
        private System.Windows.Forms.Label labelValidAuthLog;
        private System.Windows.Forms.PictureBox pictureBoxAuthRollUp;
    }
}