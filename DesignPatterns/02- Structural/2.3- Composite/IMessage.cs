namespace DesignPatterns
{
    public interface IMessage
    {
        string Name { get; set; }
        void ShowMessages(int sub);
    }
}
