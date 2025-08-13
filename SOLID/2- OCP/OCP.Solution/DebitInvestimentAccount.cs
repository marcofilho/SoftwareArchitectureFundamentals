namespace SOLID.OCP.Solution
{
    public class DebitInvestimentAccount : DebitAccount
    {
        public override string Debit(decimal amount, string accountNumber)
        {
            return FormatTransactionNumber() + " - Debit of " + amount.ToString("C") + " from investment account " + accountNumber;
        }
    }
}
