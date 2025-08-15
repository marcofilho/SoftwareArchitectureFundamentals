namespace DemoDI.Cases
{
    public interface IService
    {
        string ReturnValue();
    }
    public class ServiceA : IService
    {
        public string ReturnValue()
        {
            return "A";
        }
    }
    public class ServiceB : IService
    {
        public string ReturnValue()
        {
            return "B";
        }
    }
    public class ServiceC : IService
    {
        public string ReturnValue()
        {
            return "C";
        }
    }
}
