namespace DesignPatterns
{
    public class DomainMessage : IMessage
    {
        public string Name { get; set; }

        public DomainMessage(string name)
        {
            Name = name;
        }

        public void ShowMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);
        }
    }
}
