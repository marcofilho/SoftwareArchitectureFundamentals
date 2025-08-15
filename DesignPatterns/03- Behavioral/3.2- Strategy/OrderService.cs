namespace DesignPatterns
{
    public class OrderService
    {
        private readonly IPayment _payment;

        public OrderService(IPayment payment)
        {
            _payment = payment;
        }

        public Payment Pay(Order order, Payment payment)
        {
            return _payment.Pay(order, payment);
        }
    }
}
