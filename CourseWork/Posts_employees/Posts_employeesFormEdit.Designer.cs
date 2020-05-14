namespace CourseWork
{
    partial class Posts_employeesFormEdit
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
            this.ComboBox_fk_post = new System.Windows.Forms.ComboBox();
            this.ComboBox_fk_employee = new System.Windows.Forms.ComboBox();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox_fk_post
            // 
            this.ComboBox_fk_post.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_fk_post.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_post.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_post.FormattingEnabled = true;
            this.ComboBox_fk_post.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_post.Location = new System.Drawing.Point(12, 145);
            this.ComboBox_fk_post.Name = "ComboBox_fk_post";
            this.ComboBox_fk_post.Size = new System.Drawing.Size(427, 26);
            this.ComboBox_fk_post.TabIndex = 28;
            // 
            // ComboBox_fk_employee
            // 
            this.ComboBox_fk_employee.BackColor = System.Drawing.Color.DimGray;
            this.ComboBox_fk_employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_fk_employee.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBox_fk_employee.ForeColor = System.Drawing.Color.White;
            this.ComboBox_fk_employee.FormattingEnabled = true;
            this.ComboBox_fk_employee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_fk_employee.Location = new System.Drawing.Point(12, 84);
            this.ComboBox_fk_employee.Name = "ComboBox_fk_employee";
            this.ComboBox_fk_employee.Size = new System.Drawing.Size(427, 26);
            this.ComboBox_fk_employee.TabIndex = 27;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(344, 203);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(95, 36);
            this.buttonBack.TabIndex = 26;
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
            this.buttonEdit.Location = new System.Drawing.Point(12, 203);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Primary = true;
            this.buttonEdit.Size = new System.Drawing.Size(95, 36);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPost.ForeColor = System.Drawing.Color.Red;
            this.labelPost.Location = new System.Drawing.Point(161, 174);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(145, 13);
            this.labelPost.TabIndex = 24;
            this.labelPost.Text = "Некорректные данные.";
            this.labelPost.Visible = false;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployee.ForeColor = System.Drawing.Color.Red;
            this.labelEmployee.Location = new System.Drawing.Point(161, 113);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(145, 13);
            this.labelEmployee.TabIndex = 23;
            this.labelEmployee.Text = "Некорректные данные.";
            this.labelEmployee.Visible = false;
            // 
            // Posts_employeesFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 251);
            this.Controls.Add(this.ComboBox_fk_post);
            this.Controls.Add(this.ComboBox_fk_employee);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelEmployee);
            this.MaximizeBox = false;
            this.Name = "Posts_employeesFormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить должность сотрудника";
            this.Load += new System.EventHandler(this.Posts_employeesFormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_fk_post;
        private System.Windows.Forms.ComboBox ComboBox_fk_employee;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEdit;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelEmployee;
    }
}