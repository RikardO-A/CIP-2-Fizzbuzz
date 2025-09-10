namespace FizzBuzz.Application;

GenerateFizzBuzz(int start, int end)
{
    List<string> results = new List<string>();
    for (int i = start; i <= end; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
            results.Add("FizzBuzz");
        else if (i % 3 == 0)
            results.Add("Fizz");
        else if (i % 5 == 0)
            results.Add("Buzz");
        else
            results.Add(i.ToString());
    }
    return results;
}
