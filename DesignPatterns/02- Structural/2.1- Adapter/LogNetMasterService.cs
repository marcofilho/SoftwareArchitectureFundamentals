namespace DesignPatterns
{
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Customized Log - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Customized Log - " + exception.Message);
        }
    }
}
