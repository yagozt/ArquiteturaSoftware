using System;
using System.Net.Mail;

namespace Arquitetura.SOLID.DIP.DIP.Violacao
{
    public static class EmailService
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        internal static void Enviar(string de, string para, string assunto, string corpo)
        {
            var mail = new MailMessage(de, para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"

            };
            mail.Subject = assunto;
            mail.Body = corpo;
            client.Send(mail);
        }
    }
}
