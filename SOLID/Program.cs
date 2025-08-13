using SOLID.LSP.Solution;
using SOLID.OCP.Solution_With_Extension_Methods;

namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Choose the Operation");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    ATM.Operations();
                    break;
                case '2':
                    AreaCalculation.Calculate();
                    break;
            }
        }

    }
}

