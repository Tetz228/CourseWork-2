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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.TextBoxMname = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxRegLog = new System.Windows.Forms.TextBox();
            this.TextBoxRegPass = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.labelDashLname = new System.Windows.Forms.Label();
            this.labelDashRegLog = new System.Windows.Forms.Label();
            this.labelDashFname = new System.Windows.Forms.Label();
            this.labelDashMname = new System.Windows.Forms.Label();
            this.labelDashRegPass = new System.Windows.Forms.Label();
            this.labelDashEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(234, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(234, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(234, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пароль";
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.BackColor = System.Drawing.Color.White;
            this.TextBoxLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLname.Location = new System.Drawing.Point(12, 88);
            this.TextBoxLname.Multiline = true;
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(180, 26);
            this.TextBoxLname.TabIndex = 12;
            this.TextBoxLname.Click += new System.EventHandler(this.TextBoxLname_Click);
            this.TextBoxLname.Leave += new System.EventHandler(this.TextBoxLname_Leave);
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.BackColor = System.Drawing.Color.White;
            this.TextBoxFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFname.Location = new System.Drawing.Point(12, 170);
            this.TextBoxFname.Multiline = true;
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(180, 26);
            this.TextBoxFname.TabIndex = 13;
            this.TextBoxFname.Click += new System.EventHandler(this.TextBoxFname_Click);
            this.TextBoxFname.Leave += new System.EventHandler(this.TextBoxFname_Leave);
            // 
            // TextBoxMname
            // 
            this.TextBoxMname.BackColor = System.Drawing.Color.White;
            this.TextBoxMname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxMname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMname.Location = new System.Drawing.Point(12, 241);
            this.TextBoxMname.Multiline = true;
            this.TextBoxMname.Name = "TextBoxMname";
            this.TextBoxMname.Size = new System.Drawing.Size(180, 26);
            this.TextBoxMname.TabIndex = 14;
            this.TextBoxMname.Click += new System.EventHandler(this.TextBoxMname_Click);
            this.TextBoxMname.Leave += new System.EventHandler(this.TextBoxMname_Leave);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.Color.White;
            this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEmail.Location = new System.Drawing.Point(237, 241);
            this.TextBoxEmail.Multiline = true;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(180, 26);
            this.TextBoxEmail.TabIndex = 15;
            this.TextBoxEmail.Click += new System.EventHandler(this.TextBoxEmail_Click);
            this.TextBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // TextBoxRegLog
            // 
            this.TextBoxRegLog.BackColor = System.Drawing.Color.White;
            this.TextBoxRegLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxRegLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxRegLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxRegLog.Location = new System.Drawing.Point(237, 88);
            this.TextBoxRegLog.Multiline = true;
            this.TextBoxRegLog.Name = "TextBoxRegLog";
            this.TextBoxRegLog.Size = new System.Drawing.Size(180, 26);
            this.TextBoxRegLog.TabIndex = 16;
            this.TextBoxRegLog.Click += new System.EventHandler(this.TextBoxRegLog_Click);
            this.TextBoxRegLog.Leave += new System.EventHandler(this.TextBoxRegLog_Leave);
            // 
            // TextBoxRegPass
            // 
            this.TextBoxRegPass.BackColor = System.Drawing.Color.White;
            this.TextBoxRegPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxRegPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxRegPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxRegPass.Location = new System.Drawing.Point(237, 170);
            this.TextBoxRegPass.Multiline = true;
            this.TextBoxRegPass.Name = "TextBoxRegPass";
            this.TextBoxRegPass.PasswordChar = '*';
            this.TextBoxRegPass.Size = new System.Drawing.Size(180, 26);
            this.TextBoxRegPass.TabIndex = 17;
            this.TextBoxRegPass.Click += new System.EventHandler(this.TextBoxRegPass_Click);
            this.TextBoxRegPass.Leave += new System.EventHandler(this.TextBoxRegPass_Leave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(234, 292);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExit.Size = new System.Drawing.Size(180, 40);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.Green;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(12, 292);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(190, 40);
            this.buttonReg.TabIndex = 18;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // labelDashLname
            // 
            this.labelDashLname.AutoSize = true;
            this.labelDashLname.Location = new System.Drawing.Point(9, 106);
            this.labelDashLname.Name = "labelDashLname";
            this.labelDashLname.Size = new System.Drawing.Size(178, 13);
            this.labelDashLname.TabIndex = 20;
            this.labelDashLname.Text = "---------------------------------------------------------";
            // 
            // labelDashRegLog
            // 
            this.labelDashRegLog.AutoSize = true;
            this.labelDashRegLog.Location = new System.Drawing.Point(234, 106);
            this.labelDashRegLog.Name = "labelDashRegLog";
            this.labelDashRegLog.Size = new System.Drawing.Size(178, 13);
            this.labelDashRegLog.TabIndex = 21;
            this.labelDashRegLog.Text = "---------------------------------------------------------";
            // 
            // labelDashFname
            // 
            this.labelDashFname.AutoSize = true;
            this.labelDashFname.Location = new System.Drawing.Point(9, 188);
            this.labelDashFname.Name = "labelDashFname";
            this.labelDashFname.Size = new System.Drawing.Size(178, 13);
            this.labelDashFname.TabIndex = 22;
            this.labelDashFname.Text = "---------------------------------------------------------";
            // 
            // labelDashMname
            // 
            this.labelDashMname.AutoSize = true;
            this.labelDashMname.Location = new System.Drawing.Point(9, 259);
            this.labelDashMname.Name = "labelDashMname";
            this.labelDashMname.Size = new System.Drawing.Size(178, 13);
            this.labelDashMname.TabIndex = 23;
            this.labelDashMname.Text = "---------------------------------------------------------";
            // 
            // labelDashRegPass
            // 
            this.labelDashRegPass.AutoSize = true;
            this.labelDashRegPass.Location = new System.Drawing.Point(231, 188);
            this.labelDashRegPass.Name = "labelDashRegPass";
            this.labelDashRegPass.Size = new System.Drawing.Size(178, 13);
            this.labelDashRegPass.TabIndex = 24;
            this.labelDashRegPass.Text = "---------------------------------------------------------";
            // 
            // labelDashEmail
            // 
            this.labelDashEmail.AutoSize = true;
            this.labelDashEmail.Location = new System.Drawing.Point(234, 259);
            this.labelDashEmail.Name = "labelDashEmail";
            this.labelDashEmail.Size = new System.Drawing.Size(178, 13);
            this.labelDashEmail.TabIndex = 25;
            this.labelDashEmail.Text = "---------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Verdana", 16F);
            this.label7.Location = new System.Drawing.Point(123, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "Регистрация";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 346);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDashEmail);
            this.Controls.Add(this.labelDashRegPass);
            this.Controls.Add(this.labelDashMname);
            this.Controls.Add(this.labelDashFname);
            this.Controls.Add(this.labelDashRegLog);
            this.Controls.Add(this.labelDashLname);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.TextBoxRegPass);
            this.Controls.Add(this.TextBoxRegLog);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxMname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxLname;
        private System.Windows.Forms.TextBox TextBoxFname;
        private System.Windows.Forms.TextBox TextBoxMname;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxRegLog;
        private System.Windows.Forms.TextBox TextBoxRegPass;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label labelDashLname;
        private System.Windows.Forms.Label labelDashRegLog;
        private System.Windows.Forms.Label labelDashFname;
        private System.Windows.Forms.Label labelDashMname;
        private System.Windows.Forms.Label labelDashRegPass;
        private System.Windows.Forms.Label labelDashEmail;
        private System.Windows.Forms.Label label7;
    }
}