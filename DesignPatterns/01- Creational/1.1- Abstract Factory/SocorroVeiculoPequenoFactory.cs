namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class SmallVehicleAssistanceFactory : AutoHelpFactory
    {
        public override Winch CreateWinch()
        {
            return GuinchoCreator.Create(Size.Small);
        }

        public override Vehicle CreateVehicle(string modelo, Size size)
        {
            return VehicleCreator.Create(modelo, size);
        }
    }
}