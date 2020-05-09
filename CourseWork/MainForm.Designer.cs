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
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Projects_roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяПроектовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиДляПроектовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыЗадачToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗадачToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиСотрудниковToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДолжностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainToolStripMenuItem
            // 
            this.MainToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.MainToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектыToolStripMenuItem,
            this.задачиToolStripMenuItem1,
            this.сотрудникиToolStripMenuItem2});
            this.MainToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.MainToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
            this.MainToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.MainToolStripMenuItem.Text = "Меню";
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.проектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListProjectsToolStripMenuItem,
            this.Status_projectsToolStripMenuItem,
            this.Projects_roleToolStripMenuItem,
            this.историяПроектовToolStripMenuItem1});
            this.проектыToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.проектыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проектыToolStripMenuItem.Text = "Проекты";
            // 
            // ListProjectsToolStripMenuItem
            // 
            this.ListProjectsToolStripMenuItem.Name = "ListProjectsToolStripMenuItem";
            this.ListProjectsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ListProjectsToolStripMenuItem.Text = "Список проектов";
            this.ListProjectsToolStripMenuItem.Click += new System.EventHandler(this.ListProjectsToolStripMenuItem_Click);
            // 
            // Status_projectsToolStripMenuItem
            // 
            this.Status_projectsToolStripMenuItem.Name = "Status_projectsToolStripMenuItem";
            this.Status_projectsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Status_projectsToolStripMenuItem.Text = "Статусы проектов";
            this.Status_projectsToolStripMenuItem.Click += new System.EventHandler(this.Status_projectsToolStripMenuItem_Click);
            // 
            // Projects_roleToolStripMenuItem
            // 
            this.Projects_roleToolStripMenuItem.Name = "Projects_roleToolStripMenuItem";
            this.Projects_roleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Projects_roleToolStripMenuItem.Text = "Роли в проектах";
            this.Projects_roleToolStripMenuItem.Click += new System.EventHandler(this.Projects_roleToolStripMenuItem_Click);
            // 
            // историяПроектовToolStripMenuItem1
            // 
            this.историяПроектовToolStripMenuItem1.Name = "историяПроектовToolStripMenuItem1";
            this.историяПроектовToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.историяПроектовToolStripMenuItem1.Text = "История проектов";
            // 
            // задачиToolStripMenuItem1
            // 
            this.задачиToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOrange;
            this.задачиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачиДляПроектовToolStripMenuItem1,
            this.статусыToolStripMenuItem,
            this.типыЗадачToolStripMenuItem1,
            this.историяЗадачToolStripMenuItem1});
            this.задачиToolStripMenuItem1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.задачиToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.задачиToolStripMenuItem1.Name = "задачиToolStripMenuItem1";
            this.задачиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.задачиToolStripMenuItem1.Text = "Задачи";
            // 
            // задачиДляПроектовToolStripMenuItem1
            // 
            this.задачиДляПроектовToolStripMenuItem1.Name = "задачиДляПроектовToolStripMenuItem1";
            this.задачиДляПроектовToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.задачиДляПроектовToolStripMenuItem1.Text = "Список задач";
            // 
            // статусыToolStripMenuItem
            // 
            this.статусыToolStripMenuItem.Name = "статусыToolStripMenuItem";
            this.статусыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.статусыToolStripMenuItem.Text = "Статусы задач";
            // 
            // типыЗадачToolStripMenuItem1
            // 
            this.типыЗадачToolStripMenuItem1.Name = "типыЗадачToolStripMenuItem1";
            this.типыЗадачToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.типыЗадачToolStripMenuItem1.Text = "Типы задач";
            // 
            // историяЗадачToolStripMenuItem1
            // 
            this.историяЗадачToolStripMenuItem1.Name = "историяЗадачToolStripMenuItem1";
            this.историяЗадачToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.историяЗадачToolStripMenuItem1.Text = "История задач";
            // 
            // сотрудникиToolStripMenuItem2
            // 
            this.сотрудникиToolStripMenuItem2.BackColor = System.Drawing.Color.DarkOrange;
            this.сотрудникиToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСотрудниковToolStripMenuItem,
            this.должностиСотрудниковToolStripMenuItem1,
            this.списокДолжностейToolStripMenuItem,
            this.пользователиToolStripMenuItem1,
            this.ролиПользователейToolStripMenuItem});
            this.сотрудникиToolStripMenuItem2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сотрудникиToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.сотрудникиToolStripMenuItem2.Name = "сотрудникиToolStripMenuItem2";
            this.сотрудникиToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.сотрудникиToolStripMenuItem2.Text = "Сотрудники";
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            this.списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            this.списокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            // 
            // должностиСотрудниковToolStripMenuItem1
            // 
            this.должностиСотрудниковToolStripMenuItem1.Name = "должностиСотрудниковToolStripMenuItem1";
            this.должностиСотрудниковToolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
            this.должностиСотрудниковToolStripMenuItem1.Text = "Должности сотрудников";
            // 
            // списокДолжностейToolStripMenuItem
            // 
            this.списокДолжностейToolStripMenuItem.Name = "списокДолжностейToolStripMenuItem";
            this.списокДолжностейToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.списокДолжностейToolStripMenuItem.Text = "Список должностей";
            // 
            // пользователиToolStripMenuItem1
            // 
            this.пользователиToolStripMenuItem1.Name = "пользователиToolStripMenuItem1";
            this.пользователиToolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
            this.пользователиToolStripMenuItem1.Text = "Пользователи";
            // 
            // ролиПользователейToolStripMenuItem
            // 
            this.ролиПользователейToolStripMenuItem.Name = "ролиПользователейToolStripMenuItem";
            this.ролиПользователейToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.ролиПользователейToolStripMenuItem.Text = "Роли пользователей";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1041, 1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1041, 25);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1041, 567);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1057, 606);
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Status_projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Projects_roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяПроектовToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem задачиДляПроектовToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem статусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыЗадачToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem историяЗадачToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиСотрудниковToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокДолжностейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ролиПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

