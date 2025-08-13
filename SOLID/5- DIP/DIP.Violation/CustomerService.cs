using SOLID.SRP.Solution;

namespace SOLID.DIP.Violation
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate()) return "Invalid data!";

            var repo = new CustomerRepository();
            repo.AddCustomer(customer);

            var destination = "company@company.com";
            var subject = "Welcome";
            var bodyMessage = $"New customer added: {customer.Name}";

            EmailService.SendEmail(customer.Email.Address, destination, subject, bodyMessage);

            return bodyMessage;
        }
    }
}
