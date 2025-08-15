namespace DesignPatterns
{
    internal class CalculatorCommand : Commander
    {
        private char _operator;
        private int _amount;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int amount)
        {
            _calculator = calculator;
            _operator = @operator;
            _amount = amount;
        }

        public char Operator
        {
            set => _operator = value;
        }

        public int Operand
        {
            set => _amount = value;
        }

        public override void Execute()
        {
            _calculator.Operation(_operator, _amount);
        }

        public override void Undo()
        {
            _calculator.Operation(Undo(_operator), _amount);
        }

        private static char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Unkown operator");
            }
        }
    }
}
