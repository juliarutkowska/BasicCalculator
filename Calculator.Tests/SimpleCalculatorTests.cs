using Shouldly;
namespace Calculator.Tests;

public class SimpleCalculatorTests
{
    CalculatorOperations calculator = new CalculatorOperations();

    [Fact]
    public void Sum_of_two_numbers()
    {
        var result = calculator.PerformCalculation("+", 5, 7);
        result.ShouldBe(12);
    }

    [Fact]
    public void Difference_of_two_numbers()
    {
        var result = calculator.PerformCalculation("-", 10, 3);
        result.ShouldBe(7);
    }

    [Fact]
    public void Product_of_two_numbers()
    {
        var result = calculator.PerformCalculation("*", 5, 5);
        result.ShouldBe(25);
    }

    [Fact]
    public void Quotient_of_two_numbers()
    {
        var result = calculator.PerformCalculation("/", 30, 3);
        result.ShouldBe(10);
    }
}