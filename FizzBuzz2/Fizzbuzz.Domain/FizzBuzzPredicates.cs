namespace FizzBuzz.Domain
{
public static class FizzBuzzPredicates
{
    public static bool IsFizz(int number) => number % 3 == 0;
    public static bool IsBuzz(int number) => number % 5 == 0;
    public static bool IsFizzBuzz(int number) => IsFizz(number) && IsBuzz(number);
}   
}