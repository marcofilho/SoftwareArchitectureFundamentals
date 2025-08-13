namespace OOP
{
    public interface IRepository
    {
        void Add();
    }

    public class Repository : IRepository
    {

        public void Add()
        {
            Console.WriteLine("Addind item in Repository");
        }
    }

    public class FakeRepository : IRepository
    {
        public void Add()
        {
            Console.WriteLine("Addind item in FakeRepository");
        }
    }

    public class ImplementationUse
    {
        public void Process()
        {
            var repo = new Repository();
            repo.Add();
        }
    }

    public class AbstractionUse
    {
        private readonly IRepository _repository;

        public AbstractionUse(IRepository repository)
        {
            _repository = repository;
        }

        public void Process()
        {
            _repository.Add();
        }
    }

    public class ImplementationInterfaceTest
    {
        public ImplementationInterfaceTest()
        {
            var repoImp = new ImplementationUse();
            repoImp.Process();

            var repoAbs = new AbstractionUse(new Repository());
            repoAbs.Process();

            var repoAbsFake = new AbstractionUse(new FakeRepository());
            repoAbsFake.Process();
        }
    }
}
