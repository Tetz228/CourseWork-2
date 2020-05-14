namespace CourseWork
{
    partial class EmployeesFormEdit
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
            this.labelMname = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxFname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxMname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxLname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // labelMname
            // 
            this.labelMname.AutoSize = true;
            this.labelMname.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelMname.ForeColor = System.Drawing.Color.Red;
            this.labelMname.Location = new System.Drawing.Point(9, 178);
            this.labelMname.Name = "labelMname";
            this.labelMname.Size = new System.Drawing.Size(145, 13);
            this.labelMname.TabIndex = 19;
            this.labelMname.Text = "Некорректное отчество";
            this.labelMname.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelEmail.ForeColor = System.Drawing.Color.Red;
            this.labelEmail.Location = new System.Drawing.Point(201, 178);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(127, 13);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "Некорректная почта";
            this.labelEmail.Visible = false;
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelFname.ForeColor = System.Drawing.Color.Red;
            this.labelFname.Location = new System.Drawing.Point(201, 118);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(115, 13);
            this.labelFname.TabIndex = 17;
            this.labelFname.Text = "Некорректное имя";
            this.labelFname.Visible = false;
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelLname.ForeColor = System.Drawing.Color.Red;
            this.labelLname.Location = new System.Drawing.Point(9, 118);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(145, 13);
            this.labelLname.TabIndex = 16;
            this.labelLname.Text = "Некорректная фамилия";
            this.labelLname.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(281, 214);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(95, 36);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Отменить";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(12, 214);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(94, 36);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxFname
            // 
            this.textBoxFname.Depth = 0;
            this.textBoxFname.Hint = "Имя";
            this.textBoxFname.Location = new System.Drawing.Point(204, 92);
            this.textBoxFname.MaxLength = 30;
            this.textBoxFname.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.PasswordChar = '\0';
            this.textBoxFname.SelectedText = "";
            this.textBoxFname.SelectionLength = 0;
            this.textBoxFname.SelectionStart = 0;
            this.textBoxFname.Size = new System.Drawing.Size(172, 23);
            this.textBoxFname.TabIndex = 13;
            this.textBoxFname.TabStop = false;
            this.textBoxFname.UseSystemPasswordChar = false;
            this.textBoxFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFname_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Hint = "Почта";
            this.textBoxEmail.Location = new System.Drawing.Point(204, 152);
            this.textBoxEmail.MaxLength = 31;
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.Size = new System.Drawing.Size(172, 23);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.UseSystemPasswordChar = false;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEmail_KeyPress);
            // 
            // textBoxMname
            // 
            this.textBoxMname.Depth = 0;
            this.textBoxMname.Hint = "Отчество";
            this.textBoxMname.Location = new System.Drawing.Point(12, 152);
            this.textBoxMname.MaxLength = 30;
            this.textBoxMname.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMname.Name = "textBoxMname";
            this.textBoxMname.PasswordChar = '\0';
            this.textBoxMname.SelectedText = "";
            this.textBoxMname.SelectionLength = 0;
            this.textBoxMname.SelectionStart = 0;
            this.textBoxMname.Size = new System.Drawing.Size(172, 23);
            this.textBoxMname.TabIndex = 11;
            this.textBoxMname.TabStop = false;
            this.textBoxMname.UseSystemPasswordChar = false;
            this.textBoxMname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMname_KeyPress);
            // 
            // textBoxLname
            // 
            this.textBoxLname.Depth = 0;
            this.textBoxLname.Hint = "Фамилия";
            this.textBoxLname.Location = new System.Drawing.Point(12, 92);
            this.textBoxLname.MaxLength = 30;
            this.textBoxLname.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.PasswordChar = '\0';
            this.textBoxLname.SelectedText = "";
            this.textBoxLname.SelectionLength = 0;
            this.textBoxLname.SelectionStart = 0;
            this.textBoxLname.Size = new System.Drawing.Size(172, 23);
            this.textBoxLname.TabIndex = 10;
            this.textBoxLname.TabStop = false;
            this.textBoxLname.UseSystemPasswordChar = false;
            this.textBoxLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLname_KeyPress);
            // 
            // EmployeesFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 265);
            this.Controls.Add(this.labelMname);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMname);
            this.Controls.Add(this.textBoxLname);
            this.MaximizeBox = false;
            this.Name = "EmployeesFormEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить сотрудника";
            this.Load += new System.EventHandler(this.EmployeesFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMname;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxFname;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxMname;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxLname;
    }
}