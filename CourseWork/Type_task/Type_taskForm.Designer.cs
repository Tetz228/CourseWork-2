﻿namespace CourseWork.Type_task
{
    partial class Type_taskForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewType_task = new System.Windows.Forms.DataGridView();
            this.Column_id_type_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_task_name_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_task_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripType_task = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.radioButtonDescription = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonName = new MaterialSkin.Controls.MaterialRadioButton();
            this.pictureBoxFilters = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType_task)).BeginInit();
            this.menuStripType_task.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewType_task
            // 
            this.dataGridViewType_task.AllowUserToAddRows = false;
            this.dataGridViewType_task.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewType_task.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewType_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewType_task.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewType_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewType_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_type_task,
            this.Column_task_name_type,
            this.Column_task_description});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewType_task.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewType_task.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewType_task.Location = new System.Drawing.Point(0, 64);
            this.dataGridViewType_task.MultiSelect = false;
            this.dataGridViewType_task.Name = "dataGridViewType_task";
            this.dataGridViewType_task.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewType_task.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewType_task.TabIndex = 10;
            this.dataGridViewType_task.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewType_task_CellDoubleClick);
            this.dataGridViewType_task.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewType_task_UserDeletingRow);
            this.dataGridViewType_task.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewType_task_KeyDown);
            // 
            // Column_id_type_task
            // 
            this.Column_id_type_task.DataPropertyName = "id_type_task";
            this.Column_id_type_task.HeaderText = "Id";
            this.Column_id_type_task.Name = "Column_id_type_task";
            this.Column_id_type_task.ReadOnly = true;
            this.Column_id_type_task.Visible = false;
            // 
            // Column_task_name_type
            // 
            this.Column_task_name_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_task_name_type.DataPropertyName = "task_name_type";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_task_name_type.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column_task_name_type.HeaderText = "Название типа";
            this.Column_task_name_type.MaxInputLength = 35;
            this.Column_task_name_type.Name = "Column_task_name_type";
            this.Column_task_name_type.ReadOnly = true;
            // 
            // Column_task_description
            // 
            this.Column_task_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_task_description.DataPropertyName = "task_description";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Column_task_description.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column_task_description.HeaderText = "Описание типа";
            this.Column_task_description.Name = "Column_task_description";
            // 
            // menuStripType_task
            // 
            this.menuStripType_task.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripType_task.Location = new System.Drawing.Point(0, 0);
            this.menuStripType_task.Name = "menuStripType_task";
            this.menuStripType_task.Size = new System.Drawing.Size(1037, 24);
            this.menuStripType_task.TabIndex = 11;
            this.menuStripType_task.Text = "menuStrip1";
            // 
            // MainToolStripMenuItem
            // 
            this.MainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.MainToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
            this.MainToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.MainToolStripMenuItem.Text = "Правка";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.radioButtonDescription);
            this.panelFilters.Controls.Add(this.radioButtonName);
            this.panelFilters.Location = new System.Drawing.Point(911, 64);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(126, 63);
            this.panelFilters.TabIndex = 19;
            this.panelFilters.Visible = false;
            // 
            // radioButtonDescription
            // 
            this.radioButtonDescription.AutoSize = true;
            this.radioButtonDescription.Depth = 0;
            this.radioButtonDescription.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonDescription.Location = new System.Drawing.Point(0, 30);
            this.radioButtonDescription.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonDescription.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonDescription.Name = "radioButtonDescription";
            this.radioButtonDescription.Ripple = true;
            this.radioButtonDescription.Size = new System.Drawing.Size(92, 30);
            this.radioButtonDescription.TabIndex = 18;
            this.radioButtonDescription.TabStop = true;
            this.radioButtonDescription.Text = "Описание";
            this.radioButtonDescription.UseVisualStyleBackColor = true;
            this.radioButtonDescription.CheckedChanged += new System.EventHandler(this.radioButtonDescription_CheckedChanged);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Depth = 0;
            this.radioButtonName.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonName.Location = new System.Drawing.Point(0, 0);
            this.radioButtonName.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonName.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Ripple = true;
            this.radioButtonName.Size = new System.Drawing.Size(92, 30);
            this.radioButtonName.TabIndex = 17;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Название";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // pictureBoxFilters
            // 
            this.pictureBoxFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFilters.Image = global::CourseWork.Properties.Resources.Filters;
            this.pictureBoxFilters.Location = new System.Drawing.Point(1006, 32);
            this.pictureBoxFilters.Name = "pictureBoxFilters";
            this.pictureBoxFilters.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxFilters.TabIndex = 18;
            this.pictureBoxFilters.TabStop = false;
            this.pictureBoxFilters.Click += new System.EventHandler(this.pictureBoxFilters_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "Поиск";
            this.textBoxSearch.Location = new System.Drawing.Point(738, 33);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(262, 23);
            this.textBoxSearch.TabIndex = 17;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Type_taskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.pictureBoxFilters);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewType_task);
            this.Controls.Add(this.menuStripType_task);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Type_taskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Типы задач";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Type_task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType_task)).EndInit();
            this.menuStripType_task.ResumeLayout(false);
            this.menuStripType_task.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewType_task;
        private System.Windows.Forms.MenuStrip menuStripType_task;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_type_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_task_name_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_task_description;
        private System.Windows.Forms.Panel panelFilters;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonDescription;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonName;
        private System.Windows.Forms.PictureBox pictureBoxFilters;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
    }
}