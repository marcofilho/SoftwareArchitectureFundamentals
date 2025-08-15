namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class LargeVehicleAssistanceFactory : AutoHelpFactory
    {
        public override Winch CreateWinch()
        {
            return GuinchoCreator.Create(Size.Large);
        }

        public override Vehicle CreateVehicle(string modelo, Size size)
        {
            return VehicleCreator.Create(modelo, size);
        }
    }
}