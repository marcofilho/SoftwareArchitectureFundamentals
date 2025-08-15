namespace DesignPatterns
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Default Log - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Default Log - " + exception.Message);
        }
    }
}
