using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Main
{
    class SendingCode
    {
        public string FunSendingCode(string email, string subject, string body)
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
    }
}
