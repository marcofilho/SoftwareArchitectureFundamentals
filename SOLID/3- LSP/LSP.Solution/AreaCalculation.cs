namespace SOLID.LSP.Solution
{
    public class AreaCalculation
    {
        private static void GetParallelogramArea(Parallelogram palm)
        {
            Console.Clear();
            Console.WriteLine("Rectangle calculation area.");
            Console.WriteLine();
            Console.WriteLine(palm.Height + " * " + palm.Width);
            Console.WriteLine();
            Console.WriteLine(palm.Area);
            Console.ReadKey();
        }

        public static void Calculate()
        {
            var square = new Square(5, 5);
            var rectangle = new Rectangle(10, 5);

            GetParallelogramArea(square);
            GetParallelogramArea(rectangle);
        }
    }
}
