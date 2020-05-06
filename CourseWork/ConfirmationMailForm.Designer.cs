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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelConfirmationCode = new System.Windows.Forms.LinkLabel();
            this.labelDashConfirmationMail = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelConfirmationMail = new System.Windows.Forms.Label();
            this.buttonBackConfirmationMail = new System.Windows.Forms.Button();
            this.buttonConfirmationMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Подтверждение почты";
            // 
            // linkLabelConfirmationCode
            // 
            this.linkLabelConfirmationCode.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelConfirmationCode.AutoSize = true;
            this.linkLabelConfirmationCode.Font = new System.Drawing.Font("Verdana", 8F);
            this.linkLabelConfirmationCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelConfirmationCode.LinkColor = System.Drawing.Color.Black;
            this.linkLabelConfirmationCode.Location = new System.Drawing.Point(231, 95);
            this.linkLabelConfirmationCode.Name = "linkLabelConfirmationCode";
            this.linkLabelConfirmationCode.Size = new System.Drawing.Size(146, 13);
            this.linkLabelConfirmationCode.TabIndex = 2;
            this.linkLabelConfirmationCode.TabStop = true;
            this.linkLabelConfirmationCode.Text = "Отправить код ещё раз";
            this.linkLabelConfirmationCode.Click += new System.EventHandler(this.linkLabelConfirmationCode_Click);
            // 
            // labelDashConfirmationMail
            // 
            this.labelDashConfirmationMail.AutoSize = true;
            this.labelDashConfirmationMail.Location = new System.Drawing.Point(148, 106);
            this.labelDashConfirmationMail.Name = "labelDashConfirmationMail";
            this.labelDashConfirmationMail.Size = new System.Drawing.Size(70, 13);
            this.labelDashConfirmationMail.TabIndex = 41;
            this.labelDashConfirmationMail.Text = "---------------------";
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCode.ForeColor = System.Drawing.Color.White;
            this.textBoxCode.Location = new System.Drawing.Point(152, 88);
            this.textBoxCode.MaxLength = 6;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(64, 20);
            this.textBoxCode.TabIndex = 1;
            this.textBoxCode.Click += new System.EventHandler(this.textBoxCode_Click);
            this.textBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
            this.textBoxCode.Leave += new System.EventHandler(this.textBoxCode_Leave);
            // 
            // labelConfirmationMail
            // 
            this.labelConfirmationMail.AutoSize = true;
            this.labelConfirmationMail.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelConfirmationMail.ForeColor = System.Drawing.Color.Red;
            this.labelConfirmationMail.Location = new System.Drawing.Point(141, 119);
            this.labelConfirmationMail.Name = "labelConfirmationMail";
            this.labelConfirmationMail.Size = new System.Drawing.Size(92, 13);
            this.labelConfirmationMail.TabIndex = 39;
            this.labelConfirmationMail.Text = "Неверный код";
            this.labelConfirmationMail.Visible = false;
            // 
            // buttonBackConfirmationMail
            // 
            this.buttonBackConfirmationMail.BackColor = System.Drawing.Color.Red;
            this.buttonBackConfirmationMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackConfirmationMail.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonBackConfirmationMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackConfirmationMail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackConfirmationMail.ForeColor = System.Drawing.Color.White;
            this.buttonBackConfirmationMail.Location = new System.Drawing.Point(224, 175);
            this.buttonBackConfirmationMail.Name = "buttonBackConfirmationMail";
            this.buttonBackConfirmationMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBackConfirmationMail.Size = new System.Drawing.Size(150, 40);
            this.buttonBackConfirmationMail.TabIndex = 4;
            this.buttonBackConfirmationMail.Text = "Назад";
            this.buttonBackConfirmationMail.UseVisualStyleBackColor = false;
            this.buttonBackConfirmationMail.Click += new System.EventHandler(this.buttonBackConfirmationMail_Click);
            // 
            // buttonConfirmationMail
            // 
            this.buttonConfirmationMail.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConfirmationMail.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.buttonConfirmationMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmationMail.Font = new System.Drawing.Font("Verdana", 12F);
            this.buttonConfirmationMail.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmationMail.Location = new System.Drawing.Point(12, 175);
            this.buttonConfirmationMail.Name = "buttonConfirmationMail";
            this.buttonConfirmationMail.Size = new System.Drawing.Size(150, 40);
            this.buttonConfirmationMail.TabIndex = 3;
            this.buttonConfirmationMail.Text = "Подтвердить";
            this.buttonConfirmationMail.UseVisualStyleBackColor = false;
            this.buttonConfirmationMail.Click += new System.EventHandler(this.buttonConfirmationMail_Click);
            // 
            // ConfirmationMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(386, 226);
            this.Controls.Add(this.buttonBackConfirmationMail);
            this.Controls.Add(this.buttonConfirmationMail);
            this.Controls.Add(this.linkLabelConfirmationCode);
            this.Controls.Add(this.labelDashConfirmationMail);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelConfirmationMail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationMailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConfirmationMailForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfirmationMailForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfirmationMailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelConfirmationCode;
        private System.Windows.Forms.Label labelDashConfirmationMail;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelConfirmationMail;
        private System.Windows.Forms.Button buttonBackConfirmationMail;
        private System.Windows.Forms.Button buttonConfirmationMail;
    }
}