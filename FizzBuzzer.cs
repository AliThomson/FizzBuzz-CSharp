namespace FizzBuzz.Rules;
public class FizzBuzzer
{
    public List<IRules> Rules { get; set; }
    public FizzBuzzer(List<IRules> rules)
    {
        Rules = rules;
    }
    public string FizzBuzz(int number)
    {
        List<string> output = new List<string>();
        foreach (IRules rule in Rules)
        {
            output = rule.Apply(output, number);
        }
        if (output.Count == 0)
        {
            output.Add(number.ToString());
        } 
        string result = string.Join("", output.ToArray());
        return result;
    }
}
