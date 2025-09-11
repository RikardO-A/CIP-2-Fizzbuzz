using System.Collections.Generic;

namespace FizzBuzz.Application
{
    public interface IFizzBuzzUseCase
    {
        List<string> GenerateFizzBuzz(int start, int end);
    }
}