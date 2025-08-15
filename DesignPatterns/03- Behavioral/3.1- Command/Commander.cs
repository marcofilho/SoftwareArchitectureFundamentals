namespace DesignPatterns
{
    internal abstract class Commander
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
