using DesignPatterns._03__Behavioral._3._3__Observable;

namespace DesignPatterns
{

    // Concrete Subject
    public class BovespaPaper : Investment
    {
        public BovespaPaper(string simbolo, decimal preco)
            : base(simbolo, preco)
        {
        }
    }
}