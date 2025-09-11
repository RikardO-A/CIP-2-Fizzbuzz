using FizzBuzz.Domain;

namespace FizzBuzz.Application
{
    public interface IFizzBuzzUseCase
    {
        FizzbuzzResult GenerateFizzBuzz(int start, int end);
    }
}