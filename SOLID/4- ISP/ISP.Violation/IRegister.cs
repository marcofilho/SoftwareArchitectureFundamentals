namespace SOLID.ISP.Violation
{
    public interface IRegister
    {
        void ValidateDate();
        void Save();
        void SendEmail();
    }
}
