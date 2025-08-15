namespace DesignPatterns
{
    public class BillPaymentService : IPayment
    {
        private readonly IBillPaymentFacade _billPaymentFacade;

        public BillPaymentService(IBillPaymentFacade billPaymentFacade)
        {
            _billPaymentFacade = billPaymentFacade;
        }

        public Payment Pay(Order order, Payment payment)
        {
            payment.Amount = order.Products.Sum(p => p.Amount);
            Console.WriteLine("Starting payement via Bill - Amount $ " + payment.Amount);


            payment.BillScanning = _billPaymentFacade.GenerateBill();
            payment.Status = "Waiting for Payment";
            return payment;
        }
    }
}
