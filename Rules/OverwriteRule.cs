namespace FizzBuzz.Rules
{
    public class OverwriteRule : IRules
    {
        public int Divisor { get; set; }
        public string ToReplace { get; set; }
        public OverwriteRule(int divisor, string toReplace )
        {
            Divisor = divisor;
            ToReplace = toReplace;
        }
        public List<string> Apply(List<string> previous, int number)
        {
            if (number % Divisor != 0)
            {
                return previous;
            }
            
            return new List<string>() {ToReplace};
        }
    }
}