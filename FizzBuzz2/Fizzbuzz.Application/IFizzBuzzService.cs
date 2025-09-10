namespace FizzBuzz.Application
{
    public interface IFizzBuzzService
    {
        List<string> GenerateFizzBuzz(int start, int end);
    }
}