namespace OOP
{
    public class Employee : Person
    {
        public DateTime AdmissionDate { get; set; }
        public string Register { get; set; }
    }

    public class Process
    {
        public void Execute()
        {
            var employee = new Employee
            {
                Name = "John Doe",
                BirthDate = new DateTime(1990, 1, 1),
                AdmissionDate = new DateTime(2020, 1, 1),
                Register = "12345"
            };

            int age = employee.CalculateAge();
            System.Console.WriteLine($"Employee: {employee.Name}, Age: {age}, Admission Date: {employee.AdmissionDate.ToShortDateString()}, Register: {employee.Register}");
        }
    }


}
