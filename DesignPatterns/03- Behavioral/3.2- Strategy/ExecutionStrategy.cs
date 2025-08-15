namespace DesignPatterns
{
    public class ExecutionStrategy
    {
        private const string _creditCard = "5555 2222 5555 9999";

        public static void Execute()
        {
            var products = new List<Product>
            {
                new Product{Name =  "Adidas Sneakers", Amount = new Random().Next(500)},
                new Product{Name = "Bowling T-Shirt", Amount = new Random().Next(500)},
                new Product{Name = "Tennis Racket", Amount = new Random().Next(500)}
            };

            var order = new Order
            {
                Id = Guid.NewGuid(),
                Products = products
            };

            var creditPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.CreditCard,
                CreditCard = _creditCard
            };

            var billPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.Bill
            };

            var transferPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.BankingTransfer,
                CreditCard = _creditCard
            };

            #region Simple coding way

            var creditOrder = new OrderService(
                                   new CreditCardPaymentService(
                                   new CreditCardPaymentFacade(
                                   new PayPalGateway(),
                                   new ConfigurationManager())));

            var creditPayment = creditOrder.Pay(order, creditPaymentMethod);

            Console.WriteLine(creditPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            var billOrder = new OrderService(
                                   new BillPaymentService(
                                   new BillPaymentFacade()));

            var billPayment = billOrder.Pay(order, billPaymentMethod);

            Console.WriteLine(billPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            var transferOrder = new OrderService(
                                          new TransferPaymentService(
                                          new TransferPaymentFacade()));

            var transferPayment = transferOrder.Pay(order, billPaymentMethod);

            Console.WriteLine(transferPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            #endregion

            #region Best coding way

            var creditOrder2 = new OrderService(PaymentFactory.MakeAPayment(creditPaymentMethod.PaymentMethod));
            var pagamentoCredito2 = creditOrder2.Pay(order, creditPaymentMethod);

            Console.WriteLine(pagamentoCredito2.Status);

            Console.WriteLine("-------------------------------------------------------");

            var pedidoBoleto2 = new OrderService(PaymentFactory.MakeAPayment(billPaymentMethod.PaymentMethod));
            var pagamentoBoleto2 = pedidoBoleto2.Pay(order, billPaymentMethod);
            Console.WriteLine(pagamentoBoleto2.Status);

            Console.WriteLine("-------------------------------------------------------");

            var pedidoTransferencia2 = new OrderService(PaymentFactory.MakeAPayment(transferPaymentMethod.PaymentMethod));
            var pagamentoTransferencia2 = pedidoTransferencia2.Pay(order, transferPaymentMethod);
            Console.WriteLine(pagamentoTransferencia2.Status);

            #endregion
        }
    }
}
