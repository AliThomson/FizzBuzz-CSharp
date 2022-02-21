namespace FizzBuzz.Rules
{
    public class DivisableRule : IRules
    {
        public int Divisor { get; set; }
        public string ToAdd { get; set; }
        public DivisableRule(int divisor, string toAdd )
        {
            Divisor = divisor;
            ToAdd = toAdd;
        }
        public List<string> Apply(List<string> previous, int number)
        {
            if (number % Divisor != 0)
            {
                return previous;
            }
            var output = new List<string>(previous);
            output.Add(ToAdd);
            return output;
        }
    }
}