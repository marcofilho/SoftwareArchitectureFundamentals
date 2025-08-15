namespace DesignPatterns.AbstractFactory
{
    // Client Class
    public class AutoHelp
    {
        private readonly Vehicle _vehicle;
        private readonly Winch _winch;

        public AutoHelp(AutoHelpFactory factory, Vehicle vehicle)
        {
            _vehicle = factory.CreateVehicle(vehicle.Model, vehicle.Size);
            _winch = factory.CreateWinch();
        }

        public void PerformService()
        {
            _winch.Rescue(_vehicle);
        }

        public static AutoHelp CreateAutoHelp(Vehicle vehicle)
        {
            switch (vehicle.Size)
            {
                case Size.Small:
                    return new AutoHelp(new SmallVehicleAssistanceFactory(), vehicle);
                case Size.Medium:
                    return new AutoHelp(new MediumVehicleAssistanceFactory(), vehicle);
                case Size.Large:
                    return new AutoHelp(new LargeVehicleAssistanceFactory(), vehicle);
                default:
                    throw new ApplicationException("Unable to identify vehicle.");
            }
        }
    }
}