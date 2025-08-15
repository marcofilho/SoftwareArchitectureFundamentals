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
                Notify();
            }
        }


        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"Notifying that {observer.Name} is receiving updates from {Simbol}");
        }

        public void UnSubscribe(IObserver observador)
        {
            _observers.Remove(observador);
            Console.WriteLine($"Notifying that {observador.Name} is not receiving updates from {Simbol}");
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