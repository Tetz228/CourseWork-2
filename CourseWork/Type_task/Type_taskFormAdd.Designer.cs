namespace CourseWork.Type_task
{
    partial class Type_taskFormAdd
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
            this.labelValid = new System.Windows.Forms.Label();
            this.buttonBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxNameType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelValid1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValid.ForeColor = System.Drawing.Color.Red;
            this.labelValid.Location = new System.Drawing.Point(94, 126);
            this.labelValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(174, 13);
            this.labelValid.TabIndex = 52;
            this.labelValid.Text = "Поле не может быть пустым.";
            this.labelValid.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Depth = 0;
            this.buttonBack.Icon = null;
            this.buttonBack.Location = new System.Drawing.Point(271, 233);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Primary = true;
            this.buttonBack.Size = new System.Drawing.Size(95, 36);
            this.buttonBack.TabIndex = 51;
            this.buttonBack.Text = "Отменить";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxNameType
            // 
            this.textBoxNameType.Depth = 0;
            this.textBoxNameType.Hint = "Наименование";
            this.textBoxNameType.Location = new System.Drawing.Point(13, 99);
            this.textBoxNameType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameType.MaxLength = 35;
            this.textBoxNameType.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxNameType.Name = "textBoxNameType";
            this.textBoxNameType.PasswordChar = '\0';
            this.textBoxNameType.SelectedText = "";
            this.textBoxNameType.SelectionLength = 0;
            this.textBoxNameType.SelectionStart = 0;
            this.textBoxNameType.Size = new System.Drawing.Size(353, 23);
            this.textBoxNameType.TabIndex = 50;
            this.textBoxNameType.TabStop = false;
            this.textBoxNameType.UseSystemPasswordChar = false;
            this.textBoxNameType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameType_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(13, 233);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(94, 36);
            this.buttonAdd.TabIndex = 49;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelValid1
            // 
            this.labelValid1.AutoSize = true;
            this.labelValid1.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelValid1.ForeColor = System.Drawing.Color.Red;
            this.labelValid1.Location = new System.Drawing.Point(94, 190);
            this.labelValid1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValid1.Name = "labelValid1";
            this.labelValid1.Size = new System.Drawing.Size(174, 13);
            this.labelValid1.TabIndex = 54;
            this.labelValid1.Text = "Поле не может быть пустым.";
            this.labelValid1.Visible = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Depth = 0;
            this.textBoxDescription.Hint = "Краткое описание";
            this.textBoxDescription.Location = new System.Drawing.Point(13, 163);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.MaxLength = 35;
            this.textBoxDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PasswordChar = '\0';
            this.textBoxDescription.SelectedText = "";
            this.textBoxDescription.SelectionLength = 0;
            this.textBoxDescription.SelectionStart = 0;
            this.textBoxDescription.Size = new System.Drawing.Size(353, 23);
            this.textBoxDescription.TabIndex = 53;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.UseSystemPasswordChar = false;
            this.textBoxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescription_KeyPress);
            // 
            // Type_taskFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 282);
            this.Controls.Add(this.labelValid1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxNameType);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Type_taskFormAdd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить тип задачи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValid;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBack;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxNameType;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
        private System.Windows.Forms.Label labelValid1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDescription;
    }
}