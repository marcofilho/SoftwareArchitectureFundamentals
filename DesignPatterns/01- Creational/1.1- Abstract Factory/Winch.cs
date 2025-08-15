namespace DesignPatterns.AbstractFactory
{
    // AbstractProduct   
    public abstract class Winch
    {
        protected Winch(Size size)
        {
            Size = size;
        }

        public abstract void Rescue(Vehicle vehicle);
        public Size Size { get; set; }
    }

    // Concret Product
    public class SmallWinch : Winch
    {
        public SmallWinch(Size porte) : base(porte) { }

        public override void Rescue(Vehicle vehicle)
        {
            // Rescue Process
            Console.WriteLine("Rescuing a small Car - Model " + vehicle.Model);
        }
    }

    // Concret Product
    public class MediumWinch : Winch
    {
        public MediumWinch(Size porte) : base(porte) { }

        public override void Rescue(Vehicle veiculo)
        {
            // Rescue Process
            Console.WriteLine("Rescuing a medium Car - Model " + veiculo.Model);
        }
    }

    // Concret Product
    public class LargeWinch : Winch
    {
        public LargeWinch(Size porte) : base(porte) { }

        public override void Rescue(Vehicle veiculo)
        {
            // Rescue Process
            Console.WriteLine("Rescuing a large Car - Model " + veiculo.Model);
        }
    }

    public class GuinchoCreator
    {
        public static Winch Create(Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallWinch(size);
                case Size.Medium:
                    return new MediumWinch(size);
                case Size.Large:
                    return new LargeWinch(size);
                default:
                    throw new ApplicationException("Porte de Guincho desconhecido.");
            }
        }
    }
}