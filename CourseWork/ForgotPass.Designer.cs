namespace CourseWork
{
    partial class ForgotPass
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
            this.FurtherEmail = new System.Windows.Forms.Button();
            this.buttonBackEmail = new System.Windows.Forms.Button();
            this.pictureBoxForgotRollUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxForgotExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValidEmail = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.labelDashEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelEntryСode = new System.Windows.Forms.Panel();
            this.panelNewPass = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewPassAgain = new System.Windows.Forms.TextBox();
            this.buttonBackPass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBackCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.panelFurther = new System.Windows.Forms.Button();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForgotRollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForgotExit)).BeginInit();
            this.panelEntryСode.SuspendLayout();
            this.panelNewPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // FurtherEmail
            // 
            this.FurtherEmail.Location = new System.Drawing.Point(12, 194);
            this.FurtherEmail.Name = "FurtherEmail";
            this.FurtherEmail.Size = new System.Drawing.Size(75, 23);
            this.FurtherEmail.TabIndex = 1;
            this.FurtherEmail.Text = "Далее";
            this.FurtherEmail.UseVisualStyleBackColor = true;
            this.FurtherEmail.Click += new System.EventHandler(this.Further_Click);
            // 
            // buttonBackEmail
            // 
            this.buttonBackEmail.Location = new System.Drawing.Point(324, 194);
            this.buttonBackEmail.Name = "buttonBackEmail";
            this.buttonBackEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonBackEmail.TabIndex = 3;
            this.buttonBackEmail.Text = "Назад";
            this.buttonBackEmail.UseVisualStyleBackColor = true;
            this.buttonBackEmail.Click += new System.EventHandler(this.buttonBackEmail_Click);
            // 
            // pictureBoxForgotRollUp
            // 
            this.pictureBoxForgotRollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForgotRollUp.Image = global::CourseWork.Properties.Resources.RollUp;
            this.pictureBoxForgotRollUp.Location = new System.Drawing.Point(345, -2);
            this.pictureBoxForgotRollUp.Name = "pictureBoxForgotRollUp";
            this.pictureBoxForgotRollUp.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxForgotRollUp.TabIndex = 35;
            this.pictureBoxForgotRollUp.TabStop = false;
            // 
            // pictureBoxForgotExit
            // 
            this.pictureBoxForgotExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxForgotExit.Image = global::CourseWork.Properties.Resources.Exit;
            this.pictureBoxForgotExit.Location = new System.Drawing.Point(374, -2);
            this.pictureBoxForgotExit.Name = "pictureBoxForgotExit";
            this.pictureBoxForgotExit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxForgotExit.TabIndex = 34;
            this.pictureBoxForgotExit.TabStop = false;
            this.pictureBoxForgotExit.Click += new System.EventHandler(this.pictureBoxForgotExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Укажите почту";
            // 
            // labelValidEmail
            // 
            this.labelValidEmail.AutoSize = true;
            this.labelValidEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidEmail.ForeColor = System.Drawing.Color.Red;
            this.labelValidEmail.Location = new System.Drawing.Point(9, 135);
            this.labelValidEmail.Name = "labelValidEmail";
            this.labelValidEmail.Size = new System.Drawing.Size(154, 13);
            this.labelValidEmail.TabIndex = 37;
            this.labelValidEmail.Text = "Пользователь не найден";
            this.labelValidEmail.Visible = false;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEmail.ForeColor = System.Drawing.Color.White;
            this.TextBoxEmail.Location = new System.Drawing.Point(12, 103);
            this.TextBoxEmail.MaxLength = 31;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(193, 20);
            this.TextBoxEmail.TabIndex = 38;
            this.TextBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEmail_Code_KeyPress);
            // 
            // labelDashEmail
            // 
            this.labelDashEmail.AutoSize = true;
            this.labelDashEmail.Location = new System.Drawing.Point(9, 124);
            this.labelDashEmail.Name = "labelDashEmail";
            this.labelDashEmail.Size = new System.Drawing.Size(205, 13);
            this.labelDashEmail.TabIndex = 39;
            this.labelDashEmail.Text = "------------------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Восстановление пароля";
            // 
            // panelEntryСode
            // 
            this.panelEntryСode.Controls.Add(this.panelNewPass);
            this.panelEntryСode.Controls.Add(this.buttonBackCode);
            this.panelEntryСode.Controls.Add(this.label3);
            this.panelEntryСode.Controls.Add(this.labelCode);
            this.panelEntryСode.Controls.Add(this.panelFurther);
            this.panelEntryСode.Controls.Add(this.TextBoxCode);
            this.panelEntryСode.Controls.Add(this.label2);
            this.panelEntryСode.Location = new System.Drawing.Point(106, 37);
            this.panelEntryСode.Name = "panelEntryСode";
            this.panelEntryСode.Size = new System.Drawing.Size(404, 180);
            this.panelEntryСode.TabIndex = 41;
            this.panelEntryСode.Visible = false;
            // 
            // panelNewPass
            // 
            this.panelNewPass.Controls.Add(this.label8);
            this.panelNewPass.Controls.Add(this.label5);
            this.panelNewPass.Controls.Add(this.textBoxNewPassAgain);
            this.panelNewPass.Controls.Add(this.buttonBackPass);
            this.panelNewPass.Controls.Add(this.label4);
            this.panelNewPass.Controls.Add(this.button2);
            this.panelNewPass.Controls.Add(this.textBoxNewPass);
            this.panelNewPass.Controls.Add(this.label6);
            this.panelNewPass.Location = new System.Drawing.Point(182, 3);
            this.panelNewPass.Name = "panelNewPass";
            this.panelNewPass.Size = new System.Drawing.Size(399, 178);
            this.panelNewPass.TabIndex = 44;
            this.panelNewPass.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "Введите пароль ещё раз";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "------------------------------------------------";
            // 
            // textBoxNewPassAgain
            // 
            this.textBoxNewPassAgain.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxNewPassAgain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassAgain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNewPassAgain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassAgain.ForeColor = System.Drawing.Color.White;
            this.textBoxNewPassAgain.Location = new System.Drawing.Point(12, 100);
            this.textBoxNewPassAgain.MaxLength = 25;
            this.textBoxNewPassAgain.Name = "textBoxNewPassAgain";
            this.textBoxNewPassAgain.Size = new System.Drawing.Size(234, 20);
            this.textBoxNewPassAgain.TabIndex = 44;
            this.textBoxNewPassAgain.UseSystemPasswordChar = true;
            // 
            // buttonBackPass
            // 
            this.buttonBackPass.Location = new System.Drawing.Point(321, 155);
            this.buttonBackPass.Name = "buttonBackPass";
            this.buttonBackPass.Size = new System.Drawing.Size(75, 23);
            this.buttonBackPass.TabIndex = 43;
            this.buttonBackPass.Text = "Назад";
            this.buttonBackPass.UseVisualStyleBackColor = true;
            this.buttonBackPass.Click += new System.EventHandler(this.buttonBackPass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "------------------------------------------------";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNewPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPass.ForeColor = System.Drawing.Color.White;
            this.textBoxNewPass.Location = new System.Drawing.Point(12, 34);
            this.textBoxNewPass.MaxLength = 25;
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(234, 20);
            this.textBoxNewPass.TabIndex = 39;
            this.textBoxNewPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Введите новый пароль";
            // 
            // buttonBackCode
            // 
            this.buttonBackCode.Location = new System.Drawing.Point(324, 157);
            this.buttonBackCode.Name = "buttonBackCode";
            this.buttonBackCode.Size = new System.Drawing.Size(75, 23);
            this.buttonBackCode.TabIndex = 43;
            this.buttonBackCode.Text = "Назад";
            this.buttonBackCode.UseVisualStyleBackColor = true;
            this.buttonBackCode.Click += new System.EventHandler(this.buttonBackCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "----------------------";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCode.ForeColor = System.Drawing.Color.Red;
            this.labelCode.Location = new System.Drawing.Point(9, 98);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(92, 13);
            this.labelCode.TabIndex = 41;
            this.labelCode.Text = "Неверный код";
            this.labelCode.Visible = false;
            // 
            // panelFurther
            // 
            this.panelFurther.Location = new System.Drawing.Point(12, 157);
            this.panelFurther.Name = "panelFurther";
            this.panelFurther.Size = new System.Drawing.Size(75, 23);
            this.panelFurther.TabIndex = 40;
            this.panelFurther.Text = "Далее";
            this.panelFurther.UseVisualStyleBackColor = true;
            this.panelFurther.Click += new System.EventHandler(this.panelFurther_Click);
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCode.ForeColor = System.Drawing.Color.White;
            this.TextBoxCode.Location = new System.Drawing.Point(12, 66);
            this.TextBoxCode.MaxLength = 6;
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(66, 20);
            this.TextBoxCode.TabIndex = 39;
            this.TextBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите код подтверждения";
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(403, 226);
            this.Controls.Add(this.panelEntryСode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDashEmail);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.labelValidEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxForgotRollUp);
            this.Controls.Add(this.pictureBoxForgotExit);
            this.Controls.Add(this.buttonBackEmail);
            this.Controls.Add(this.FurtherEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ForgotPass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPass_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForgotPass_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ForgotPass_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForgotRollUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForgotExit)).EndInit();
            this.panelEntryСode.ResumeLayout(false);
            this.panelEntryСode.PerformLayout();
            this.panelNewPass.ResumeLayout(false);
            this.panelNewPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FurtherEmail;
        private System.Windows.Forms.Button buttonBackEmail;
        private System.Windows.Forms.PictureBox pictureBoxForgotRollUp;
        private System.Windows.Forms.PictureBox pictureBoxForgotExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValidEmail;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label labelDashEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelEntryСode;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button panelFurther;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Button buttonBackCode;
        private System.Windows.Forms.Panel panelNewPass;
        private System.Windows.Forms.Button buttonBackPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewPassAgain;
        private System.Windows.Forms.Label label8;
    }
}