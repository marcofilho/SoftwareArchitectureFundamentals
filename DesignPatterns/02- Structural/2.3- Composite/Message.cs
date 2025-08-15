using System.Collections;

namespace DesignPatterns
{
    public class Message : IMessage, IEnumerable<IMessage>
    {
        private readonly List<IMessage> _list = new List<IMessage>();

        public string Name { get; set; }

        public Message(string name)
        {
            Name = name;
        }

        public void AddDaughter(IMessage daughter)
        {
            _list.Add(daughter);
        }

        public void RemoveDaughter(IMessage filha)
        {
            _list.Remove(filha);
        }

        public IMessage GetDaughter(int index)
        {
            return _list[index];
        }

        public IMessage GetDaughter(string name)
        {
            return _list.First(c => c.Name == name);
        }

        public IEnumerable<IMessage> GetList()
        {
            return _list;
        }

        public IEnumerator<IMessage> GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_list).GetEnumerator();
        }

        public void ShowMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);

            foreach (var message in _list)
            {
                message.ShowMessages(sub + 2);
            }
        }
    }
}