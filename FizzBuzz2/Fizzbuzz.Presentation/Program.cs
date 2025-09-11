using System.Collections.Generic;
using FizzBuzz.Application;


class Program
{
    static void Main(string[] args)
    {
        IFizzBuzzUseCase fizzBuzzUseCase = new FizzBuzzUseCase();
        var results = fizzBuzzUseCase.GenerateFizzBuzz(1, 100);
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}
