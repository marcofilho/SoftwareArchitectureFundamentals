namespace DesignPatterns
{
    public class ExecutionFacade
    {
        public static void Execute()
        {
            var products = new List<Product>
            {
                new Product{Name = "Adidas Sneaker", Amount = new Random().Next(500)},
                new Product{Name = "Bowling T-Shirt", Amount = new Random().Next(500)},
                new Product{Name = "Tennis Racket", Amount = new Random().Next(500)}
            };

            var order = new Order
            {
                Id = Guid.NewGuid(),
                Products = products
            };

            var payment = new Payment
            {
                CreditCard = "5555 2222 5555 9999"
            };

            var paymentService = new CreditCardPaymentService(new CreditCardPaymentFacade(new PayPalGateway(), new ConfigurationManager()));

            var pagamentoResult = paymentService.Pay(order, payment);

            Console.WriteLine(pagamentoResult.Status);
        }
    }

}