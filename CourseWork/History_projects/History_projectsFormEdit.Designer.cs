﻿namespace CourseWork
{
    partial class History_projectsFormEdit
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
            this.buttonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox_History_date_project = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ComboBox_fk_status_project = new System.Windows.Forms.ComboBox();
            this.ComboBox_fk_project = new System.Windows.Forms.ComboBox();
            this.labelValidDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(423, 226);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(95, 36);
            this.buttonBack.TabIndex = 23;
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
            this.buttonEdit.Location = new System.Drawing.Point(12, 226);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Primary = true;
            this.buttonEdit.Size = new System.Drawing.Size(95, 36);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBox_History_date_project
            // 
            this.textBox_History_date_project.Depth = 0;
            this.textBox_History_date_project.Hint = "Дата";
            this.textBox_History_date_project.Location = new System.Drawing.Point(299, 150);
            this.textBox_History_date_project.MaxLength = 10;
            this.textBox_History_date_project.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_History_date_project.Name = "textBox_History_date_project";
            this.textBox_History_date_project.PasswordChar = '\0';
            this.textBox_History_date_project.SelectedText = "";
            this.textBox_History_date_project.SelectionLength = 0;
            this.textBox_History_date_project.SelectionStart = 0;
            this.textBox_History_date_project.Size = new System.Drawing.Size(219, 23);
            this.textBox_History_date_project.TabIndex = 21;
            this.textBox_History_date_project.TabStop = false;
            this.textBox_History_date_project.UseSystemPasswordChar = false;
            this.textBox_History_date_project.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_History_date_project_KeyPress);
            // 
            // ComboBox_fk_status_project
            // 
            this.ComboBox_fk_status_project.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_status_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_fk_status_project.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_status_project.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_status_project.FormattingEnabled = true;
            this.ComboBox_fk_status_project.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_status_project.Location = new System.Drawing.Point(12, 148);
            this.ComboBox_fk_status_project.Name = "ComboBox_fk_status_project";
            this.ComboBox_fk_status_project.Size = new System.Drawing.Size(219, 26);
            this.ComboBox_fk_status_project.TabIndex = 20;
            // 
            // ComboBox_fk_project
            // 
            this.ComboBox_fk_project.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_fk_project.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_project.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_project.FormattingEnabled = true;
            this.ComboBox_fk_project.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_project.Location = new System.Drawing.Point(12, 96);
            this.ComboBox_fk_project.Name = "ComboBox_fk_project";
            this.ComboBox_fk_project.Size = new System.Drawing.Size(506, 26);
            this.ComboBox_fk_project.TabIndex = 19;
            // 
            // labelValidDate
            // 
            this.labelValidDate.AutoSize = true;
            this.labelValidDate.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValidDate.ForeColor = System.Drawing.Color.Red;
            this.labelValidDate.Location = new System.Drawing.Point(329, 176);
            this.labelValidDate.Name = "labelValidDate";
            this.labelValidDate.Size = new System.Drawing.Size(163, 26);
            this.labelValidDate.TabIndex = 52;
            this.labelValidDate.Text = "Некорректная дата.\r\nФормат даты: DD.MM.YYYY\r\n";
            this.labelValidDate.Visible = false;
            // 
            // History_projectsFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 274);
            this.Controls.Add(this.labelValidDate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBox_History_date_project);
            this.Controls.Add(this.ComboBox_fk_status_project);
            this.Controls.Add(this.ComboBox_fk_project);
            this.MaximizeBox = false;
            this.Name = "History_projectsFormEdit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить историю проекта";
            this.Load += new System.EventHandler(this.History_projectsFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEdit;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_History_date_project;
        private System.Windows.Forms.ComboBox ComboBox_fk_status_project;
        private System.Windows.Forms.ComboBox ComboBox_fk_project;
        private System.Windows.Forms.Label labelValidDate;
    }
}