namespace CourseWork
{
    partial class History_projectsFormAdd
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
            this.ComboBox_fk_project = new System.Windows.Forms.ComboBox();
            this.ComboBox_fk_status_project = new System.Windows.Forms.ComboBox();
            this.textBox_History_date_project = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // ComboBox_fk_project
            // 
            this.ComboBox_fk_project.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_project.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_project.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_project.FormattingEnabled = true;
            this.ComboBox_fk_project.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_project.Location = new System.Drawing.Point(12, 82);
            this.ComboBox_fk_project.Name = "ComboBox_fk_project";
            this.ComboBox_fk_project.Size = new System.Drawing.Size(507, 26);
            this.ComboBox_fk_project.TabIndex = 6;
            // 
            // ComboBox_fk_status_project
            // 
            this.ComboBox_fk_status_project.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_status_project.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_status_project.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_status_project.FormattingEnabled = true;
            this.ComboBox_fk_status_project.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_status_project.Location = new System.Drawing.Point(12, 132);
            this.ComboBox_fk_status_project.Name = "ComboBox_fk_status_project";
            this.ComboBox_fk_status_project.Size = new System.Drawing.Size(219, 26);
            this.ComboBox_fk_status_project.TabIndex = 7;
            // 
            // textBox_History_date_project
            // 
            this.textBox_History_date_project.Depth = 0;
            this.textBox_History_date_project.Hint = "Дата";
            this.textBox_History_date_project.Location = new System.Drawing.Point(12, 180);
            this.textBox_History_date_project.MaxLength = 32767;
            this.textBox_History_date_project.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_History_date_project.Name = "textBox_History_date_project";
            this.textBox_History_date_project.PasswordChar = '\0';
            this.textBox_History_date_project.SelectedText = "";
            this.textBox_History_date_project.SelectionLength = 0;
            this.textBox_History_date_project.SelectionStart = 0;
            this.textBox_History_date_project.Size = new System.Drawing.Size(219, 23);
            this.textBox_History_date_project.TabIndex = 8;
            this.textBox_History_date_project.TabStop = false;
            this.textBox_History_date_project.UseSystemPasswordChar = false;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(423, 231);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(95, 36);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Отменить";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(12, 231);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(94, 36);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // History_projectsFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 279);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox_History_date_project);
            this.Controls.Add(this.ComboBox_fk_status_project);
            this.Controls.Add(this.ComboBox_fk_project);
            this.MaximizeBox = false;
            this.Name = "History_projectsFormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.History_projectsFormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_fk_project;
        private System.Windows.Forms.ComboBox ComboBox_fk_status_project;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_History_date_project;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
    }
}