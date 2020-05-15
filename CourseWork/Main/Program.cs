using System;
using System.Windows.Forms;

namespace CourseWork
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /////////////////////Регистрация//////////////////////////

        public static class DataEmailReg
        {
            public static string Value { get; set; }
        }

        public static class DataReturnReg
        {
            public static string Value { get; set; }
        }

        /////////////////////Статусы проектов//////////////////////////

        public static class DataEditStatus_projectId
        {
            public static string Value { get; set; }
        }

        public static class DataEditStatus_projectName
        {
            public static string Value { get; set; }
        }

        /////////////////////Проекты//////////////////////////

        public static class DataEditProjectId
        {
            public static string Value { get; set; }
        }
     
        public static class DataEditProjectName
        {
            public static string Value { get; set; }
        }

        public static class DataEditProjectTarget
        {
            public static string Value { get; set; }
        }

        public static class DataEditProjectStart
        {
            public static string Value { get; set; }
        }

        public static class DataEditProjectCompletion
        {
            public static string Value { get; set; }
        }

        public static class DataEditProjectLeader
        {
            public static string Value { get; set; }
        }

        //////////////////////Роли в проекте/////////////////////////

        public static class DataEditProjects_roleId
        {
            public static string Value { get; set; }
        }

        public static class DataEditProjects_roleName
        {
            public static string Value { get; set; }
        }

        //////////////////////История проектов/////////////////////////

        public static class DataEditHistoryProjectId
        {
            public static string Value { get; set; }
        }

        public static class DataEditHistoryProjectName
        {
            public static string Value { get; set; }
        }

        public static class DataEditHistoryProjectStatus
        {
            public static string Value { get; set; }
        }

        public static class DataEditHistoryProjectDate
        {
            public static string Value { get; set; }
        }

        ///////////////////////Сотрудники////////////////////////

        public static class DataEditEmployeeId
        {
            public static string Value { get; set; }
        }

        public static class DataEditEmployeeLname
        {
            public static string Value { get; set; }
        }

        public static class DataEditEmployeeFname
        {
            public static string Value { get; set; }
        }

        public static class DataEditEmployeeMname
        {
            public static string Value { get; set; }
        }

        public static class DataEditEmployeeEmail
        {
            public static string Value { get; set; }
        }

        //////////////////////Должности сотрудников/////////////////////////

        public static class DataEditPostsEmployeesId
        {
            public static string Value { get; set; }
        }

        public static class DataEditPostsEmployeesEmp
        {
            public static string Value { get; set; }
        }

        public static class DataEditPostsEmployeesPost
        {
            public static string Value { get; set; }
        }

        ////////////////////Должности///////////////////

        public static class DataEditPostsId
        {
            public static string Value { get; set; }
        }

        public static class DataEditPostsName
        {
            public static string Value { get; set; }
        }

        //////////////////////Статусы задач/////////////////////////

        public static class DataEditStatus_taskId
        {
            public static string Value { get; set; }
        }

        public static class DataEditStatus_taskName
        {
            public static string Value { get; set; }
        }

        ///////////////////////////////////////////////
    }
}
