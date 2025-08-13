namespace SOLID.DIP.Solution
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public CPF Cpf { get; set; }
        public DateTime CreatedAt { get; set; }

        public bool Validate()
        {
            return Email.Validate() && Cpf.Validate();
        }
    }
}
