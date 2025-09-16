using System.Collections.Generic;
using FizzBuzz.Domain;

namespace FizzBuzz.Application
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public FizzbuzzResult GenerateFizzBuzz(long start, long end)
        {
            return FizzBuzzCalc.GenerateFizzBuzz(start, end);
        }
    }
}
