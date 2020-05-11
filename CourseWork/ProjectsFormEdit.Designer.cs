namespace CourseWork
{
    partial class ProjectsFormEdit
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
            this.buttonBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBoxDate_start = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxDate_completion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxProject_target = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxProject_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox_fk_leader = new System.Windows.Forms.ComboBox();
            this.labelValidCompletion = new System.Windows.Forms.Label();
            this.labelValidStart = new System.Windows.Forms.Label();
            this.labelValidTarget = new System.Windows.Forms.Label();
            this.labelValidProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(441, 265);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(77, 36);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEdit.Depth = 0;
            this.buttonEdit.Icon = null;
            this.buttonEdit.Location = new System.Drawing.Point(14, 265);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Primary = true;
            this.buttonEdit.Size = new System.Drawing.Size(95, 36);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxDate_start
            // 
            this.textBoxDate_start.Depth = 0;
            this.textBoxDate_start.Hint = "Дата начала";
            this.textBoxDate_start.Location = new System.Drawing.Point(14, 153);
            this.textBoxDate_start.MaxLength = 32767;
            this.textBoxDate_start.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDate_start.Name = "textBoxDate_start";
            this.textBoxDate_start.PasswordChar = '\0';
            this.textBoxDate_start.SelectedText = "";
            this.textBoxDate_start.SelectionLength = 0;
            this.textBoxDate_start.SelectionStart = 0;
            this.textBoxDate_start.Size = new System.Drawing.Size(230, 23);
            this.textBoxDate_start.TabIndex = 30;
            this.textBoxDate_start.TabStop = false;
            this.textBoxDate_start.UseSystemPasswordChar = false;
            this.textBoxDate_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_start_KeyPress);
            // 
            // textBoxDate_completion
            // 
            this.textBoxDate_completion.AllowDrop = true;
            this.textBoxDate_completion.Depth = 0;
            this.textBoxDate_completion.Hint = "Дата сдачи";
            this.textBoxDate_completion.Location = new System.Drawing.Point(288, 153);
            this.textBoxDate_completion.MaxLength = 32767;
            this.textBoxDate_completion.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDate_completion.Name = "textBoxDate_completion";
            this.textBoxDate_completion.PasswordChar = '\0';
            this.textBoxDate_completion.SelectedText = "";
            this.textBoxDate_completion.SelectionLength = 0;
            this.textBoxDate_completion.SelectionStart = 0;
            this.textBoxDate_completion.Size = new System.Drawing.Size(230, 23);
            this.textBoxDate_completion.TabIndex = 31;
            this.textBoxDate_completion.TabStop = false;
            this.textBoxDate_completion.UseSystemPasswordChar = false;
            this.textBoxDate_completion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_completion_KeyPress);
            // 
            // textBoxProject_target
            // 
            this.textBoxProject_target.Depth = 0;
            this.textBoxProject_target.Hint = "Цель проекта";
            this.textBoxProject_target.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxProject_target.Location = new System.Drawing.Point(288, 95);
            this.textBoxProject_target.MaxLength = 32767;
            this.textBoxProject_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxProject_target.Name = "textBoxProject_target";
            this.textBoxProject_target.PasswordChar = '\0';
            this.textBoxProject_target.SelectedText = "";
            this.textBoxProject_target.SelectionLength = 0;
            this.textBoxProject_target.SelectionStart = 0;
            this.textBoxProject_target.Size = new System.Drawing.Size(230, 23);
            this.textBoxProject_target.TabIndex = 29;
            this.textBoxProject_target.TabStop = false;
            this.textBoxProject_target.UseSystemPasswordChar = false;
            this.textBoxProject_target.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProject_target_KeyPress);
            // 
            // textBoxProject_name
            // 
            this.textBoxProject_name.Depth = 0;
            this.textBoxProject_name.Hint = "Название проекта";
            this.textBoxProject_name.Location = new System.Drawing.Point(14, 95);
            this.textBoxProject_name.MaxLength = 32767;
            this.textBoxProject_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxProject_name.Name = "textBoxProject_name";
            this.textBoxProject_name.PasswordChar = '\0';
            this.textBoxProject_name.SelectedText = "";
            this.textBoxProject_name.SelectionLength = 0;
            this.textBoxProject_name.SelectionStart = 0;
            this.textBoxProject_name.Size = new System.Drawing.Size(230, 23);
            this.textBoxProject_name.TabIndex = 28;
            this.textBoxProject_name.TabStop = false;
            this.textBoxProject_name.UseSystemPasswordChar = false;
            this.textBoxProject_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProject_name_KeyPress);
            // 
            // comboBox_fk_leader
            // 
            this.comboBox_fk_leader.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_fk_leader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fk_leader.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_fk_leader.ForeColor = System.Drawing.Color.White;
            this.comboBox_fk_leader.FormattingEnabled = true;
            this.comboBox_fk_leader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_fk_leader.Location = new System.Drawing.Point(14, 206);
            this.comboBox_fk_leader.Name = "comboBox_fk_leader";
            this.comboBox_fk_leader.Size = new System.Drawing.Size(504, 26);
            this.comboBox_fk_leader.TabIndex = 32;
            // 
            // labelValidCompletion
            // 
            this.labelValidCompletion.AutoSize = true;
            this.labelValidCompletion.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidCompletion.ForeColor = System.Drawing.Color.Red;
            this.labelValidCompletion.Location = new System.Drawing.Point(285, 179);
            this.labelValidCompletion.Name = "labelValidCompletion";
            this.labelValidCompletion.Size = new System.Drawing.Size(141, 13);
            this.labelValidCompletion.TabIndex = 53;
            this.labelValidCompletion.Text = "Некорректные данные";
            this.labelValidCompletion.Visible = false;
            // 
            // labelValidStart
            // 
            this.labelValidStart.AutoSize = true;
            this.labelValidStart.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidStart.ForeColor = System.Drawing.Color.Red;
            this.labelValidStart.Location = new System.Drawing.Point(11, 179);
            this.labelValidStart.Name = "labelValidStart";
            this.labelValidStart.Size = new System.Drawing.Size(141, 13);
            this.labelValidStart.TabIndex = 52;
            this.labelValidStart.Text = "Некорректные данные";
            this.labelValidStart.Visible = false;
            // 
            // labelValidTarget
            // 
            this.labelValidTarget.AutoSize = true;
            this.labelValidTarget.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidTarget.ForeColor = System.Drawing.Color.Red;
            this.labelValidTarget.Location = new System.Drawing.Point(285, 121);
            this.labelValidTarget.Name = "labelValidTarget";
            this.labelValidTarget.Size = new System.Drawing.Size(141, 13);
            this.labelValidTarget.TabIndex = 51;
            this.labelValidTarget.Text = "Некорректные данные";
            this.labelValidTarget.Visible = false;
            // 
            // labelValidProject
            // 
            this.labelValidProject.AutoSize = true;
            this.labelValidProject.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidProject.ForeColor = System.Drawing.Color.Red;
            this.labelValidProject.Location = new System.Drawing.Point(12, 121);
            this.labelValidProject.Name = "labelValidProject";
            this.labelValidProject.Size = new System.Drawing.Size(141, 13);
            this.labelValidProject.TabIndex = 50;
            this.labelValidProject.Text = "Некорректные данные";
            this.labelValidProject.Visible = false;
            // 
            // ProjectsFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 316);
            this.Controls.Add(this.labelValidCompletion);
            this.Controls.Add(this.labelValidStart);
            this.Controls.Add(this.labelValidTarget);
            this.Controls.Add(this.labelValidProject);
            this.Controls.Add(this.textBoxDate_start);
            this.Controls.Add(this.textBoxDate_completion);
            this.Controls.Add(this.textBoxProject_target);
            this.Controls.Add(this.textBoxProject_name);
            this.Controls.Add(this.comboBox_fk_leader);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.MaximizeBox = false;
            this.Name = "ProjectsFormEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить проект";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectsFormEdit_FormClosed);
            this.Load += new System.EventHandler(this.ProjectsFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton buttonBack;
        private MaterialSkin.Controls.MaterialFlatButton buttonEdit;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDate_start;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDate_completion;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxProject_target;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxProject_name;
        private System.Windows.Forms.ComboBox comboBox_fk_leader;
        private System.Windows.Forms.Label labelValidCompletion;
        private System.Windows.Forms.Label labelValidStart;
        private System.Windows.Forms.Label labelValidTarget;
        private System.Windows.Forms.Label labelValidProject;
    }
}