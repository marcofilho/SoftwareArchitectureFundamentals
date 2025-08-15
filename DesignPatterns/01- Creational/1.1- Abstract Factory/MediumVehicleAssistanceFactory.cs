namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class MediumVehicleAssistanceFactory : AutoHelpFactory
    {
        public override Winch CreateWinch()
        {
            return GuinchoCreator.Create(Size.Medium);
        }

        public override Vehicle CreateVehicle(string modelo, Size size)
        {
            return VehicleCreator.Create(modelo, size);
        }
    }
}