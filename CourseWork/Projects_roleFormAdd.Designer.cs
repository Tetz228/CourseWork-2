namespace CourseWork
{
    partial class Projects_roleFormAdd
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
            this.buttonBack1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxNameRole = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonBack1
            // 
            this.buttonBack1.AutoSize = true;
            this.buttonBack1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack1.Depth = 0;
            this.buttonBack1.Icon = null;
            this.buttonBack1.Location = new System.Drawing.Point(177, 158);
            this.buttonBack1.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Primary = true;
            this.buttonBack1.Size = new System.Drawing.Size(95, 36);
            this.buttonBack1.TabIndex = 19;
            this.buttonBack1.Text = "Отменить";
            this.buttonBack1.UseVisualStyleBackColor = true;
            // 
            // textBoxNameRole
            // 
            this.textBoxNameRole.Depth = 0;
            this.textBoxNameRole.Hint = "Наименование";
            this.textBoxNameRole.Location = new System.Drawing.Point(21, 102);
            this.textBoxNameRole.MaxLength = 32767;
            this.textBoxNameRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxNameRole.Name = "textBoxNameRole";
            this.textBoxNameRole.PasswordChar = '\0';
            this.textBoxNameRole.SelectedText = "";
            this.textBoxNameRole.SelectionLength = 0;
            this.textBoxNameRole.SelectionStart = 0;
            this.textBoxNameRole.Size = new System.Drawing.Size(231, 23);
            this.textBoxNameRole.TabIndex = 18;
            this.textBoxNameRole.TabStop = false;
            this.textBoxNameRole.UseSystemPasswordChar = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(12, 158);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(94, 36);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Projects_roleFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 200);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.textBoxNameRole);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "Projects_roleFormAdd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonBack1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxNameRole;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
    }
}