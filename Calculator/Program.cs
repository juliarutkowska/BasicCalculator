namespace Calculator
{
    public abstract class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Calculator!");
            Console.WriteLine();

            var operators = new List<string> { "+", "-", "/", "*" };
            while (true)
            {
                double num1, num2;
                bool validNum1, validNum2;

                do
                {
                    Console.Write("Enter the first number: ");
                    validNum1 = double.TryParse(Console.ReadLine(), out num1);
                    if (!validNum1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                } while (!validNum1);

                string operation;
                do
                {
                    Console.Write(@"Enter the operator. You can choose from: ""+"" ""-"" ""/"" ""*"": ");
                    operation = Console.ReadLine();
                    if (!operators.Contains(operation))
                    {
                        Console.WriteLine("Invalid operator. Enter a valid operator.");
                    }
                } while (!operators.Contains(operation));

                do
                {
                    Console.Write("Enter the second number: ");
                    validNum2 = double.TryParse(Console.ReadLine(), out num2);
                    if (!validNum2)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                } while (!validNum2);

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator. Please enter a valid operator.");
                        continue;
                }

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
}