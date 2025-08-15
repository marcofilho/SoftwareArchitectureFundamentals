﻿namespace DesignPatterns
{
    public class CreditCardPaymentFacade : ICrediCardPaymentFacade
    {
        private readonly IPayPalGateway _payPalGateway;
        private readonly IConfigurationManager _configManager;

        public CreditCardPaymentFacade(IPayPalGateway payPalGateway, IConfigurationManager configManager)
        {
            _payPalGateway = payPalGateway;
            _configManager = configManager;
        }

        public bool Pay(Order order, Payment payment)
        {
            var apiKey = _configManager.GetValue("apiKey");
            var encriptionKey = _configManager.GetValue("encriptionKey");

            var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, payment.CreditCard);

            var paymentResult = _payPalGateway.CommitTransaction(cardHashKey, order.Id.ToString(), payment.Amount);

            return paymentResult;
        }
    }
}