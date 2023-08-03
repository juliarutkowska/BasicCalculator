namespace Calculator;

public class Calculator
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
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return double.NaN;
                }
                return num1 / num2;
            
            default:
                throw new ArgumentException("Invalid operator.");
        }
    }
}