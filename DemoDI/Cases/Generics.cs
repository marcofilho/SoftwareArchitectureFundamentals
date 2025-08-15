namespace DemoDI.Cases
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T obj)
        {
            // Do some generic operation
        }
    }
}
