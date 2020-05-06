namespace CourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListProjectsToolStripMenuItem,
            this.Status_projectsToolStripMenuItem});
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.проектыToolStripMenuItem.Text = "Проекты";
            // 
            // ListProjectsToolStripMenuItem
            // 
            this.ListProjectsToolStripMenuItem.Name = "ListProjectsToolStripMenuItem";
            this.ListProjectsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ListProjectsToolStripMenuItem.Text = "Список проекты";
            this.ListProjectsToolStripMenuItem.Click += new System.EventHandler(this.ListProjectsToolStripMenuItem_Click);
            // 
            // Status_projectsToolStripMenuItem
            // 
            this.Status_projectsToolStripMenuItem.Name = "Status_projectsToolStripMenuItem";
            this.Status_projectsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.Status_projectsToolStripMenuItem.Text = "Статусы проектов";
            this.Status_projectsToolStripMenuItem.Click += new System.EventHandler(this.Status_projectsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1041, 559);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1057, 598);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Status_projectsToolStripMenuItem;
    }
}

