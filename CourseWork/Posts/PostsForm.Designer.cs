﻿namespace CourseWork.Posts
{
    partial class PostsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.Column_id_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_post_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripPosts = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            this.menuStripPosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPosts
            // 
            this.dataGridViewPosts.AllowUserToAddRows = false;
            this.dataGridViewPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPosts.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewPosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPosts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_post,
            this.Column_post_name});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPosts.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewPosts.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewPosts.Location = new System.Drawing.Point(0, 62);
            this.dataGridViewPosts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPosts.MultiSelect = false;
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPosts.Size = new System.Drawing.Size(1037, 500);
            this.dataGridViewPosts.TabIndex = 8;
            this.dataGridViewPosts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPosts_CellDoubleClick);
            this.dataGridViewPosts.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewPosts_UserDeletingRow);
            this.dataGridViewPosts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPosts_KeyDown);
            // 
            // Column_id_post
            // 
            this.Column_id_post.DataPropertyName = "id_post";
            this.Column_id_post.HeaderText = "Id";
            this.Column_id_post.Name = "Column_id_post";
            this.Column_id_post.ReadOnly = true;
            this.Column_id_post.Visible = false;
            // 
            // Column_post_name
            // 
            this.Column_post_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_post_name.DataPropertyName = "post_name";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_post_name.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column_post_name.HeaderText = "Название должности";
            this.Column_post_name.MaxInputLength = 35;
            this.Column_post_name.Name = "Column_post_name";
            this.Column_post_name.ReadOnly = true;
            // 
            // menuStripPosts
            // 
            this.menuStripPosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStripPosts.Location = new System.Drawing.Point(0, 0);
            this.menuStripPosts.Name = "menuStripPosts";
            this.menuStripPosts.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripPosts.Size = new System.Drawing.Size(1037, 24);
            this.menuStripPosts.TabIndex = 9;
            this.menuStripPosts.Text = "menuStrip1";
            // 
            // MainToolStripMenuItem
            // 
            this.MainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.MainToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
            this.MainToolStripMenuItem.Size = new System.Drawing.Size(66, 18);
            this.MainToolStripMenuItem.Text = "Правка";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Hint = "Поиск";
            this.textBoxSearch.Location = new System.Drawing.Point(763, 32);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.Size = new System.Drawing.Size(262, 23);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.UseSystemPasswordChar = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewPosts);
            this.Controls.Add(this.menuStripPosts);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Должности";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
            this.menuStripPosts.ResumeLayout(false);
            this.menuStripPosts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_post_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSearch;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripPosts;
    }
}