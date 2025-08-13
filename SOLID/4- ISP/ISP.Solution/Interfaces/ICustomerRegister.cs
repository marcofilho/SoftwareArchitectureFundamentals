namespace SOLID.ISP.Solution.Interfaces
{
    public interface ICustomerRegister : IRegister
    {
        void ValidateData();
        void SendEmail();
    }
}