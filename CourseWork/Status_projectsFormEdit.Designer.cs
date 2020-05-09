namespace CourseWork
{
    partial class Status_projectsFormEdit
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
            this.textBoxEdit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonEdit1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBack1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Depth = 0;
            this.textBoxEdit.Hint = "Наименование";
            this.textBoxEdit.Location = new System.Drawing.Point(21, 102);
            this.textBoxEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.PasswordChar = '\0';
            this.textBoxEdit.SelectedText = "";
            this.textBoxEdit.SelectionLength = 0;
            this.textBoxEdit.SelectionStart = 0;
            this.textBoxEdit.Size = new System.Drawing.Size(231, 23);
            this.textBoxEdit.TabIndex = 14;
            this.textBoxEdit.UseSystemPasswordChar = false;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Depth = 0;
            this.buttonEdit1.Location = new System.Drawing.Point(12, 158);
            this.buttonEdit1.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Primary = true;
            this.buttonEdit1.Size = new System.Drawing.Size(89, 30);
            this.buttonEdit1.TabIndex = 15;
            this.buttonEdit1.Text = "Изменить";
            this.buttonEdit1.UseVisualStyleBackColor = true;
            this.buttonEdit1.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonBack1
            // 
            this.buttonBack1.Depth = 0;
            this.buttonBack1.Location = new System.Drawing.Point(177, 158);
            this.buttonBack1.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Primary = true;
            this.buttonBack1.Size = new System.Drawing.Size(89, 30);
            this.buttonBack1.TabIndex = 16;
            this.buttonBack1.Text = "Отменить";
            this.buttonBack1.UseVisualStyleBackColor = true;
            // 
            // Status_projectsFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 200);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.textBoxEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "Status_projectsFormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.Load += new System.EventHandler(this.Status_projectsFormEdit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEdit;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEdit1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack1;
    }
}