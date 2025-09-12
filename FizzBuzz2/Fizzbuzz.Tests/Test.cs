using FizzBuzz.Application;
using FizzBuzz.Domain;
using NUnit.Framework;

namespace Fizzbuzz.Tests;

public class FizzBuzzTests
{
    private IFizzBuzzService _fizzBuzzService;

    [SetUp]
    public void Setup()
    {
        _fizzBuzzService = new FizzBuzzService();
    }

    [Test]
    public void GenerateFizzBuzz_Range1To15_ReturnsCorrectSequence()
    {

        int start = 1;
        int end = 15;


        var result = _fizzBuzzService.GenerateFizzBuzz(start, end);



        Assert.That(result.Results.Count, Is.EqualTo(15));
        Assert.That(result.Results[0], Is.EqualTo("1"));
        Assert.That(result.Results[2], Is.EqualTo("Fizz")); // 3
        Assert.That(result.Results[4], Is.EqualTo("Buzz")); // 5
        Assert.That(result.Results[14], Is.EqualTo("FizzBuzz")); // 15
    }

    [Test]
    public void GenerateFizzBuzz_Range1To15_CountsAreCorrect()
    {

        int start = 1;
        int end = 15;


        var result = _fizzBuzzService.GenerateFizzBuzz(start, end);


        Assert.That(result.FizzCount, Is.EqualTo(4)); // 3, 6, 9, 12
        Assert.That(result.BuzzCount, Is.EqualTo(2)); // 5, 10
        Assert.That(result.FizzBuzzCount, Is.EqualTo(1)); // 15
    }

    [Test]
    public void FizzBuzzPredicates_IsFizz_ReturnsCorrectValue()
    {
        Assert.That(FizzBuzzPredicates.IsFizz(3), Is.True);
        Assert.That(FizzBuzzPredicates.IsFizz(6), Is.True);
        Assert.That(FizzBuzzPredicates.IsFizz(4), Is.False);
    }

    [Test]
    public void FizzBuzzPredicates_IsBuzz_ReturnsCorrectValue()
    {
        Assert.That(FizzBuzzPredicates.IsBuzz(5), Is.True);
        Assert.That(FizzBuzzPredicates.IsBuzz(10), Is.True);
        Assert.That(FizzBuzzPredicates.IsBuzz(4), Is.False);
    }
}