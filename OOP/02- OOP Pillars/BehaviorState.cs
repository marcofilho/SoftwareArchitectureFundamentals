namespace OOP
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;

            if (BirthDate > today.AddYears(-age)) age--;

            return age;
        }
    }
}
