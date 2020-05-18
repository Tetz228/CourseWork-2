namespace CourseWork
{
    partial class ForgotPassForm
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
            this.textBoxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonContinue = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainLabel = new MaterialSkin.Controls.MaterialLabel();
            this.labelValidEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Hint = "Введите почту";
            this.textBoxEmail.Location = new System.Drawing.Point(12, 153);
            this.textBoxEmail.MaxLength = 32767;
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.Size = new System.Drawing.Size(327, 23);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.UseSystemPasswordChar = false;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // buttonContinue
            // 
            this.buttonContinue.AutoSize = true;
            this.buttonContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonContinue.Depth = 0;
            this.buttonContinue.Icon = null;
            this.buttonContinue.Location = new System.Drawing.Point(12, 224);
            this.buttonContinue.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Primary = true;
            this.buttonContinue.Size = new System.Drawing.Size(118, 36);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(262, 224);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(77, 36);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Depth = 0;
            this.MainLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.MainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainLabel.Location = new System.Drawing.Point(13, 82);
            this.MainLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(117, 19);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Введите адрес ";
            // 
            // labelValidEmail
            // 
            this.labelValidEmail.AutoSize = true;
            this.labelValidEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidEmail.ForeColor = System.Drawing.Color.Red;
            this.labelValidEmail.Location = new System.Drawing.Point(94, 179);
            this.labelValidEmail.Name = "labelValidEmail";
            this.labelValidEmail.Size = new System.Drawing.Size(15, 14);
            this.labelValidEmail.TabIndex = 4;
            this.labelValidEmail.Text = "1";
            this.labelValidEmail.Visible = false;
            // 
            // ForgotPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(355, 272);
            this.Controls.Add(this.labelValidEmail);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.textBoxEmail);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ForgotPassForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Забыли пароль?";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPass_FormClosed);
            this.Load += new System.EventHandler(this.ForgotPassForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForgotPass_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ForgotPass_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmail;
        private MaterialSkin.Controls.MaterialRaisedButton buttonContinue;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialLabel MainLabel;
        private System.Windows.Forms.Label labelValidEmail;
    }
}