namespace OOP
{
    #region Case 1

    public class Individual : Person
    {
        public string Cpf { get; set; }
    }

    public class Individual2
    {
        public Person Person { get; set; }
        public string Cpf { get; set; }
    }

    public class HeritageCompositionTest
    {
        public HeritageCompositionTest()
        {
            var heritagePerson = new Individual
            {
                Name = "Joao",
                BirthDate = DateTime.Now,
                Cpf = "32165498765"
            };

            var compositionPerson = new Individual2
            {
                Person = new Person
                {
                    Name = "Joao",
                    BirthDate = DateTime.Now,
                },
                Cpf = "32165498765"
            };

            var heritageName = heritagePerson.Name;
            var compositionName = compositionPerson.Person.Name;

            Console.WriteLine($"Heritage Name: {heritageName}");
            Console.WriteLine($"Composition Name: {compositionName}");
        }
    }

    #endregion

    #region Case 2

    public interface IRepository<T>
    {
        void Add(T obj);

        void Remove(T obj);
    }

    public interface IPersonRepository
    {
        void Add(Person obj);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Add(T obj)
        {
            Console.WriteLine($"Adding {typeof(T).Name} to repository.");
        }

        public void Remove(T obj)
        {
            Console.WriteLine($"Removing {typeof(T).Name} from repository.");
        }
    }

    public class HeritagePersonRepository : Repository<Person>, IPersonRepository
    {

    }

    public class CompositionPersonRepository : IPersonRepository
    {
        private readonly IRepository<Person> _personRepository;

        public CompositionPersonRepository(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public void Add(Person obj)
        {
            _personRepository.Add(obj);
        }
    }

    public class HeritageCompositionTest2
    {
        public HeritageCompositionTest2()
        {
            var repoH = new HeritagePersonRepository();
            repoH.Add(new Person());
            repoH.Remove(new Person());

            var repoC = new CompositionPersonRepository(new Repository<Person>());
            repoC.Add(new Person());
        }
    }

    #endregion
}