namespace DesignPatterns
{
    internal class ExecutionAdapter
    {
        public static void Execute()
        {
            var defaultLogPayment = new TransactionService(new Logger());
            defaultLogPayment.MakeATransaction();

            var customLogPayment = new TransactionService(new LogAdapter(new LogNetMasterService()));
            customLogPayment.MakeATransaction();
        }
    }
}
