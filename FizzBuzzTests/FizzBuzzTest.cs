namespace FizzBuzz;

using Xunit;

public class FizzBuzzTest
{
    [Fact]
    public void NonMultipleOfThreeOrFiveArePreserved()
    {
        Assert.Equal("1", new FizzBuzz().Convert(1));
        Assert.Equal("4", new FizzBuzz().Convert(4));
    }

    [Fact]
    public void NonMultipleOfThreeOrFiveOrSevenOrElevenArePreserved()
    {
        Assert.Equal("2", new FizzBuzz().Convert(2));
        Assert.Equal("8", new FizzBuzz().Convert(8));
    }

    [Fact]
    public void MultipleOfThreeAreFizz()
    {
        Assert.Equal("Fizz", new FizzBuzz().Convert(3));
        Assert.Equal("Fizz", new FizzBuzz().Convert(6));
    }

    [Fact]
    public void MultipleOfFiveAreBuzz()
    {
        Assert.Equal("Buzz", new FizzBuzz().Convert(5));
        Assert.Equal("Buzz", new FizzBuzz().Convert(10));
    }

    [Fact]
    public void MultipleOfSevenAreWhizz()
    {
        Assert.Equal("Whizz", new FizzBuzz().Convert(7));
        Assert.Equal("Whizz", new FizzBuzz().Convert(14));
    }

    [Fact]
    public void MultipleOfElevenAreBang()
    {
        Assert.Equal("Bang", new FizzBuzz().Convert(11));
        Assert.Equal("Bang", new FizzBuzz().Convert(22));
    }

    [Fact]
    public void MultipleOfThreeAndFiveAreFizzBuzz()
    {
        Assert.Equal("FizzBuzz", new FizzBuzz().Convert(15));
        Assert.Equal("FizzBuzz", new FizzBuzz().Convert(30));
    }

    [Fact]
    public void MultipleOfThreeAndSevenAreFizzWhizz()
    {
        Assert.Equal("FizzWhizz", new FizzBuzz().Convert(21));
        Assert.Equal("FizzWhizz", new FizzBuzz().Convert(42));
    }

    [Fact]
    public void MultipleOfThreeAndElevenAreFizzBang()
    {
        Assert.Equal("FizzBang", new FizzBuzz().Convert(33));
        Assert.Equal("FizzBang", new FizzBuzz().Convert(66));
    }

    [Fact]
    public void MultipleOfFiveAndSevenAreBuzzWhizz()
    {
        Assert.Equal("BuzzWhizz", new FizzBuzz().Convert(35));
        Assert.Equal("BuzzWhizz", new FizzBuzz().Convert(70));
    }

    [Fact]
    public void MultipleOfFiveAndElevenAreBuzzBang()
    {
        Assert.Equal("BuzzBang", new FizzBuzz().Convert(55));
        Assert.Equal("BuzzBang", new FizzBuzz().Convert(110));
    }

    [Fact]
    public void MultipleOfSevenAndElevenAreWhizzBang()
    {
        Assert.Equal("WhizzBang", new FizzBuzz().Convert(77));
        Assert.Equal("WhizzBang", new FizzBuzz().Convert(154));
    }

    [Fact]
    public void MultipleOfThreeAndFiveAndSevenAreFizzBuzzWhizz()
    {
        Assert.Equal("FizzBuzzWhizz", new FizzBuzz().Convert(105));
        Assert.Equal("FizzBuzzWhizz", new FizzBuzz().Convert(210));
    }

    [Fact]
    public void MultipleOfThreeAndFiveAndElevenAreFizzBuzzBang()
    {
        Assert.Equal("FizzBuzzBang", new FizzBuzz().Convert(165));
        Assert.Equal("FizzBuzzBang", new FizzBuzz().Convert(330));
    }

    [Fact]
    public void MultipleOfThreeAndSevenAndElevenAreFizzWhizzBang()
    {
        Assert.Equal("FizzWhizzBang", new FizzBuzz().Convert(231));
        Assert.Equal("FizzWhizzBang", new FizzBuzz().Convert(462));
    }

    [Fact]
    public void MultipleOfFiveAndSevenAndElevenAreBuzzWhizzBang()
    {
        Assert.Equal("BuzzWhizzBang", new FizzBuzz().Convert(385));
        Assert.Equal("BuzzWhizzBang", new FizzBuzz().Convert(770));
    }

    [Fact]
    public void MultipleOfThreeAndFiveAndSevenAndElevenAreFizzBuzzWhizzBang()
    {
        Assert.Equal("FizzBuzzWhizzBang", new FizzBuzz().Convert(1155));
        Assert.Equal("FizzBuzzWhizzBang", new FizzBuzz().Convert(2310));
    }
}