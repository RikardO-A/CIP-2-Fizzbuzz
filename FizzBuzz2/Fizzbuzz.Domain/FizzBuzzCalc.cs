using System.Collections.Generic;
using FizzBuzz.Domain;

//Q:Skapade en statisk klass för minskad komplexitet, är detta rätt eller fel?
namespace FizzBuzz.Domain
{
    public static class FizzBuzzCalc
    {
        public static FizzbuzzResult GenerateFizzBuzz(int start, int end)
        {
            var result = new FizzbuzzResult
            {
                Start = start,
                End = end,
                Results = new List<string>(),
                FizzCount = 0,
                BuzzCount = 0,
                FizzBuzzCount = 0,
                TotalCount = 0,

            };

            for (int i = start; i <= end; i++)
            {

                if (FizzBuzzPredicates.IsFizzBuzz(i))
                {
                    result.Results.Add("FizzBuzz");
                    result.FizzBuzzCount++;
                }
                else if (FizzBuzzPredicates.IsFizz(i))
                {
                    result.Results.Add("Fizz");
                    result.FizzCount++;
                }
                else if (FizzBuzzPredicates.IsBuzz(i))
                {
                    result.Results.Add("Buzz");
                    result.BuzzCount++;
                }
                else
                {
                    result.Results.Add(i.ToString());
                }
            }
            result.TotalCount = result.Results.Count;

            return result;
        }
    }
}
