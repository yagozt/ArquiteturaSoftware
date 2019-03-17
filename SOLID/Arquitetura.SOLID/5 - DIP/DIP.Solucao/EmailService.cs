using System;
using System.Net.Mail;
using Arquitetura.SOLID.DIP.DIP.Solucao.Interfaces;

namespace Arquitetura.SOLID.DIP.DIP.Solucao
{
    public class EmailService : IEmailServices
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public void Enviar(string de, string para, string assunto, string corpo)
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
