using System;

namespace MathOperationApp
{
    // Define a class to perform mathematical operations
    class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., doubling it)
            int result = num1 * 2;

            // Display the result of the operation
            Console.WriteLine($"The result of doubling the first number ({num1}) is: {result}");

            // Display the second integer as is
            Console.WriteLine($"The second number is: {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the Math Operation App!");

            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the PerformOperation method by passing in two numbers (positional arguments)
            mathOperations.PerformOperation(5, 10);

            // Call the PerformOperation method by specifying the parameters by name
            mathOperations.PerformOperation(num1: 7, num2: 14);

            // Wait for the user to press a key before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
