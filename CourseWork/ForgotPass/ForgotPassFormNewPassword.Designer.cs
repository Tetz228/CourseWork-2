namespace CourseWork.Authorization_Registration_ForgotPass.ForgotPass
{
    partial class ForgotPassFormNewPassword
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
            this.TextBoxNewPassRepeat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelValidPassRepeat = new System.Windows.Forms.Label();
            this.TextBoxNewPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelValidPass = new System.Windows.Forms.Label();
            this.pictureBoxShowHidePassword = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowHidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxNewPassRepeat
            // 
            this.TextBoxNewPassRepeat.Depth = 0;
            this.TextBoxNewPassRepeat.Hint = "Ещё раз пароль*";
            this.TextBoxNewPassRepeat.Location = new System.Drawing.Point(262, 111);
            this.TextBoxNewPassRepeat.MaxLength = 35;
            this.TextBoxNewPassRepeat.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxNewPassRepeat.Name = "TextBoxNewPassRepeat";
            this.TextBoxNewPassRepeat.PasswordChar = '\0';
            this.TextBoxNewPassRepeat.SelectedText = "";
            this.TextBoxNewPassRepeat.SelectionLength = 0;
            this.TextBoxNewPassRepeat.SelectionStart = 0;
            this.TextBoxNewPassRepeat.Size = new System.Drawing.Size(180, 23);
            this.TextBoxNewPassRepeat.TabIndex = 50;
            this.TextBoxNewPassRepeat.TabStop = false;
            this.TextBoxNewPassRepeat.UseSystemPasswordChar = true;
            this.TextBoxNewPassRepeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNewPassRepeat_KeyPress);
            // 
            // labelValidPassRepeat
            // 
            this.labelValidPassRepeat.AutoSize = true;
            this.labelValidPassRepeat.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidPassRepeat.ForeColor = System.Drawing.Color.Red;
            this.labelValidPassRepeat.Location = new System.Drawing.Point(259, 137);
            this.labelValidPassRepeat.Name = "labelValidPassRepeat";
            this.labelValidPassRepeat.Size = new System.Drawing.Size(154, 13);
            this.labelValidPassRepeat.TabIndex = 49;
            this.labelValidPassRepeat.Text = "Введите ещё раз пароль";
            this.labelValidPassRepeat.Visible = false;
            // 
            // TextBoxNewPass
            // 
            this.TextBoxNewPass.Depth = 0;
            this.TextBoxNewPass.Hint = "Пароль*";
            this.TextBoxNewPass.Location = new System.Drawing.Point(12, 111);
            this.TextBoxNewPass.MaxLength = 35;
            this.TextBoxNewPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxNewPass.Name = "TextBoxNewPass";
            this.TextBoxNewPass.PasswordChar = '\0';
            this.TextBoxNewPass.SelectedText = "";
            this.TextBoxNewPass.SelectionLength = 0;
            this.TextBoxNewPass.SelectionStart = 0;
            this.TextBoxNewPass.Size = new System.Drawing.Size(180, 23);
            this.TextBoxNewPass.TabIndex = 48;
            this.TextBoxNewPass.TabStop = false;
            this.TextBoxNewPass.UseSystemPasswordChar = true;
            this.TextBoxNewPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNewPass_KeyPress);
            // 
            // labelValidPass
            // 
            this.labelValidPass.AutoSize = true;
            this.labelValidPass.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidPass.ForeColor = System.Drawing.Color.Red;
            this.labelValidPass.Location = new System.Drawing.Point(9, 137);
            this.labelValidPass.Name = "labelValidPass";
            this.labelValidPass.Size = new System.Drawing.Size(102, 13);
            this.labelValidPass.TabIndex = 47;
            this.labelValidPass.Text = "Введите пароль";
            this.labelValidPass.Visible = false;
            // 
            // pictureBoxShowHidePassword
            // 
            this.pictureBoxShowHidePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxShowHidePassword.Image = global::CourseWork.Properties.Resources.HidePassword;
            this.pictureBoxShowHidePassword.Location = new System.Drawing.Point(198, 111);
            this.pictureBoxShowHidePassword.Name = "pictureBoxShowHidePassword";
            this.pictureBoxShowHidePassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxShowHidePassword.TabIndex = 51;
            this.pictureBoxShowHidePassword.TabStop = false;
            this.pictureBoxShowHidePassword.Click += new System.EventHandler(this.pictureBoxShowHidePassword_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdate.Depth = 0;
            this.buttonUpdate.Icon = null;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 203);
            this.buttonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Primary = true;
            this.buttonUpdate.Size = new System.Drawing.Size(121, 36);
            this.buttonUpdate.TabIndex = 52;
            this.buttonUpdate.Text = "Подтвердить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(365, 203);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(77, 36);
            this.buttonBack.TabIndex = 53;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ForgotPassFormNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 251);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.pictureBoxShowHidePassword);
            this.Controls.Add(this.TextBoxNewPassRepeat);
            this.Controls.Add(this.labelValidPassRepeat);
            this.Controls.Add(this.TextBoxNewPass);
            this.Controls.Add(this.labelValidPass);
            this.MaximizeBox = false;
            this.Name = "ForgotPassFormNewPassword";
            this.Text = "Введите новый пароль";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPassFormNewPassword_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowHidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShowHidePassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxNewPassRepeat;
        private System.Windows.Forms.Label labelValidPassRepeat;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxNewPass;
        private System.Windows.Forms.Label labelValidPass;
        private MaterialSkin.Controls.MaterialRaisedButton buttonUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
    }
}