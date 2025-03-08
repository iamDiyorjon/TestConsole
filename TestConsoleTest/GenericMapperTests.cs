using ConsoleApp;
using Xunit;

namespace TestConsole;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        var calculator = new Calculator();
        int result = calculator.Add(3, 5);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Add_ZeroAndNumber_ReturnsSameNumber()
    {
        var calculator = new Calculator();
        int result = calculator.Add(0, 7);
        Assert.Equal(7, result);
    }

    [Fact]
    public void Add_NegativeAndPositive_ReturnsCorrectSum()
    {
        var calculator = new Calculator();
        int result = calculator.Add(-3, 3);
        Assert.Equal(0, result);
    }
}
