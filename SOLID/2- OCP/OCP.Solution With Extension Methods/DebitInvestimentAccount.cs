namespace SOLID.OCP.Solution.With_Extension_Methods
{
    public static class DebitInvestimentAccount
    {
        public static string DebitFromInvestmentAccount(this DebitAccount debitAccount)
        {
            return debitAccount.FormatTransactionNumber() + " - Debit of " + debitAccount.Amount.ToString("C") + " from investment account " + debitAccount.AccountNumber;
        }
    }
}
