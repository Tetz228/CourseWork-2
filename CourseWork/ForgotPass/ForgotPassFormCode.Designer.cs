namespace CourseWork.Authorization_Registration_Forgot_pass
{
    partial class ForgotPassFormCode
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
            this.buttonContinue = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.linkLabelConfirmationCode = new System.Windows.Forms.LinkLabel();
            this.labelConfirmationMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(241, 175);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(77, 36);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.AutoSize = true;
            this.buttonContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonContinue.Depth = 0;
            this.buttonContinue.Icon = null;
            this.buttonContinue.Location = new System.Drawing.Point(12, 175);
            this.buttonContinue.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Primary = true;
            this.buttonContinue.Size = new System.Drawing.Size(118, 36);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Depth = 0;
            this.textBoxCode.Hint = "";
            this.textBoxCode.Location = new System.Drawing.Point(107, 104);
            this.textBoxCode.MaxLength = 6;
            this.textBoxCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.PasswordChar = '\0';
            this.textBoxCode.SelectedText = "";
            this.textBoxCode.SelectionLength = 0;
            this.textBoxCode.SelectionStart = 0;
            this.textBoxCode.Size = new System.Drawing.Size(89, 23);
            this.textBoxCode.TabIndex = 45;
            this.textBoxCode.TabStop = false;
            this.textBoxCode.UseSystemPasswordChar = false;
            this.textBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
            // 
            // linkLabelConfirmationCode
            // 
            this.linkLabelConfirmationCode.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelConfirmationCode.AutoSize = true;
            this.linkLabelConfirmationCode.Font = new System.Drawing.Font("Verdana", 8F);
            this.linkLabelConfirmationCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelConfirmationCode.LinkColor = System.Drawing.Color.White;
            this.linkLabelConfirmationCode.Location = new System.Drawing.Point(202, 102);
            this.linkLabelConfirmationCode.Name = "linkLabelConfirmationCode";
            this.linkLabelConfirmationCode.Size = new System.Drawing.Size(146, 13);
            this.linkLabelConfirmationCode.TabIndex = 43;
            this.linkLabelConfirmationCode.TabStop = true;
            this.linkLabelConfirmationCode.Text = "Отправить код ещё раз";
            this.linkLabelConfirmationCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelConfirmationCode_LinkClicked);
            // 
            // labelConfirmationMail
            // 
            this.labelConfirmationMail.AutoSize = true;
            this.labelConfirmationMail.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelConfirmationMail.ForeColor = System.Drawing.Color.Red;
            this.labelConfirmationMail.Location = new System.Drawing.Point(104, 130);
            this.labelConfirmationMail.Name = "labelConfirmationMail";
            this.labelConfirmationMail.Size = new System.Drawing.Size(92, 13);
            this.labelConfirmationMail.TabIndex = 44;
            this.labelConfirmationMail.Text = "Неверный код";
            this.labelConfirmationMail.Visible = false;
            // 
            // ForgotPassFormCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 223);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.linkLabelConfirmationCode);
            this.Controls.Add(this.labelConfirmationMail);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonContinue);
            this.MaximizeBox = false;
            this.Name = "ForgotPassFormCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Введите код безопасности";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPassFormCode_FormClosed);
            this.Load += new System.EventHandler(this.ForgotPassFormCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonContinue;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxCode;
        private System.Windows.Forms.LinkLabel linkLabelConfirmationCode;
        private System.Windows.Forms.Label labelConfirmationMail;
    }
}