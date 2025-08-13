namespace SOLID.ISP.Violation
{
    internal class ProductRegister : IRegister
    {
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            // Product hasn't email, what should I do now???
            throw new NotImplementedException("This method is completely unnecessary");
        }

        public void ValidateDate()
        {
            throw new NotImplementedException();
        }
    }
}
