namespace DesignPatterns
{
    public class CreditCardPaymentService : IPayment
    {
        private readonly ICrediCardPaymentFacade _creditCardPaymentFacade;

        public CreditCardPaymentService(ICrediCardPaymentFacade creditCardPaymentFacade)
        {
            _creditCardPaymentFacade = creditCardPaymentFacade;
        }

        public Payment Pay(Order order, Payment payment)
        {
            payment.Amount = order.Products.Sum(p => p.Amount);
            Console.WriteLine("Starting the payment via Credit Card - Amount $ " + payment.Amount);

            if (_creditCardPaymentFacade.Pay(order, payment))
            {
                payment.Status = "Paid by Credit Card!";
                return payment;
            }

            payment.Status = "Credit Card refused!";
            return payment;
        }
    }
}