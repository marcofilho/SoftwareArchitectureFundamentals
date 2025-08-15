namespace DesignPatterns.AbstractFactory
{
    // Abstract Factory
    public abstract class AutoHelpFactory
    {
        public abstract Winch CreateWinch();
        public abstract Vehicle CreateVehicle(string model, Size size);
    }
}