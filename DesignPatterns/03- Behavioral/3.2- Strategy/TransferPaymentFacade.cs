namespace DesignPatterns
{
    public class TransferPaymentFacade : ITransferPaymentFacade
    {
        public string Transfer()
        {
            // Online Transfer simulation
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
