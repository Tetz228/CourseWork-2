namespace CourseWork.Main
{
    class Values
    {
        /////////////////////Авторизация//////////////////////////

        public static int AuthIdUser { get; set; }

        public static int AuthRole_user { get; set; }

        /////////////////////Регистрация//////////////////////////

        public static string СorrectCode { get; set; }

        public static string RegEmail { get; set; }

        /////////////////////Забыли пароль?//////////////////////////

        public static int ForgotIdUser { get; set; }

        public static string ForgotEmail { get; set; }

        /////////////////////Статусы проектов//////////////////////////

        public static int StatusProjectId { get; set; }

        public static string StatusProjectName { get; set; }

        /////////////////////Проекты//////////////////////////

        public static int ProjectId { get; set; }

        public static string ProjectName { get; set; }

        public static string ProjectTarget { get; set; }

        public static string ProjectStart { get; set; }

        public static string ProjectCompletion { get; set; }

        public static string ProjectLeader { get; set; }

        //////////////////////Роли в проекте/////////////////////////

        public static int Projects_roleId { get; set; }

        public static string Projects_roleName { get; set; }

        //////////////////////История проектов/////////////////////////

        public static int HistoryProjectId { get; set; }

        public static string HistoryProjectName { get; set; }

        public static string HistoryProjectStatus { get; set; }

        public static string HistoryProjectDate { get; set; }

        ///////////////////////Сотрудники////////////////////////

        public static int EmployeeId { get; set; }

        public static string EmployeeLname { get; set; }

        public static string EmployeeFname { get; set; }

        public static string EmployeeMname { get; set; }

        public static string EmployeeEmail { get; set; }

        //////////////////////Должности сотрудников/////////////////////////

        public static int PostsEmployeesId { get; set; }

        public static string PostsEmployeesEmployees { get; set; }

        public static string PostsEmployeesPost { get; set; }

        ////////////////////Должности///////////////////
        ///
        public static int PostsId { get; set; }

        public static string PostsName { get; set; }

        //////////////////////Статусы задач/////////////////////////
        public static int StatusTaskId { get; set; }

        public static string StatusTaskName { get; set; }

        //////////////////////История задач/////////////////////////

        public static int HistoryTaskId { get; set; }

        public static string HistoryTaskName { get; set; }

        public static string HistoryTaskProject { get; set; }

        public static string HistoryTaskStatus { get; set; }

        public static string HistoryTaskDate { get; set; }

        //////////////////////Мои задачи/////////////////////////

        public static int MyTaskId { get; set; }

        public static string MyTaskName { get; set; }

        public static string MyTaskStatus { get; set; }

        public static string MyTaskDate { get; set; }

        //////////////////////Список пользователей/////////////////////////

        public static int UserId { get; set; }

        public static string UserLogin { get; set; }

        public static string UserPassword { get; set; }

        public static string UserRole { get; set; }

        public static string UserEmployee { get; set; }

        //////////////////////Роли пользователей/////////////////////////

        public static int UsersRolesId { get; set; }

        public static string UsersRolesName { get; set; }

        //////////////////////Типы задач/////////////////////////

        public static int TypeTaskId { get; set; }

        public static string TypeTaskName { get; set; }

        public static string TypeTaskDescription { get; set; }

        //////////////////////Список задач/////////////////////////

        public static int ProjectsTaskId { get; set; }

        public static string ProjectsTaskProject { get; set; }

        public static string ProjectsTaskType_task { get; set; }

        public static string ProjectsTaskEmployee { get; set; }

        public static string ProjectsTaskProject_role { get; set; }
    }
}
