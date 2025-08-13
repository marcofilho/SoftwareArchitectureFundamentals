namespace SOLID.OCP.Solution.With_Extension_Methods
{
    public static class DebitSavingsAccount
    {
        public static string DebitFromSavingsAccount(this DebitAccount debitAccount)
        {
            return debitAccount.FormatTransactionNumber() + " - Debit of " + debitAccount.Amount.ToString("C") + " from savings account " + debitAccount.AccountNumber;
        }
    }
}
