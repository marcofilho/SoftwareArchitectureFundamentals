namespace DesignPatterns
{
    public class TransactionService
    {
        private readonly ILogger _logger;

        public TransactionService(ILogger logger)
        {
            _logger = logger;
        }

        public void MakeATransaction()
        {
            // Transação
            _logger.Log("Transaction completed.");
        }
    }
}
