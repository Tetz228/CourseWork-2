namespace CourseWork
{
    partial class ProjectsFormAdd
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
            this.buttonAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBoxProject_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxProject_target = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxDate_completion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxDate_start = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox_fk_leader = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Location = new System.Drawing.Point(14, 265);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(85, 36);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Location = new System.Drawing.Point(450, 265);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(68, 36);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // textBoxProject_name
            // 
            this.textBoxProject_name.Depth = 0;
            this.textBoxProject_name.Hint = "Название проекта";
            this.textBoxProject_name.Location = new System.Drawing.Point(14, 95);
            this.textBoxProject_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxProject_name.Name = "textBoxProject_name";
            this.textBoxProject_name.PasswordChar = '\0';
            this.textBoxProject_name.SelectedText = "";
            this.textBoxProject_name.SelectionLength = 0;
            this.textBoxProject_name.SelectionStart = 0;
            this.textBoxProject_name.Size = new System.Drawing.Size(230, 23);
            this.textBoxProject_name.TabIndex = 1;
            this.textBoxProject_name.UseSystemPasswordChar = false;
            // 
            // textBoxProject_target
            // 
            this.textBoxProject_target.Depth = 0;
            this.textBoxProject_target.Hint = "Цель проекта";
            this.textBoxProject_target.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxProject_target.Location = new System.Drawing.Point(288, 95);
            this.textBoxProject_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxProject_target.Name = "textBoxProject_target";
            this.textBoxProject_target.PasswordChar = '\0';
            this.textBoxProject_target.SelectedText = "";
            this.textBoxProject_target.SelectionLength = 0;
            this.textBoxProject_target.SelectionStart = 0;
            this.textBoxProject_target.Size = new System.Drawing.Size(230, 23);
            this.textBoxProject_target.TabIndex = 2;
            this.textBoxProject_target.UseSystemPasswordChar = false;
            // 
            // textBoxDate_completion
            // 
            this.textBoxDate_completion.AllowDrop = true;
            this.textBoxDate_completion.Depth = 0;
            this.textBoxDate_completion.Hint = "Дата сдачи";
            this.textBoxDate_completion.Location = new System.Drawing.Point(288, 153);
            this.textBoxDate_completion.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDate_completion.Name = "textBoxDate_completion";
            this.textBoxDate_completion.PasswordChar = '\0';
            this.textBoxDate_completion.SelectedText = "";
            this.textBoxDate_completion.SelectionLength = 0;
            this.textBoxDate_completion.SelectionStart = 0;
            this.textBoxDate_completion.Size = new System.Drawing.Size(230, 23);
            this.textBoxDate_completion.TabIndex = 4;
            this.textBoxDate_completion.UseSystemPasswordChar = false;
            // 
            // textBoxDate_start
            // 
            this.textBoxDate_start.Depth = 0;
            this.textBoxDate_start.Hint = "Дата начала";
            this.textBoxDate_start.Location = new System.Drawing.Point(14, 153);
            this.textBoxDate_start.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDate_start.Name = "textBoxDate_start";
            this.textBoxDate_start.PasswordChar = '\0';
            this.textBoxDate_start.SelectedText = "";
            this.textBoxDate_start.SelectionLength = 0;
            this.textBoxDate_start.SelectionStart = 0;
            this.textBoxDate_start.Size = new System.Drawing.Size(230, 23);
            this.textBoxDate_start.TabIndex = 3;
            this.textBoxDate_start.UseSystemPasswordChar = false;
            // 
            // comboBox_fk_leader
            // 
            this.comboBox_fk_leader.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_fk_leader.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_fk_leader.ForeColor = System.Drawing.Color.White;
            this.comboBox_fk_leader.FormattingEnabled = true;
            this.comboBox_fk_leader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_fk_leader.Location = new System.Drawing.Point(14, 206);
            this.comboBox_fk_leader.Name = "comboBox_fk_leader";
            this.comboBox_fk_leader.Size = new System.Drawing.Size(504, 26);
            this.comboBox_fk_leader.TabIndex = 5;
            // 
            // ProjectsFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 316);
            this.Controls.Add(this.textBoxDate_start);
            this.Controls.Add(this.textBoxDate_completion);
            this.Controls.Add(this.textBoxProject_target);
            this.Controls.Add(this.textBoxProject_name);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox_fk_leader);
            this.MaximizeBox = false;
            this.Name = "ProjectsFormAdd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.ProjectsFormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton buttonAdd;
        private MaterialSkin.Controls.MaterialFlatButton buttonBack;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxProject_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxProject_target;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDate_completion;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDate_start;
        private System.Windows.Forms.ComboBox comboBox_fk_leader;
    }
}