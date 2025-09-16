using System.Collections.Generic;
using FizzBuzz.Application;
using FizzBuzz.Domain;

Console.WriteLine("Enter an integer (Between 1 to 10^15)");
long input = long.Parse(Console.ReadLine() ?? "CS8604 Null reference detta tar bort erroret xD");
if (input < 1 || input > 1000000000000000)
{
    Console.WriteLine("Input must be between 1 and 10^15");
    return;
}

Console.WriteLine("FizzBuzz Start:");
IFizzBuzzService fizzBuzzService = new FizzBuzzService();
var fizzBuzzResult = fizzBuzzService.GenerateFizzBuzz(1, input);

Console.WriteLine("Fizz: " + fizzBuzzResult.FizzCount);
Console.WriteLine("Buzz: " + fizzBuzzResult.BuzzCount);
Console.WriteLine("FizzBuzz: " + fizzBuzzResult.FizzBuzzCount);
