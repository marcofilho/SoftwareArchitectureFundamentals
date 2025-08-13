namespace OOP
{
    public abstract class HomeAppliance
    {
        private readonly string _name;
        private readonly int _voltage;

        protected HomeAppliance(string name, int voltage)
        {
            _name = name;
            _voltage = voltage;
        }

        public abstract void TurnOn();

        public abstract void TurnOff();

        public virtual void Test()
        {
            Console.WriteLine($"Testing {_name} at {_voltage} volts.");
        }
    }
}
