using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CourseWork.Main
{
    class Functions
    {
        #region Отправка кода
        public string SendingCode(string email, string subject, string body)
        {
            Random random = new Random();

            string code;

            MailAddress fromMailAddress = new MailAddress("itproject719@gmail.com", "ITProject");
            MailAddress toMailAddress = new MailAddress(email);

            using (MailMessage mailMessager = new MailMessage(fromMailAddress, toMailAddress))
            using (SmtpClient smtp = new SmtpClient())
            {
                code = Convert.ToString(random.Next(100000, 999999));

                mailMessager.Subject = subject;
                mailMessager.Body = body + code;

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromMailAddress.Address, "%*kHy#l7~x");
                smtp.Send(mailMessager);

                return code;
            }
        }
        #endregion

        #region Хеширование пароля
        public string HashPassword(byte[] val)
        {
            using (SHA512Managed sha512 = new SHA512Managed())
            {
                var hash = sha512.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }
        #endregion

        #region Валидация логина
        public bool ValidationLogin(string log)
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9]{3,30}$";

            Match isMatch = Regex.Match(log, pattern);

            return isMatch.Success;
        }
        #endregion

        #region Валидация пароля. От 6 до 35 символов с минимум одной цифрой, одной заглавной и одной строчной буквой
        public bool ValidationPassword(string pass)
        {
            string pattern = @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{5,35})";

            Match isMatch = Regex.Match(pass, pattern);

            return isMatch.Success;
        }
        #endregion

        #region Валидация почты
        public bool ValidationEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatch.Success;
        }
        #endregion

        #region Проверка на уникальность логина
        public bool LoginOriginality(string log)
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT login FROM Users WHERE login = @log", connection.GetSqlConnect());
            selectLog.Parameters.AddWithValue("@log", SqlDbType.VarChar).Value = log;

            adapter.SelectCommand = selectLog;
            adapter.Fill(table);

            connection.CloseConnect();

            if (table.Rows.Count > 0)
                return false;
            else
                return true;
        }
        #endregion

        #region Проверка на уникальность почты
        public bool MailOriginality(string email)
        {
            ConnectionDB connection = new ConnectionDB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            connection.OpenConnect();

            SqlCommand selectLog = new SqlCommand("SELECT Email " +
                "FROM Employees " +
                "WHERE Email = @email", connection.GetSqlConnect());
            selectLog.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;

            adapter.SelectCommand = selectLog;
            adapter.Fill(table);

            connection.CloseConnect();

            if (table.Rows.Count > 0)
                return false;
            else
                return true;
        }
        #endregion
    }
}
