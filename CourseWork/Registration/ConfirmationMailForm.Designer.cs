namespace CourseWork
{
    partial class ConfirmationMailForm
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
            this.linkLabelConfirmationCode = new System.Windows.Forms.LinkLabel();
            this.labelConfirmationMail = new System.Windows.Forms.Label();
            this.textBoxCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonConfirmationMail = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBackConfirmationMail = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // linkLabelConfirmationCode
            // 
            this.linkLabelConfirmationCode.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelConfirmationCode.AutoSize = true;
            this.linkLabelConfirmationCode.Font = new System.Drawing.Font("Verdana", 8F);
            this.linkLabelConfirmationCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelConfirmationCode.LinkColor = System.Drawing.Color.White;
            this.linkLabelConfirmationCode.Location = new System.Drawing.Point(214, 108);
            this.linkLabelConfirmationCode.Name = "linkLabelConfirmationCode";
            this.linkLabelConfirmationCode.Size = new System.Drawing.Size(146, 13);
            this.linkLabelConfirmationCode.TabIndex = 2;
            this.linkLabelConfirmationCode.TabStop = true;
            this.linkLabelConfirmationCode.Text = "Отправить код ещё раз";
            this.linkLabelConfirmationCode.Click += new System.EventHandler(this.linkLabelConfirmationCode_Click);
            // 
            // labelConfirmationMail
            // 
            this.labelConfirmationMail.AutoSize = true;
            this.labelConfirmationMail.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelConfirmationMail.ForeColor = System.Drawing.Color.Red;
            this.labelConfirmationMail.Location = new System.Drawing.Point(125, 127);
            this.labelConfirmationMail.Name = "labelConfirmationMail";
            this.labelConfirmationMail.Size = new System.Drawing.Size(92, 13);
            this.labelConfirmationMail.TabIndex = 39;
            this.labelConfirmationMail.Text = "Неверный код";
            this.labelConfirmationMail.Visible = false;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Depth = 0;
            this.textBoxCode.Hint = "";
            this.textBoxCode.Location = new System.Drawing.Point(133, 101);
            this.textBoxCode.MaxLength = 6;
            this.textBoxCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.PasswordChar = '\0';
            this.textBoxCode.SelectedText = "";
            this.textBoxCode.SelectionLength = 0;
            this.textBoxCode.SelectionStart = 0;
            this.textBoxCode.Size = new System.Drawing.Size(75, 23);
            this.textBoxCode.TabIndex = 42;
            this.textBoxCode.TabStop = false;
            this.textBoxCode.UseSystemPasswordChar = false;
            this.textBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
            // 
            // buttonConfirmationMail
            // 
            this.buttonConfirmationMail.AutoSize = true;
            this.buttonConfirmationMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConfirmationMail.Depth = 0;
            this.buttonConfirmationMail.Icon = null;
            this.buttonConfirmationMail.Location = new System.Drawing.Point(12, 162);
            this.buttonConfirmationMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonConfirmationMail.Name = "buttonConfirmationMail";
            this.buttonConfirmationMail.Primary = true;
            this.buttonConfirmationMail.Size = new System.Drawing.Size(121, 36);
            this.buttonConfirmationMail.TabIndex = 43;
            this.buttonConfirmationMail.Text = "Подтвердить";
            this.buttonConfirmationMail.UseVisualStyleBackColor = true;
            this.buttonConfirmationMail.Click += new System.EventHandler(this.buttonConfirmationMail_Click);
            // 
            // buttonBackConfirmationMail
            // 
            this.buttonBackConfirmationMail.AutoSize = true;
            this.buttonBackConfirmationMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBackConfirmationMail.Depth = 0;
            this.buttonBackConfirmationMail.Icon = null;
            this.buttonBackConfirmationMail.Location = new System.Drawing.Point(286, 162);
            this.buttonBackConfirmationMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBackConfirmationMail.Name = "buttonBackConfirmationMail";
            this.buttonBackConfirmationMail.Primary = true;
            this.buttonBackConfirmationMail.Size = new System.Drawing.Size(68, 36);
            this.buttonBackConfirmationMail.TabIndex = 44;
            this.buttonBackConfirmationMail.Text = "Назад";
            this.buttonBackConfirmationMail.UseVisualStyleBackColor = true;
            this.buttonBackConfirmationMail.Click += new System.EventHandler(this.buttonBackConfirmationMail_Click);
            // 
            // ConfirmationMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(366, 210);
            this.Controls.Add(this.buttonBackConfirmationMail);
            this.Controls.Add(this.buttonConfirmationMail);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.linkLabelConfirmationCode);
            this.Controls.Add(this.labelConfirmationMail);
            this.MaximizeBox = false;
            this.Name = "ConfirmationMailForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Подтверждение почты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfirmationMailForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfirmationMailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelConfirmationCode;
        private System.Windows.Forms.Label labelConfirmationMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxCode;
        private MaterialSkin.Controls.MaterialRaisedButton buttonConfirmationMail;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBackConfirmationMail;
    }
}