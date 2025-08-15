namespace DesignPatterns.AbstractFactory
{
    public class ExecutionAbstractFactory
    {
        public static void Execute()
        {
            var veiculosSocorro = new List<Vehicle>
            {
                VehicleCreator.Create("Celta", Size.Small),
                VehicleCreator.Create("Jetta", Size.Medium),
                VehicleCreator.Create("BMW X6", Size.Large)
            };

            veiculosSocorro.ForEach(v => AutoHelp.CreateAutoHelp(v).PerformService());
        }
    }
}