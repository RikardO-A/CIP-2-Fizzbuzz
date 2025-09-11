using FizzBuzz.Domain;

namespace FizzBuzz.Application
{
    public interface IFizzBuzzService
    {
        FizzbuzzResult GenerateFizzBuzz(int start, int end);
    }
}