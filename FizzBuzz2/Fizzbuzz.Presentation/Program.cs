using System.Collections.Generic;
using FizzBuzz.Application;
using FizzBuzz.Domain;

Console.WriteLine("Enter an integer (Between 1 to 10^5)");
int input = int.Parse(Console.ReadLine());
if (input < 1 || input > 100000)
{
    Console.WriteLine("Input must be between 1 and 10^5");
    return;
}

Console.WriteLine("FizzBuzz Start:");
IFizzBuzzService fizzBuzzService = new FizzBuzzService();
var fizzBuzzResult = fizzBuzzService.GenerateFizzBuzz(1, input);

Console.WriteLine("Fizz: " + fizzBuzzResult.FizzCount);
Console.WriteLine("Buzz: " + fizzBuzzResult.BuzzCount);
Console.WriteLine("FizzBuzz: " + fizzBuzzResult.FizzBuzzCount);
