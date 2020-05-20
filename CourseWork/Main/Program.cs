using System;
using System.Windows.Forms;

namespace CourseWork
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
        /////////////////////Авторизация//////////////////////////

        public static class DataAuth
        {
            public static int IdUser { get; set; }

            public static int Role_user { get; set; }
        }

        /////////////////////Регистрация//////////////////////////

        public static class DataRegist
        { 
            public static string СorrectCode { get; set; }

            public static string Email { get; set; }
            
        }

        /////////////////////Забыли пароль?//////////////////////////

        public static class DataForgotPass
        {
            public static int IdUser { get; set; }

            public static string Email { get; set; }
        }

        /////////////////////Статусы проектов//////////////////////////

        public static class DataStatus_project
        {
            public static int Id { get; set; }

            public static string Name { get; set; }
        }

        /////////////////////Проекты//////////////////////////

        public static class DataProject
        {
            public static int Id { get; set; }

            public static string Name { get; set; }

            public static string Target { get; set; }

            public static string Start { get; set; }
            
            public static string Completion { get; set; }

            public static string Leader { get; set; }
        }

        //////////////////////Роли в проекте/////////////////////////

        public static class DataProjects_role
        {
            public static int Id { get; set; }

            public static string Name { get; set; }
        }

        //////////////////////История проектов/////////////////////////

        public static class DataHistoryProject
        {
            public static int Id { get; set; }

            public static string Name { get; set; }

            public static string Status { get; set; }

            public static string Date { get; set; }
        }

        ///////////////////////Сотрудники////////////////////////

        public static class DataEmployee
        {
            public static int Id { get; set; }

            public static string Lname { get; set; }

            public static string Fname { get; set; }

            public static string Mname { get; set; }

            public static string Email { get; set; }
        }

        //////////////////////Должности сотрудников/////////////////////////

        public static class DataPostsEmployees
        {
            public static int Id { get; set; }

            public static string Employees { get; set; }

            public static string Post { get; set; }
        }

        ////////////////////Должности///////////////////

        public static class DataPosts
        {
            public static int Id { get; set; }

            public static string Name { get; set; }
        }

        //////////////////////Статусы задач/////////////////////////

        public static class DataStatus_task
        {
            public static int Id { get; set; }

            public static string Name { get; set; }
        }

        //////////////////////История задач/////////////////////////

        public static class DataHistoryTask
        {
            public static int Id { get; set; }

            public static string Name { get; set; }

            public static string Status { get; set; }

            public static string Date { get; set; }
        }

        //////////////////////Список пользователей/////////////////////////

        public static class DataUser
        {
            public static int Id { get; set; }

            public static string Login { get; set; }

            public static string Password { get; set; }

            public static string Role { get; set; }

            public static string Employee { get; set; }
        }

        //////////////////////Роли пользователей/////////////////////////

        public static class DataUsers_roles
        {
            public static int Id { get; set; }

            public static string Name { get; set; }
        }

        //////////////////////Типы задач/////////////////////////

        public static class DataType_task          
        {
            public static int Id { get; set; }

            public static string Name { get; set; }

            public static string Description { get; set; }
        }

        //////////////////////Список задач/////////////////////////

        public static class DataProjects_task
        {
            public static int Id { get; set; }

            public static string Project { get; set; }

            public static string Type_task { get; set; }

            public static string Employee { get; set; }

            public static string Project_role { get; set; }
        }
    }
}
