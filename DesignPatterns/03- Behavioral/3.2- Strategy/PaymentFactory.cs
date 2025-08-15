namespace DesignPatterns
{
    public class PaymentFactory
    {
        public static IPayment MakeAPayment(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPaymentService(
                               new CreditCardPaymentFacade(
                               new PayPalGateway(),
                               new ConfigurationManager()));

                case PaymentMethod.Bill:
                    return new BillPaymentService(new BillPaymentFacade());

                case PaymentMethod.BankingTransfer:
                    return new TransferPaymentService(new TransferPaymentFacade());

                default:
                    throw new ApplicationException("Payment Method not allowed.");
            }
        }
    }
}
