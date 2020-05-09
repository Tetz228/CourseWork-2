namespace CourseWork
{
    partial class Status_projectsFormAdd
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
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxNameStatus = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonBack1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Location = new System.Drawing.Point(12, 158);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(89, 30);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxNameStatus
            // 
            this.textBoxNameStatus.Depth = 0;
            this.textBoxNameStatus.Hint = "Наименование";
            this.textBoxNameStatus.Location = new System.Drawing.Point(21, 102);
            this.textBoxNameStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxNameStatus.Name = "textBoxNameStatus";
            this.textBoxNameStatus.PasswordChar = '\0';
            this.textBoxNameStatus.SelectedText = "";
            this.textBoxNameStatus.SelectionLength = 0;
            this.textBoxNameStatus.SelectionStart = 0;
            this.textBoxNameStatus.Size = new System.Drawing.Size(231, 23);
            this.textBoxNameStatus.TabIndex = 15;
            this.textBoxNameStatus.UseSystemPasswordChar = false;
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
            // Status_projectsFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 200);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.textBoxNameStatus);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "Status_projectsFormAdd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxNameStatus;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack1;
    }
}