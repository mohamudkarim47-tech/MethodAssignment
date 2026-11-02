using System;

namespace MethodAssignment
{
    // Step 1: Create a class
    public class MathProcessor
    {
        // Create a void method that takes two integers as parameters.
        // It performs a math operation on the first integer and displays the second integer.
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = firstNumber * 2;

            // Display the second integer to the console screen
            Console.WriteLine($"The second integer is: {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: In the Main() method, instantiate the class
            MathProcessor processor = new MathProcessor();

            // Step 3: Call the method in the class, passing in two numbers (positional arguments)
            Console.WriteLine("Calling method with positional arguments:");
            processor.ProcessNumbers(5, 20);

            // Step 4: Call the method in the class, specifying the parameters by name (named arguments)
            Console.WriteLine("\nCalling method with named arguments:");
            processor.ProcessNumbers(firstNumber: 10, secondNumber: 42);

            // Keep console open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
