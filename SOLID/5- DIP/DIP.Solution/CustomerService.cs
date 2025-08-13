using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailService _emailService;

        public CustomerService(ICustomerRepository customerRepository, IEmailService emailService)
        {
            _customerRepository = customerRepository;
            _emailService = emailService;
        }

        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate()) return "Invalid customer data";

            var destination = "company@company.com";
            var subject = "Welcome";
            var bodyMessage = $"New customer added: {customer.Name}";

            _emailService.SendEmail(customer.Email.Address, destination, subject, bodyMessage);

            return bodyMessage;
        }
    }
}
