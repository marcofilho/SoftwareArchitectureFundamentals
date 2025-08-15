namespace DemoDI.Cases
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public interface ICustomerRepository
    {
        void Add(Customer customer);
    }

    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            // Do something with the customer, like saving to a database
        }
    }

    public interface ICustomerService
    {
        void Add(Customer customer);
    }

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
        }
    }
}
