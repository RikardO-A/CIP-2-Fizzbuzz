using System.Collections.Generic;
using FizzBuzz.Application;


class Program
{
    static void Main(string[] args)
    {
        //Interface -> Implementation -> Use Case -> Result -> Presentation
        IFizzBuzzUseCase fizzBuzzUseCase = new FizzBuzzUseCase();
        var fizzBuzzResult = fizzBuzzUseCase.GenerateFizzBuzz(1, 100);
        foreach (var result in fizzBuzzResult.Results)
        {
            Console.WriteLine(result);
        }
    }
}
