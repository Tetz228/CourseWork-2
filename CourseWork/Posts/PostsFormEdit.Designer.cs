namespace CourseWork.Posts
{
    partial class PostsFormEdit
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
            this.labelValid = new System.Windows.Forms.Label();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxEdit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValid.ForeColor = System.Drawing.Color.Red;
            this.labelValid.Location = new System.Drawing.Point(99, 130);
            this.labelValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(174, 13);
            this.labelValid.TabIndex = 49;
            this.labelValid.Text = "Поле не может быть пустым.";
            this.labelValid.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(262, 170);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(95, 36);
            this.buttonBack.TabIndex = 48;
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
            this.buttonEdit.Location = new System.Drawing.Point(13, 170);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Primary = true;
            this.buttonEdit.Size = new System.Drawing.Size(95, 36);
            this.buttonEdit.TabIndex = 47;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Depth = 0;
            this.textBoxEdit.Hint = "Наименование";
            this.textBoxEdit.Location = new System.Drawing.Point(11, 103);
            this.textBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEdit.MaxLength = 35;
            this.textBoxEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.PasswordChar = '\0';
            this.textBoxEdit.SelectedText = "";
            this.textBoxEdit.SelectionLength = 0;
            this.textBoxEdit.SelectionStart = 0;
            this.textBoxEdit.Size = new System.Drawing.Size(346, 23);
            this.textBoxEdit.TabIndex = 46;
            this.textBoxEdit.TabStop = false;
            this.textBoxEdit.UseSystemPasswordChar = false;
            this.textBoxEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdit_KeyPress);
            // 
            // PostsFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 219);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxEdit);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PostsFormEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить должность";
            this.Load += new System.EventHandler(this.PostsFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValid;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEdit;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEdit;
    }
}