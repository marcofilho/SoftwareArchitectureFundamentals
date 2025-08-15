namespace DesignPatterns
{
    public interface IPayment
    {
        Payment Pay(Order pedido, Payment pagamento);
    }
}