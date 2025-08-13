namespace SOLID.OCP.Solution
{
    public class DebitCurrentAccount : DebitAccount
    {
        public override string Debit(decimal amount, string accountNumber)
        {
            return FormatTransactionNumber() + " - Debit of " + amount.ToString("C") + " from current account " + accountNumber;
        }
    }
}
