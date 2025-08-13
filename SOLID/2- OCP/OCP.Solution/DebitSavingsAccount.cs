namespace SOLID.OCP.Solution
{
    public class DebitSavingsAccount : DebitAccount
    {
        public override string Debit(decimal amount, string accountNumber)
        {
            return FormatTransactionNumber() + " - Debit of " + amount.ToString("C") + " from saving account " + accountNumber;
        }
    }
}
