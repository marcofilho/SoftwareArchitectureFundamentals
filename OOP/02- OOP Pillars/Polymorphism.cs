namespace OOP
{
    public class CoffeeMachine : HomeAppliance
    {
        public CoffeeMachine(string name, int voltage) : base(name, voltage)
        {
        }

        public CoffeeMachine() : base("Default", 220)
        {
        }

        public static void WarmWater()
        {
            Console.WriteLine("Warming water...");
        }

        public static void GrindGrails()
        {
            Console.WriteLine("Grainding grails...");
        }

        public void Prepare()
        {
            Test();
            WarmWater();
            GrindGrails();
        }

        public static void Test()
        {
            Console.WriteLine("Testing Coffee Machine...");
        }

        public override void TurnOff()
        {
            throw new NotImplementedException();
        }

        public override void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
