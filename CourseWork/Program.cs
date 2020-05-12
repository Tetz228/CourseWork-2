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

        public static class DataEmailReg
        {
            public static string Value { get; set; }
        }

        public static class DataReturnReg
        {
            public static string Value { get; set; }
        }

        ///////////////////////////////////////////////
  
        public static class DataEditStatus_projectId
        {
            public static string Value { get; set; }
        }

        ///

        public static class DataEditStatus_project
        {
            public static string Value { get; set; }
        }

        ///////////////////////////////////////////////

        public static class DataEditProjectId
        {
            public static string Value { get; set; }
        }

        /// 
     
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

        ///

        public static class DataEditProjects_roleId
        {
            public static string Value { get; set; }
        }

        ///////////////////////////////////////////////

        public static class DataAddProjects_role
        {
            public static string Value { get; set; }
        }

        ///

        public static class DataEditProjects_role
        {
            public static string Value { get; set; }
        }

        ///

        public static class DataValidAddProjects_role
        {
            public static string Value { get; set; }
        }

        public static class DataValidEditProjects_role
        {
            public static string Value { get; set; }
        }

        ///////////////////////////////////////////////

        public static class DataAddHistoryProject
        {
            public static string Value { get; set; }
        }

        public static class DataAddHistoryStatus
        {
            public static string Value { get; set; }
        }

        public static class DataAddHistoryDate
        {
            public static string Value { get; set; }
        }

        ///

        public static class DataEditHistoryProject
        {
            public static string Value { get; set; }
        }

        public static class DataEditHistoryStatus
        {
            public static string Value { get; set; }
        }

        public static class DataEditHistoryDate
        {
            public static string Value { get; set; }
        }
    }
}
