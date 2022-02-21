namespace FizzBuzz;
public class FizzBuzzer
{
    public string FizzBuzz(int number)
    {
        var output = new List<string>();

        if (number % 3 == 0) 
        {
            output.Add("Fizz");
        }
        if (number % 5 == 0) 
        {
            output.Add("Buzz");
        }
        if (number % 7 == 0) 
        {
            output.Add("Bang");
        }
        if (number % 11 == 0) 
        {
            output.Clear();
            output.Add("Bong");
        }
        if (number % 13 == 0) 
        {
            bool fizzExists = output.Exists(element => element == "Fizz");
            if (fizzExists)
            {
                output.Insert(1, "Fezz");
            }       
            else 
            {
                output.Insert(0, "Fezz"); 
            }   
        }
        if (number % 17 == 0) 
        {
            output.Reverse();
        }
        if (output.Count == 0)
        {
            output.Add(number.ToString());
        } 
        string result = string.Join("", output.ToArray());
        return result;
    }
}
