namespace FizzBuzz.Rules
{
    public class ComplexDivRule : IRules
    {
        public int Divisor { get; set; }
        public string ToAdd { get; set; }
        public ComplexDivRule(int divisor, string toAdd )
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
            bool fizzExists = output.Exists(element => element == "Fizz");
            if (fizzExists)
            {
                output.Insert(1, ToAdd);
            }       
            else 
            {
                output.Insert(0, ToAdd); 
            }   
            return output;
        }
    }
}