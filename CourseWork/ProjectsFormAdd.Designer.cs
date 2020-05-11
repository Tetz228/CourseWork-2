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
            this.labelValidProject = new System.Windows.Forms.Label();
            this.labelValidTarget = new System.Windows.Forms.Label();
            this.labelValidStart = new System.Windows.Forms.Label();
            this.labelValidCompletion = new System.Windows.Forms.Label();
            this.labelValidLeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(14, 265);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(94, 36);
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
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(441, 265);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(77, 36);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxProject_name
            // 
            this.textBoxProject_name.Depth = 0;
            this.textBoxProject_name.Hint = "Название проекта";
            this.textBoxProject_name.Location = new System.Drawing.Point(14, 95);
            this.textBoxProject_name.MaxLength = 100;
            this.textBoxProject_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxProject_name.Name = "textBoxProject_name";
            this.textBoxProject_name.PasswordChar = '\0';
            this.textBoxProject_name.SelectedText = "";
            this.textBoxProject_name.SelectionLength = 0;
            this.textBoxProject_name.SelectionStart = 0;
            this.textBoxProject_name.Size = new System.Drawing.Size(230, 23);
            this.textBoxProject_name.TabIndex = 1;
            this.textBoxProject_name.TabStop = false;
            this.textBoxProject_name.UseSystemPasswordChar = false;
            this.textBoxProject_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProject_name_KeyPress);
            // 
            // textBoxProject_target
            // 
            this.textBoxProject_target.Depth = 0;
            this.textBoxProject_target.Hint = "Цель проекта";
            this.textBoxProject_target.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxProject_target.Location = new System.Drawing.Point(288, 95);
            this.textBoxProject_target.MaxLength = 200;
            this.textBoxProject_target.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxProject_target.Name = "textBoxProject_target";
            this.textBoxProject_target.PasswordChar = '\0';
            this.textBoxProject_target.SelectedText = "";
            this.textBoxProject_target.SelectionLength = 0;
            this.textBoxProject_target.SelectionStart = 0;
            this.textBoxProject_target.Size = new System.Drawing.Size(230, 23);
            this.textBoxProject_target.TabIndex = 2;
            this.textBoxProject_target.TabStop = false;
            this.textBoxProject_target.UseSystemPasswordChar = false;
            this.textBoxProject_target.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProject_target_KeyPress);
            // 
            // textBoxDate_completion
            // 
            this.textBoxDate_completion.AllowDrop = true;
            this.textBoxDate_completion.Depth = 0;
            this.textBoxDate_completion.Hint = "Дата сдачи";
            this.textBoxDate_completion.Location = new System.Drawing.Point(288, 153);
            this.textBoxDate_completion.MaxLength = 10;
            this.textBoxDate_completion.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDate_completion.Name = "textBoxDate_completion";
            this.textBoxDate_completion.PasswordChar = '\0';
            this.textBoxDate_completion.SelectedText = "";
            this.textBoxDate_completion.SelectionLength = 0;
            this.textBoxDate_completion.SelectionStart = 0;
            this.textBoxDate_completion.Size = new System.Drawing.Size(230, 23);
            this.textBoxDate_completion.TabIndex = 4;
            this.textBoxDate_completion.TabStop = false;
            this.textBoxDate_completion.UseSystemPasswordChar = false;
            this.textBoxDate_completion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_completion_KeyPress);
            // 
            // textBoxDate_start
            // 
            this.textBoxDate_start.Depth = 0;
            this.textBoxDate_start.Hint = "Дата начала";
            this.textBoxDate_start.Location = new System.Drawing.Point(14, 153);
            this.textBoxDate_start.MaxLength = 10;
            this.textBoxDate_start.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDate_start.Name = "textBoxDate_start";
            this.textBoxDate_start.PasswordChar = '\0';
            this.textBoxDate_start.SelectedText = "";
            this.textBoxDate_start.SelectionLength = 0;
            this.textBoxDate_start.SelectionStart = 0;
            this.textBoxDate_start.Size = new System.Drawing.Size(230, 23);
            this.textBoxDate_start.TabIndex = 3;
            this.textBoxDate_start.TabStop = false;
            this.textBoxDate_start.UseSystemPasswordChar = false;
            this.textBoxDate_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_start_KeyPress);
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
            this.comboBox_fk_leader.TabIndex = 5;
            this.comboBox_fk_leader.SelectedValueChanged += new System.EventHandler(this.comboBox_fk_leader_SelectedValueChanged);
            // 
            // labelValidProject
            // 
            this.labelValidProject.AutoSize = true;
            this.labelValidProject.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidProject.ForeColor = System.Drawing.Color.Red;
            this.labelValidProject.Location = new System.Drawing.Point(12, 121);
            this.labelValidProject.Name = "labelValidProject";
            this.labelValidProject.Size = new System.Drawing.Size(141, 13);
            this.labelValidProject.TabIndex = 45;
            this.labelValidProject.Text = "Некорректные данные";
            this.labelValidProject.Visible = false;
            // 
            // labelValidTarget
            // 
            this.labelValidTarget.AutoSize = true;
            this.labelValidTarget.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidTarget.ForeColor = System.Drawing.Color.Red;
            this.labelValidTarget.Location = new System.Drawing.Point(285, 121);
            this.labelValidTarget.Name = "labelValidTarget";
            this.labelValidTarget.Size = new System.Drawing.Size(141, 13);
            this.labelValidTarget.TabIndex = 46;
            this.labelValidTarget.Text = "Некорректные данные";
            this.labelValidTarget.Visible = false;
            // 
            // labelValidStart
            // 
            this.labelValidStart.AutoSize = true;
            this.labelValidStart.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidStart.ForeColor = System.Drawing.Color.Red;
            this.labelValidStart.Location = new System.Drawing.Point(11, 179);
            this.labelValidStart.Name = "labelValidStart";
            this.labelValidStart.Size = new System.Drawing.Size(141, 13);
            this.labelValidStart.TabIndex = 47;
            this.labelValidStart.Text = "Некорректные данные";
            this.labelValidStart.Visible = false;
            // 
            // labelValidCompletion
            // 
            this.labelValidCompletion.AutoSize = true;
            this.labelValidCompletion.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidCompletion.ForeColor = System.Drawing.Color.Red;
            this.labelValidCompletion.Location = new System.Drawing.Point(285, 179);
            this.labelValidCompletion.Name = "labelValidCompletion";
            this.labelValidCompletion.Size = new System.Drawing.Size(141, 13);
            this.labelValidCompletion.TabIndex = 48;
            this.labelValidCompletion.Text = "Некорректные данные";
            this.labelValidCompletion.Visible = false;
            // 
            // labelValidLeader
            // 
            this.labelValidLeader.AutoSize = true;
            this.labelValidLeader.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidLeader.ForeColor = System.Drawing.Color.Red;
            this.labelValidLeader.Location = new System.Drawing.Point(184, 235);
            this.labelValidLeader.Name = "labelValidLeader";
            this.labelValidLeader.Size = new System.Drawing.Size(141, 13);
            this.labelValidLeader.TabIndex = 49;
            this.labelValidLeader.Text = "Некорректные данные";
            this.labelValidLeader.Visible = false;
            // 
            // ProjectsFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 316);
            this.Controls.Add(this.labelValidLeader);
            this.Controls.Add(this.labelValidCompletion);
            this.Controls.Add(this.labelValidStart);
            this.Controls.Add(this.labelValidTarget);
            this.Controls.Add(this.labelValidProject);
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
            this.Text = "Добавить проект";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectsFormAdd_FormClosed);
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
        private System.Windows.Forms.Label labelValidProject;
        private System.Windows.Forms.Label labelValidTarget;
        private System.Windows.Forms.Label labelValidStart;
        private System.Windows.Forms.Label labelValidCompletion;
        private System.Windows.Forms.Label labelValidLeader;
    }
}