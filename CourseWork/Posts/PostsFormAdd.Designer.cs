namespace CourseWork.Posts
{
    partial class PostsFormAdd
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
            this.textBoxNamePost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValid.ForeColor = System.Drawing.Color.Red;
            this.labelValid.Location = new System.Drawing.Point(94, 129);
            this.labelValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(174, 13);
            this.labelValid.TabIndex = 48;
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
            this.buttonBack.TabIndex = 47;
            this.buttonBack.Text = "Отменить";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxNamePost
            // 
            this.textBoxNamePost.Depth = 0;
            this.textBoxNamePost.Hint = "Наименование";
            this.textBoxNamePost.Location = new System.Drawing.Point(13, 102);
            this.textBoxNamePost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamePost.MaxLength = 35;
            this.textBoxNamePost.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxNamePost.Name = "textBoxNamePost";
            this.textBoxNamePost.PasswordChar = '\0';
            this.textBoxNamePost.SelectedText = "";
            this.textBoxNamePost.SelectionLength = 0;
            this.textBoxNamePost.SelectionStart = 0;
            this.textBoxNamePost.Size = new System.Drawing.Size(344, 23);
            this.textBoxNamePost.TabIndex = 46;
            this.textBoxNamePost.TabStop = false;
            this.textBoxNamePost.UseSystemPasswordChar = false;
            this.textBoxNamePost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNamePost_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(13, 170);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(94, 36);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // PostsFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 219);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxNamePost);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PostsFormAdd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить должность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValid;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxNamePost;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
    }
}