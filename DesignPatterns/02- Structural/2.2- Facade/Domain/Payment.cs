namespace DesignPatterns
{
    public class Payment
    {
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CreditCard { get; set; }
        public string BillScanning { get; set; }
        public string TransactionConfirmation { get; set; }
    }
}