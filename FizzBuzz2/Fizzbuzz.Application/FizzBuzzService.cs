using System.Collections.Generic;
using FizzBuzz.Domain;

namespace FizzBuzz.Application
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public FizzbuzzResult GenerateFizzBuzz(int start, int end)
        {
            return FizzBuzzCalc.GenerateFizzBuzz(start, end);
        }
    }
}
