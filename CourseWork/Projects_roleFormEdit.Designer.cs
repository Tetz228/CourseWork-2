namespace CourseWork
{
    partial class Projects_roleFormEdit
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
            this.buttonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxEdit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(177, 158);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(95, 36);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Отменить";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEdit.Depth = 0;
            this.buttonEdit.Icon = null;
            this.buttonEdit.Location = new System.Drawing.Point(12, 158);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Primary = true;
            this.buttonEdit.Size = new System.Drawing.Size(95, 36);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Depth = 0;
            this.textBoxEdit.Hint = "Наименование";
            this.textBoxEdit.Location = new System.Drawing.Point(21, 102);
            this.textBoxEdit.MaxLength = 50;
            this.textBoxEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.PasswordChar = '\0';
            this.textBoxEdit.SelectedText = "";
            this.textBoxEdit.SelectionLength = 0;
            this.textBoxEdit.SelectionStart = 0;
            this.textBoxEdit.Size = new System.Drawing.Size(231, 23);
            this.textBoxEdit.TabIndex = 17;
            this.textBoxEdit.TabStop = false;
            this.textBoxEdit.UseSystemPasswordChar = false;
            this.textBoxEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdit_KeyPress);
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValid.ForeColor = System.Drawing.Color.Red;
            this.labelValid.Location = new System.Drawing.Point(18, 128);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(141, 13);
            this.labelValid.TabIndex = 46;
            this.labelValid.Text = "Некорректные данные";
            this.labelValid.Visible = false;
            // 
            // Projects_roleFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 200);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxEdit);
            this.MaximizeBox = false;
            this.Name = "Projects_roleFormEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить роль";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Projects_roleFormEdit_FormClosed);
            this.Load += new System.EventHandler(this.Projects_roleFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEdit;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEdit;
        private System.Windows.Forms.Label labelValid;
    }
}