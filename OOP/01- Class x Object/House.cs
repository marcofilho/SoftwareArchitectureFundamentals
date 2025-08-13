namespace OOP._01__Class_x_Object
{
    // Class definition for House
    public class House
    {
        public int SizeM2 { get; set; }
        public int Floors { get; set; }
        public decimal Price { get; set; }
        public int ParkingSpotsNumber { get; set; }
    }

    // Object of type House instantiation example

    public class HouseObject
    {
        public HouseObject()
        {
            // Object definition example
            var house = new House
            {
                SizeM2 = 100,
                Floors = 2,
                Price = 250000.00m,
                ParkingSpotsNumber = 2
            };

            // Example of using the house object
            System.Console.WriteLine($"House Size: {house.SizeM2} m², Floors: {house.Floors}, Price: {house.Price:C}, Parking Spots: {house.ParkingSpotsNumber}");
        }
    }
}
