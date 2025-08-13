namespace SOLID.OCP.Solution.With_Extension_Methods
{
    public class DebitAccount
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string TransactionNumber { get; set; }

        public string FormatTransactionNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();

            TransactionNumber = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            //Formatted Transaction Number: XXXX-XXXX-XXXX-XXX
            return TransactionNumber;
        }
    }
}
