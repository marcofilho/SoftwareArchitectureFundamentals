namespace DesignPatterns.AbstractFactory
{
    // AbstractProduct  
    public abstract class Vehicle
    {
        protected Vehicle(string model, Size size)
        {
            Model = model;
            Size = size;
        }

        public string Model { get; set; }
        public Size Size { get; set; }

    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }

    // Concrect Product
    public class SmallVehicle : Vehicle
    {
        public SmallVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    // Concrect Product
    public class MediumVehicle : Vehicle
    {
        public MediumVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    // Concrect Product
    public class LargeVehicle : Vehicle
    {
        public LargeVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    public class VehicleCreator
    {
        public static Vehicle Create(string model, Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallVehicle(model, size);
                case Size.Medium:
                    return new MediumVehicle(model, size);
                case Size.Large:
                    return new LargeVehicle(model, size);
                default:
                    throw new ApplicationException("Unknow vehicle size.");
            }
        }
    }
}