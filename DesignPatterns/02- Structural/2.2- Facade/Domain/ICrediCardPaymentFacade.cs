namespace DesignPatterns
{
    public interface ICrediCardPaymentFacade
    {
        bool Pay(Order order, Payment payment);
    }
}