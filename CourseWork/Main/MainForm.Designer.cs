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
            this.ProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Projects_roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.History_projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.History_taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmployeesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Posts_employeesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListPostsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoleUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДолжностейToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectsToolStripMenuItem,
            this.TaskToolStripMenuItem,
            this.EmployeeToolStripMenuItem1,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProjectsToolStripMenuItem
            // 
            this.ProjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListProjectsToolStripMenuItem,
            this.Status_projectsToolStripMenuItem,
            this.Projects_roleToolStripMenuItem,
            this.History_projectsToolStripMenuItem});
            this.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem";
            this.ProjectsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ProjectsToolStripMenuItem.Text = "Проекты";
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
            // TaskToolStripMenuItem
            // 
            this.TaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListTaskToolStripMenuItem,
            this.Status_taskToolStripMenuItem,
            this.TypeTaskToolStripMenuItem,
            this.History_taskToolStripMenuItem});
            this.TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
            this.TaskToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.TaskToolStripMenuItem.Text = "Задачи";
            // 
            // ListTaskToolStripMenuItem
            // 
            this.ListTaskToolStripMenuItem.Name = "ListTaskToolStripMenuItem";
            this.ListTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ListTaskToolStripMenuItem.Text = "Список задач";
            this.ListTaskToolStripMenuItem.Click += new System.EventHandler(this.ListTaskToolStripMenuItem_Click);
            // 
            // Status_taskToolStripMenuItem
            // 
            this.Status_taskToolStripMenuItem.Name = "Status_taskToolStripMenuItem";
            this.Status_taskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Status_taskToolStripMenuItem.Text = "Статусы задач";
            this.Status_taskToolStripMenuItem.Click += new System.EventHandler(this.Status_taskToolStripMenuItem_Click);
            // 
            // TypeTaskToolStripMenuItem
            // 
            this.TypeTaskToolStripMenuItem.Name = "TypeTaskToolStripMenuItem";
            this.TypeTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TypeTaskToolStripMenuItem.Text = "Типы задач";
            this.TypeTaskToolStripMenuItem.Click += new System.EventHandler(this.TypeTaskToolStripMenuItem_Click);
            // 
            // History_taskToolStripMenuItem
            // 
            this.History_taskToolStripMenuItem.Name = "History_taskToolStripMenuItem";
            this.History_taskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.History_taskToolStripMenuItem.Text = "История задач";
            this.History_taskToolStripMenuItem.Click += new System.EventHandler(this.History_taskToolStripMenuItem_Click);
            // 
            // EmployeeToolStripMenuItem1
            // 
            this.EmployeeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listEmployeesToolStripMenuItem2,
            this.Posts_employeesToolStripMenuItem2,
            this.ListPostsToolStripMenuItem2,
            this.ListUsersToolStripMenuItem,
            this.RoleUsersToolStripMenuItem});
            this.EmployeeToolStripMenuItem1.Name = "EmployeeToolStripMenuItem1";
            this.EmployeeToolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.EmployeeToolStripMenuItem1.Text = "Сотрудники";
            // 
            // listEmployeesToolStripMenuItem2
            // 
            this.listEmployeesToolStripMenuItem2.Name = "listEmployeesToolStripMenuItem2";
            this.listEmployeesToolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.listEmployeesToolStripMenuItem2.Text = "Список сотрудников";
            this.listEmployeesToolStripMenuItem2.Click += new System.EventHandler(this.listEmployeesToolStripMenuItem2_Click);
            // 
            // Posts_employeesToolStripMenuItem2
            // 
            this.Posts_employeesToolStripMenuItem2.Name = "Posts_employeesToolStripMenuItem2";
            this.Posts_employeesToolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.Posts_employeesToolStripMenuItem2.Text = "Должности сотрудников";
            this.Posts_employeesToolStripMenuItem2.Click += new System.EventHandler(this.Posts_employeesToolStripMenuItem2_Click);
            // 
            // ListPostsToolStripMenuItem2
            // 
            this.ListPostsToolStripMenuItem2.Name = "ListPostsToolStripMenuItem2";
            this.ListPostsToolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.ListPostsToolStripMenuItem2.Text = "Список должностей";
            this.ListPostsToolStripMenuItem2.Click += new System.EventHandler(this.ListPostsToolStripMenuItem2_Click);
            // 
            // ListUsersToolStripMenuItem
            // 
            this.ListUsersToolStripMenuItem.Name = "ListUsersToolStripMenuItem";
            this.ListUsersToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ListUsersToolStripMenuItem.Text = "Список пользователей";
            this.ListUsersToolStripMenuItem.Click += new System.EventHandler(this.ListUsersToolStripMenuItem_Click);
            // 
            // RoleUsersToolStripMenuItem
            // 
            this.RoleUsersToolStripMenuItem.Name = "RoleUsersToolStripMenuItem";
            this.RoleUsersToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.RoleUsersToolStripMenuItem.Text = "Роли пользователей";
            this.RoleUsersToolStripMenuItem.Click += new System.EventHandler(this.RoleUsersToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1041, 0);
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
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(127, 20);
            this.toolStripTextBox1.Text = "Личный кабинет";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GrayText;
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
        private System.Windows.Forms.ToolStripMenuItem ProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Status_projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Projects_roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem History_projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Status_taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TypeTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem History_taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listEmployeesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Posts_employeesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ListPostsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ListUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoleUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem должностиСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокДолжностейToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокПользователиToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem toolStripTextBox1;
    }
}

