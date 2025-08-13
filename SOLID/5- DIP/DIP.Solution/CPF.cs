namespace SOLID.DIP.Solution
{
    public class CPF
    {
        public string Number { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(Number) && Number.Length == 11 && Number.All(char.IsDigit);
        }
    }
}
