namespace CourseWork.Posts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.menuStripPosts = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column_id_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_post_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewPosts.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewPosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPosts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id_post,
            this.Column_post_name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPosts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPosts.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewPosts.Location = new System.Drawing.Point(0, 61);
            this.dataGridViewPosts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPosts.MultiSelect = false;
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPosts.Size = new System.Drawing.Size(1037, 511);
            this.dataGridViewPosts.TabIndex = 8;
            this.dataGridViewPosts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPosts_CellDoubleClick);
            this.dataGridViewPosts.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewPosts_UserDeletingRow);
            this.dataGridViewPosts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPosts_KeyDown);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column_post_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_post_name.HeaderText = "Название должности";
            this.Column_post_name.MaxInputLength = 35;
            this.Column_post_name.Name = "Column_post_name";
            this.Column_post_name.ReadOnly = true;
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 571);
            this.ControlBox = false;
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
        private System.Windows.Forms.MenuStrip menuStripPosts;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id_post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_post_name;
    }
}