using SOLID.OCP.Solution.With_Extension_Methods;

namespace SOLID.OCP.Solution_With_Extension_Methods
{
    public class ATM
    {
        public static void Operations()
        {
            OperationsMenu();

            var option = Console.ReadKey();
            var returnValue = string.Empty;

            var dataDebit = DebitData();

            switch (option.KeyChar)
            {
                case '1':
                    Console.WriteLine("Effecting operation in Current Account");
                    returnValue = dataDebit.DebitFromCurrentAccount();
                    break;
                case '2':
                    Console.WriteLine("Effecting operation in Savings Account");
                    returnValue = dataDebit.DebitFromSavingsAccount();
                    break;
                case '3':
                    Console.WriteLine("Effecting operation in Investment Account");
                    returnValue = dataDebit.DebitFromInvestmentAccount();
                    break;
            }

            TransactionReturn(returnValue);
        }

        private static void OperationsMenu()
        {
            Console.Clear();
            Console.WriteLine("SOLID ATM");
            Console.WriteLine("Select your option:");
            Console.WriteLine();
            Console.WriteLine("1 - Withdraw Current Account");
            Console.WriteLine("2 - Withdraw Investment Account");
            Console.WriteLine("3 - Withdraw Savings Account");
        }

        private static DebitAccount DebitData()
        {
            Console.WriteLine();
            Console.WriteLine("..............................");
            Console.WriteLine();
            Console.WriteLine("Inform the Account");
            var account = Console.ReadLine();
            Console.WriteLine("Inform the Amount");
            var amount = Convert.ToDecimal(Console.ReadLine());

            var debitAccount = new DebitAccount()
            {
                AccountNumber = account,
                Amount = amount
            };

            return debitAccount;
        }

        private static void TransactionReturn(string transactionNumber)
        {
            Console.WriteLine();
            Console.WriteLine("Success! Transaction number: " + transactionNumber);
            Console.ReadKey();
        }
    }
}
