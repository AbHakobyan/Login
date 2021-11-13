using System.Net;
using System.Net.Mail;

namespace Login
{
    internal class EmailRegistr
    {
        SmtpClient smtpClient;
        //write email where the codes should be sent 
        static string fromMail = "user@gmail.com";
        static string password ="4546431";
        public EmailRegistr()
        { 
            smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail, password)
            };
        }

        public void SendEmail(string body, string toAddr)
        {
            using (var m = new MailMessage(fromMail,toAddr)
            {
                Subject = "Registration code",
                Body = body,
            })
            {
                m.IsBodyHtml = false;
                smtpClient.Send(m);
            }
        }
    }
}