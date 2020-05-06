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
            Application.Run(new AuthorizationForm());
        }

        public static class DataEmailReg
        {
            public static string Value { get; set; }
        }

        public static class ReturnDataReg
        {
            public static string Value { get; set; }
        }
    }
}
