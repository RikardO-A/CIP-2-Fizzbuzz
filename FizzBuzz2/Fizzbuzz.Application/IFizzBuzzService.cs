using FizzBuzz.Domain;

namespace FizzBuzz.Application
{
    public interface IFizzBuzzService
    {
        FizzbuzzResult GenerateFizzBuzz(long start, long end);
    }
}