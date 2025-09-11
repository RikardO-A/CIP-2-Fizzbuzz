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
                if (i % 3 == 0 && i % 5 == 0)
                    result.Results.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Results.Add("Fizz");
                else if (i % 5 == 0)
                    result.Results.Add("Buzz");
                else
                    result.Results.Add(i.ToString());
            }
            return result;
        }
    }
}
