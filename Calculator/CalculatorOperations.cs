namespace Calculator;

public class CalculatorOperations
{
    public double PerformCalculation(string operation, double num1, double num2)
    {
        switch (operation)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                if (num2 != 0) return num1 / num2;
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN;

            default:
                throw new ArgumentException("Invalid operator.");
        }
    }
}