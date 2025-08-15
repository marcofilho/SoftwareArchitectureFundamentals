namespace DesignPatterns
{
    public class ExecutionObserver
    {
        public static void Execute()
        {
            var john = new Observer("John");
            var eddy = new Observer("Eddy");
            var bill = new Observer("Bill");

            var amazon = new BovespaPaper("Amazon", NextDecimal());
            var microsoft = new BovespaPaper("Microsoft", NextDecimal());

            amazon.Subscribe(john);
            amazon.Subscribe(eddy);

            microsoft.Subscribe(eddy);
            microsoft.Subscribe(bill);

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Amount = NextDecimal();
                microsoft.Amount = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(eddy);
                }
            }
        }

        public static decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
            return r / (decimal)100000.00;
        }
    }
}
