namespace DesignPatterns
{
    public interface IObserver
    {
        string Name { get; }
        void Notify(Investment investiment);
    }
}
