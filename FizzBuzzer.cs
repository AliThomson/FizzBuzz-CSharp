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

        
        // if (number % 11 == 0) 
        // {
        //     output.Clear();
        //     output.Add("Bong");
        // }
        // if (number % 13 == 0) 
        // {
        //     bool fizzExists = output.Exists(element => element == "Fizz");
        //     if (fizzExists)
        //     {
        //         output.Insert(1, "Fezz");
        //     }       
        //     else 
        //     {
        //         output.Insert(0, "Fezz"); 
        //     }   
        // }
        // if (number % 17 == 0) 
        // {
        //     output.Reverse();
        // }
        if (output.Count == 0)
        {
            output.Add(number.ToString());
        } 
        string result = string.Join("", output.ToArray());
        return result;
    }
}
