namespace SOLID.SRP.Solution
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate()) return "Customer data is invalid.";

            var repo = new CustomerRepository();
            repo.AddCustomer(customer);

            var companyEmail = "company@company.com";
            var subject = "Welcome!";
            var body = $"Customer {customer.Name} has been added.";

            EmailService.SendEmail(companyEmail, customer.Email.Address, subject, body);

            return body;
        }
    }
}
