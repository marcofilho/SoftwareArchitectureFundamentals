namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the operation:");
            Console.WriteLine("");
            Console.WriteLine("1 - Encapsulation");
            Console.WriteLine("2 - Compostion Heritage 1");
            Console.WriteLine("3 - Compostion Heritage 2");
            Console.WriteLine("4 - Implementation Interface");

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    new CoffeeAutomation().ServeCoffee();
                    break;
                case '2':
                    new HeritageCompositionTest();
                    break;
                case '3':
                    new HeritageCompositionTest2();
                    break;
                case '4':
                    new ImplementationInterfaceTest();
                    break;
            }

            Main();
        }
    }
}
