﻿namespace CourseWork
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
            this.проектыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Projects_roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.History_projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmployeesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиСотрудниковToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДолжностейToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиПользователейToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДолжностейToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.проектыToolStripMenuItem1,
            this.задачиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проектыToolStripMenuItem1
            // 
            this.проектыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListProjectsToolStripMenuItem,
            this.Status_projectsToolStripMenuItem,
            this.Projects_roleToolStripMenuItem,
            this.History_projectsToolStripMenuItem});
            this.проектыToolStripMenuItem1.Name = "проектыToolStripMenuItem1";
            this.проектыToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.проектыToolStripMenuItem1.Text = "Проекты";
            // 
            // ListProjectsToolStripMenuItem
            // 
            this.ListProjectsToolStripMenuItem.Name = "ListProjectsToolStripMenuItem";
            this.ListProjectsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ListProjectsToolStripMenuItem.Text = "Список проектов";
            this.ListProjectsToolStripMenuItem.Click += new System.EventHandler(this.ListProjectsToolStripMenuItem_Click);
            // 
            // Status_projectsToolStripMenuItem
            // 
            this.Status_projectsToolStripMenuItem.Name = "Status_projectsToolStripMenuItem";
            this.Status_projectsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.Status_projectsToolStripMenuItem.Text = "Статусы проектов";
            this.Status_projectsToolStripMenuItem.Click += new System.EventHandler(this.Status_projectsToolStripMenuItem_Click);
            // 
            // Projects_roleToolStripMenuItem
            // 
            this.Projects_roleToolStripMenuItem.Name = "Projects_roleToolStripMenuItem";
            this.Projects_roleToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.Projects_roleToolStripMenuItem.Text = "Роли в проектах";
            this.Projects_roleToolStripMenuItem.Click += new System.EventHandler(this.Projects_roleToolStripMenuItem_Click);
            // 
            // History_projectsToolStripMenuItem
            // 
            this.History_projectsToolStripMenuItem.Name = "History_projectsToolStripMenuItem";
            this.History_projectsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.History_projectsToolStripMenuItem.Text = "История проектов";
            this.History_projectsToolStripMenuItem.Click += new System.EventHandler(this.History_projectsToolStripMenuItem_Click);
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЗадачToolStripMenuItem,
            this.статусыЗадачToolStripMenuItem,
            this.типыЗадачToolStripMenuItem,
            this.историяЗадачToolStripMenuItem});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // списокЗадачToolStripMenuItem
            // 
            this.списокЗадачToolStripMenuItem.Name = "списокЗадачToolStripMenuItem";
            this.списокЗадачToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.списокЗадачToolStripMenuItem.Text = "Список задач";
            // 
            // статусыЗадачToolStripMenuItem
            // 
            this.статусыЗадачToolStripMenuItem.Name = "статусыЗадачToolStripMenuItem";
            this.статусыЗадачToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.статусыЗадачToolStripMenuItem.Text = "Статусы задач";
            // 
            // типыЗадачToolStripMenuItem
            // 
            this.типыЗадачToolStripMenuItem.Name = "типыЗадачToolStripMenuItem";
            this.типыЗадачToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.типыЗадачToolStripMenuItem.Text = "Типы задач";
            // 
            // историяЗадачToolStripMenuItem
            // 
            this.историяЗадачToolStripMenuItem.Name = "историяЗадачToolStripMenuItem";
            this.историяЗадачToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.историяЗадачToolStripMenuItem.Text = "История задач";
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listEmployeesToolStripMenuItem2,
            this.должностиСотрудниковToolStripMenuItem2,
            this.списокДолжностейToolStripMenuItem2,
            this.списокПользователейToolStripMenuItem,
            this.ролиПользователейToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            // 
            // listEmployeesToolStripMenuItem2
            // 
            this.listEmployeesToolStripMenuItem2.Name = "listEmployeesToolStripMenuItem2";
            this.listEmployeesToolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.listEmployeesToolStripMenuItem2.Text = "Список сотрудников";
            this.listEmployeesToolStripMenuItem2.Click += new System.EventHandler(this.listEmployeesToolStripMenuItem2_Click);
            // 
            // должностиСотрудниковToolStripMenuItem2
            // 
            this.должностиСотрудниковToolStripMenuItem2.Name = "должностиСотрудниковToolStripMenuItem2";
            this.должностиСотрудниковToolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.должностиСотрудниковToolStripMenuItem2.Text = "Должности сотрудников";
            // 
            // списокДолжностейToolStripMenuItem2
            // 
            this.списокДолжностейToolStripMenuItem2.Name = "списокДолжностейToolStripMenuItem2";
            this.списокДолжностейToolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.списокДолжностейToolStripMenuItem2.Text = "Список должностей";
            // 
            // списокПользователейToolStripMenuItem
            // 
            this.списокПользователейToolStripMenuItem.Name = "списокПользователейToolStripMenuItem";
            this.списокПользователейToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.списокПользователейToolStripMenuItem.Text = "Список пользователей";
            // 
            // ролиПользователейToolStripMenuItem1
            // 
            this.ролиПользователейToolStripMenuItem1.Name = "ролиПользователейToolStripMenuItem1";
            this.ролиПользователейToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.ролиПользователейToolStripMenuItem1.Text = "Роли пользователей";
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
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСотрудниковToolStripMenuItem1,
            this.должностиСотрудниковToolStripMenuItem,
            this.списокДолжностейToolStripMenuItem1,
            this.списокПользователиToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // списокСотрудниковToolStripMenuItem1
            // 
            this.списокСотрудниковToolStripMenuItem1.Name = "списокСотрудниковToolStripMenuItem1";
            this.списокСотрудниковToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.списокСотрудниковToolStripMenuItem1.Text = "Список сотрудников";
            // 
            // должностиСотрудниковToolStripMenuItem
            // 
            this.должностиСотрудниковToolStripMenuItem.Name = "должностиСотрудниковToolStripMenuItem";
            this.должностиСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.должностиСотрудниковToolStripMenuItem.Text = "Должности сотрудников";
            // 
            // списокДолжностейToolStripMenuItem1
            // 
            this.списокДолжностейToolStripMenuItem1.Name = "списокДолжностейToolStripMenuItem1";
            this.списокДолжностейToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.списокДолжностейToolStripMenuItem1.Text = "Список должностей";
            // 
            // списокПользователиToolStripMenuItem
            // 
            this.списокПользователиToolStripMenuItem.Name = "списокПользователиToolStripMenuItem";
            this.списокПользователиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.списокПользователиToolStripMenuItem.Text = "Список пользователей";
            this.списокПользователиToolStripMenuItem.Click += new System.EventHandler(this.списокПользователиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1041, 567);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
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
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ListProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Status_projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Projects_roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem History_projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listEmployeesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem должностиСотрудниковToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem списокДолжностейToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem списокПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ролиПользователейToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem должностиСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокДолжностейToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокПользователиToolStripMenuItem;
    }
}

