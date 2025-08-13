using System.Net.Mail;

namespace SOLID.DIP.Violation
{
    public static class EmailService
    {
        public static void SendEmail(string from, string to, string subject, string emailMessage)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = emailMessage;
            client.Send(mail);

            Console.WriteLine($"Sending email to {to} with subject '{subject}' and body message '{emailMessage}'");
        }
    }
}
