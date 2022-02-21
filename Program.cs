// See https://aka.ms/new-console-template for more information
using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string [] args)
        {
            var FizzBuzzer = new FizzBuzzer();
            for (int i = 1; i <= 300; i++)
            {
                Console.WriteLine(FizzBuzzer.FizzBuzz(i));
            }
        }
    }
}