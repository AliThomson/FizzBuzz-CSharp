namespace FizzBuzz.Rules
{
    public interface IRules
    {
        List<string> Apply(List<string> previous, int number);
    }
}