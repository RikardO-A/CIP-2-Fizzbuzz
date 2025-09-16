namespace FizzBuzz.Domain
{
    public static class FizzBuzzPredicates
    {
        public static bool IsFizz(long number) => number % 3 == 0;
        public static bool IsBuzz(long number) => number % 5 == 0;
        public static bool IsFizzBuzz(long number) => IsFizz(number) && IsBuzz(number);
    }
}