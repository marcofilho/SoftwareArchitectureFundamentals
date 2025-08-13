namespace SOLID.OCP.Violation
{
    public class DebitAccount
    {
        public void Debit(string account, decimal amount, AccountType accountType)
        {
            if (accountType == AccountType.Current)
            {
                // Logic for debiting a current account
            }

            if (accountType == AccountType.Savings)
            {
                // Logic for debiting a savings account
            }

            // If we need to add more account types, we have to modify this method,
            // which violates the Open/Closed Principle.
        }
    }
}
