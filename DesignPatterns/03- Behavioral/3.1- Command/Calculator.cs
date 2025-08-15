namespace DesignPatterns
{
    internal class Calculator
    {
        private int _currentAmount;

        public void Operation(char @operator, int amount)
        {
            switch (@operator)
            {
                case '+': _currentAmount += amount; break;
                case '-': _currentAmount -= amount; break;
                case '*': _currentAmount *= amount; break;
                case '/': _currentAmount /= amount; break;
            }
            Console.WriteLine("(Given {1} {2}) - Current Amount = {0,3}", _currentAmount, @operator, amount);
        }
    }
}
