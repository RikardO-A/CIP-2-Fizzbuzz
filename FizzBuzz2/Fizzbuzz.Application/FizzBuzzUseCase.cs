using System.Collections.Generic;
using FizzBuzz.Domain;

namespace FizzBuzz.Application
{
    public class FizzBuzzUseCase : IFizzBuzzUseCase
    {
        public FizzbuzzResult GenerateFizzBuzz(int start, int end)
        {
            var result = new FizzbuzzResult
            {
                Start = start,
                End = end,
                Results = new List<string>()
            };

            for (int i = start; i <= end; i++)
            {
                if (FizzBuzzPredicates.IsFizz(i) && FizzBuzzPredicates.IsBuzz(i))
                    result.Results.Add("FizzBuzz");
                else if (FizzBuzzPredicates.IsFizz(i))
                    result.Results.Add("Fizz");
                else if (FizzBuzzPredicates.IsBuzz(i))
                    result.Results.Add("Buzz");
                else
                    result.Results.Add(i.ToString());
            }

            return result;
        }
    }
}
