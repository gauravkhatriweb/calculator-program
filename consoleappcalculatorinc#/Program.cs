using System;

namespace consoleappcalculatorinc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                // Variables to hold the numbers and the result
                int num1, num2;
                char operation;
                double result = 0;

                // Welcome message
                Console.WriteLine("Hello, Welcome to the calculator program!");
                Console.WriteLine("=====================================");

                // Input for the first number
                Console.WriteLine("Enter your first number:");
                num1 = Convert.ToInt32(Console.ReadLine());

                // Input for the second number
                Console.WriteLine("Enter your second number:");
                num2 = Convert.ToInt32(Console.ReadLine());

                // Input for the operation
                Console.WriteLine("Enter the operation (+, -, *, /):");
                operation = Convert.ToChar(Console.ReadLine());

                // Switch case to handle different operations
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        // Handling division by zero
                        if (num2 != 0)
                        {
                            result = (double)num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operation.");
                        break;
                }

                // Display the result
                if (operation == '+' || operation == '-' || operation == '*' || (operation == '/' && num2 != 0))
                {
                    Console.WriteLine("The result of {0} {1} {2} = {3}", num1, operation, num2, result);
                }

                // Ask the user if they want to start again or quit
                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                char response = Convert.ToChar(Console.ReadLine().ToLower());

                if (response != 'y')
                {
                    continueCalculation = false;
                }

                // Clear the console for the next calculation
                Console.Clear();
            }

            // Goodbye message
            Console.WriteLine("Thank you for using the calculator program. Goodbye!");
            Console.ReadKey();
        }
    }
}
