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
            this.registrationLabelLink = new System.Windows.Forms.LinkLabel();
            this.ForgotPassLabelLink = new System.Windows.Forms.LinkLabel();
            this.TextBoxLog = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextBoxPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelValidAuthPass = new System.Windows.Forms.Label();
            this.labelValidAuthLog = new System.Windows.Forms.Label();
            this.pictureBoxShowHidePassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationLabelLink
            // 
            this.registrationLabelLink.ActiveLinkColor = System.Drawing.Color.White;
            this.registrationLabelLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationLabelLink.AutoSize = true;
            this.registrationLabelLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationLabelLink.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabelLink.ForeColor = System.Drawing.Color.White;
            this.registrationLabelLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.registrationLabelLink.LinkColor = System.Drawing.Color.White;
            this.registrationLabelLink.Location = new System.Drawing.Point(310, 109);
            this.registrationLabelLink.Name = "registrationLabelLink";
            this.registrationLabelLink.Size = new System.Drawing.Size(102, 14);
            this.registrationLabelLink.TabIndex = 4;
            this.registrationLabelLink.TabStop = true;
            this.registrationLabelLink.Text = "Нет аккаунта?";
            this.registrationLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrationLabelLink_LinkClicked);
            // 
            // ForgotPassLabelLink
            // 
            this.ForgotPassLabelLink.ActiveLinkColor = System.Drawing.Color.White;
            this.ForgotPassLabelLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForgotPassLabelLink.AutoSize = true;
            this.ForgotPassLabelLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPassLabelLink.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForgotPassLabelLink.ForeColor = System.Drawing.Color.White;
            this.ForgotPassLabelLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ForgotPassLabelLink.LinkColor = System.Drawing.Color.White;
            this.ForgotPassLabelLink.Location = new System.Drawing.Point(310, 181);
            this.ForgotPassLabelLink.Name = "ForgotPassLabelLink";
            this.ForgotPassLabelLink.Size = new System.Drawing.Size(111, 14);
            this.ForgotPassLabelLink.TabIndex = 5;
            this.ForgotPassLabelLink.TabStop = true;
            this.ForgotPassLabelLink.Text = "Забыли пароль?";
            this.ForgotPassLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassLabelLink_LinkClicked);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxLog.Depth = 0;
            this.TextBoxLog.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLog.Hint = "Логин";
            this.TextBoxLog.Location = new System.Drawing.Point(35, 105);
            this.TextBoxLog.MaxLength = 32767;
            this.TextBoxLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.PasswordChar = '\0';
            this.TextBoxLog.SelectedText = "";
            this.TextBoxLog.SelectionLength = 0;
            this.TextBoxLog.SelectionStart = 0;
            this.TextBoxLog.Size = new System.Drawing.Size(233, 23);
            this.TextBoxLog.TabIndex = 34;
            this.TextBoxLog.TabStop = false;
            this.TextBoxLog.UseSystemPasswordChar = false;
            this.TextBoxLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLog_KeyPress);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxPass.Depth = 0;
            this.TextBoxPass.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPass.Hint = "Пароль";
            this.TextBoxPass.Location = new System.Drawing.Point(35, 177);
            this.TextBoxPass.MaxLength = 32767;
            this.TextBoxPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '\0';
            this.TextBoxPass.SelectedText = "";
            this.TextBoxPass.SelectionLength = 0;
            this.TextBoxPass.SelectionStart = 0;
            this.TextBoxPass.Size = new System.Drawing.Size(233, 23);
            this.TextBoxPass.TabIndex = 36;
            this.TextBoxPass.TabStop = false;
            this.TextBoxPass.UseSystemPasswordChar = true;
            this.TextBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPass_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.Depth = 0;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Icon = null;
            this.buttonLogin.Location = new System.Drawing.Point(176, 242);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Primary = true;
            this.buttonLogin.Size = new System.Drawing.Size(67, 36);
            this.buttonLogin.TabIndex = 41;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelValidAuthPass
            // 
            this.labelValidAuthPass.AutoSize = true;
            this.labelValidAuthPass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidAuthPass.ForeColor = System.Drawing.Color.Red;
            this.labelValidAuthPass.Location = new System.Drawing.Point(32, 203);
            this.labelValidAuthPass.Name = "labelValidAuthPass";
            this.labelValidAuthPass.Size = new System.Drawing.Size(156, 14);
            this.labelValidAuthPass.TabIndex = 43;
            this.labelValidAuthPass.Text = "Некорректный пароль.";
            this.labelValidAuthPass.Visible = false;
            // 
            // labelValidAuthLog
            // 
            this.labelValidAuthLog.AutoSize = true;
            this.labelValidAuthLog.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidAuthLog.ForeColor = System.Drawing.Color.Red;
            this.labelValidAuthLog.Location = new System.Drawing.Point(32, 131);
            this.labelValidAuthLog.Name = "labelValidAuthLog";
            this.labelValidAuthLog.Size = new System.Drawing.Size(147, 14);
            this.labelValidAuthLog.TabIndex = 42;
            this.labelValidAuthLog.Text = "Некорректный логин.";
            this.labelValidAuthLog.Visible = false;
            // 
            // pictureBoxShowHidePassword
            // 
            this.pictureBoxShowHidePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxShowHidePassword.Image = global::CourseWork.Properties.Resources.HidePassword;
            this.pictureBoxShowHidePassword.Location = new System.Drawing.Point(275, 176);
            this.pictureBoxShowHidePassword.Name = "pictureBoxShowHidePassword";
            this.pictureBoxShowHidePassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxShowHidePassword.TabIndex = 44;
            this.pictureBoxShowHidePassword.TabStop = false;
            this.pictureBoxShowHidePassword.Click += new System.EventHandler(this.buttonShowHidePassword_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPassword.Image = global::CourseWork.Properties.Resources.Password1;
            this.pictureBoxPassword.Location = new System.Drawing.Point(5, 176);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPassword.TabIndex = 27;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogin.Image = global::CourseWork.Properties.Resources.Login1;
            this.pictureBoxLogin.Location = new System.Drawing.Point(5, 103);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxLogin.TabIndex = 26;
            this.pictureBoxLogin.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Location = new System.Drawing.Point(275, 176);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(24, 24);
            this.pictureBox.TabIndex = 44;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.buttonShowHidePassword_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(313, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(424, 290);
            this.Controls.Add(this.pictureBoxShowHidePassword);
            this.Controls.Add(this.labelValidAuthPass);
            this.Controls.Add(this.labelValidAuthLog);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLog);
            this.Controls.Add(this.ForgotPassLabelLink);
            this.Controls.Add(this.registrationLabelLink);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.pictureBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 290);
            this.Name = "AuthorizationForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.LinkLabel registrationLabelLink;
        private System.Windows.Forms.LinkLabel ForgotPassLabelLink;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxLog;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxPass;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLogin;
        private System.Windows.Forms.Label labelValidAuthPass;
        private System.Windows.Forms.Label labelValidAuthLog;
        private System.Windows.Forms.PictureBox pictureBoxShowHidePassword;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}