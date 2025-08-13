using System.Net.Mail;

namespace SOLID.SRP.Solution
{
    public static class EmailService
    {
        public static void SendEmail(string to, string from, string subject, string emailMessage)
        {
            var mail = new MailMessage(to, from);
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

            // Logic to send email
            Console.WriteLine($"Sending email to {to} with subject '{subject}'");
        }
    }
}
