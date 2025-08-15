namespace DesignPatterns
{
    public class TransferPaymentService : IPayment
    {
        private readonly ITransferPaymentFacade _transferPaymentFacade;

        public TransferPaymentService(ITransferPaymentFacade transferPaymentFacade)
        {
            _transferPaymentFacade = transferPaymentFacade;
        }

        public Payment Pay(Order order, Payment payment)
        {
            payment.Amount = order.Products.Sum(p => p.Amount);
            Console.WriteLine("Starting payment via Online TransferIniciando - Amount $ " + payment.Amount);

            payment.TransactionConfirmation = _transferPaymentFacade.Transfer();
            payment.Status = "Paid via Online Transfer";

            return payment;
        }
    }
}
