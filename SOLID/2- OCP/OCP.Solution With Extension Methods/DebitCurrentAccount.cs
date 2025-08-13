namespace SOLID.OCP.Solution.With_Extension_Methods
{
    public static class DebitCurrentAccount
    {
        public static string DebitFromCurrentAccount(this DebitAccount debitAccount)
        {
            return debitAccount.FormatTransactionNumber() + " - Debit of " + debitAccount.Amount.ToString("C") + " from current account " + debitAccount.AccountNumber;
        }
    }
}
