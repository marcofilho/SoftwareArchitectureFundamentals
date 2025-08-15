namespace DesignPatterns
{
    public class BillPaymentFacade : IBillPaymentFacade
    {
        public string GenerateBill()
        {
            // Generate Bill
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
