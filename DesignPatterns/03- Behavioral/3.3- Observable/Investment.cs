using DesignPatterns._03__Behavioral._3._3__Observable;

namespace DesignPatterns
{
    // Subject
    public abstract class Investment
    {
        private decimal _amount;
        private readonly List<IObserver> _observers = new List<IObserver>();

        protected Investment(string simbol, decimal amount)
        {
            Simbol = simbol;
            _amount = amount;
        }

        public string Simbol { get; }
        public decimal Amount
        {
            get => _amount;
            set
            {
                if (_amount == value) return;

                _amount = value;
                Notificar();
            }
        }


        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"Notificando que {observer.Name} está recebendo atualizãções de {Simbol}");
        }

        public void UnSubscribe(IObserver observador)
        {
            _observers.Remove(observador);
            Console.WriteLine($"Notificando que {observador.Nome} NÃO está recebendo atualizãções de {Simbol}");
        }

        private void Notify()
        {
            foreach (var investor in _observers)
            {
                investor.Notify(this);
            }

            Console.WriteLine("");
        }
    }
}