using Shouldly;
using AutoFixture.Xunit2;
namespace Calculator.Tests;

public class SimpleCalculatorTests
{
    CalculatorOperations calculator = new CalculatorOperations();

    [Theory]
    [AutoData]
    public void Sum_of_two_numbers(int a, int b)
    {
        var result = calculator.PerformCalculation("+", a, b);
        result.ShouldBe(a + b);
    }

    [Theory]
    [AutoData]
    public void Difference_of_two_numbers(int a, int b)
    {
        var result = calculator.PerformCalculation("-", a, b);
        result.ShouldBe(a - b);
    }
    
    [Theory]
    [AutoData]
    public void Product_of_two_numbers(int a, int b)
    {
        var result = calculator.PerformCalculation("*", a, b);
        result.ShouldBe(a * b);
    }

    [Theory]
    [AutoData]
    public void Quotient_of_two_numbers(int a, int b)
    {
        if (b == 0) return;
        var result = calculator.PerformCalculation("/", a, b);
        result.ShouldBe(a / b);
    }
}