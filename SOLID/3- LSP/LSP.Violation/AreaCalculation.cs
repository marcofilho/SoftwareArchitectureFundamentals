namespace SOLID.LSP.Violation
{
    public class AreaCalculation
    {
        private static void GetRectangleArea(Rectangle rec)
        {
            Console.Clear();
            Console.WriteLine("Rectangle area calculation");
            Console.WriteLine();
            Console.WriteLine(rec.Height + " * " + rec.Width);
            Console.WriteLine();
            Console.WriteLine(rec.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var square = new Square()
            {
                Height = 10,
                Width = 5
            };

            GetRectangleArea(square);
        }
    }
}
