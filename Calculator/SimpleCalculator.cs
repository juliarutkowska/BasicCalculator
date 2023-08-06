namespace Calculator;

public class SimpleCalculator
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Basic Calculator!");
        Console.WriteLine();

        var calculator = new Calculator();

        while (true)
        {
            double num1, num2;
            bool isValid1, isValid2;

            do
            {
                Console.Write("Enter the first number: ");
                isValid1 = double.TryParse(Console.ReadLine(), out num1);
                if (!isValid1)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValid1);

            var operators = new List<string> { "+", "-", "/", "*" };
            var operatorsString = string.Join(" ", operators);

            string operation;
            do
            {
                Console.Write($"Enter the operator. You can choose from: {operatorsString}: ");
                operation = Console.ReadLine();
                if (!operators.Contains(operation))
                {
                    Console.WriteLine("Invalid operator. Enter a valid operator.");
                }
            } while (!operators.Contains(operation));
                
            do
            {
                Console.Write("Enter the second number: ");
                isValid2 = double.TryParse(Console.ReadLine(), out num2);
                if (!isValid2)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValid2);

            var result = calculator.PerformCalculation(operation, num1, num2);

            Console.WriteLine($"Your result: {result}");
            Console.WriteLine();

            Console.Write("Do you want to perform another calculation? (Y/N): ");
            var userInput = Console.ReadLine()?.Trim().ToUpper();
            if (userInput != "Y")
                break;

            Console.WriteLine();
        }
    }
}