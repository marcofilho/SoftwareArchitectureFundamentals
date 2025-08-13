namespace SOLID.DIP.Solution.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(string from, string to, string subject, string body);
    }
}
