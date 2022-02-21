// See https://aka.ms/new-console-template for more information
using System;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string [] args)
        {
            
            var rules = new List<IRules>()
            {
                new DivisableRule(3, "Fizz"),
                new DivisableRule(5, "Buzz"),
                new DivisableRule(7, "Bang"),
                new OverwriteRule(11, "Bong"),
                new ComplexDivRule(13, "Fezz"),
                new ReverseRule(17),
            };
            var FizzBuzzer = new FizzBuzzer(rules);
            for (int i = 1; i <= 300; i++)
            {
                Console.WriteLine(FizzBuzzer.FizzBuzz(i));
            }
        }
    }
}