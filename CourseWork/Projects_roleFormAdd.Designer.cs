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
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxNameRole = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
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
            // textBoxNameRole
            // 
            this.textBoxNameRole.Depth = 0;
            this.textBoxNameRole.Hint = "Наименование";
            this.textBoxNameRole.Location = new System.Drawing.Point(21, 102);
            this.textBoxNameRole.MaxLength = 50;
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
            this.textBoxNameRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameRole_KeyPress);
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
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValid.ForeColor = System.Drawing.Color.Red;
            this.labelValid.Location = new System.Drawing.Point(18, 128);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(170, 13);
            this.labelValid.TabIndex = 45;
            this.labelValid.Text = "Поле не может быть пустым";
            this.labelValid.Visible = false;
            // 
            // Projects_roleFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 200);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxNameRole);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "Projects_roleFormAdd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить роль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxNameRole;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
        private System.Windows.Forms.Label labelValid;
    }
}