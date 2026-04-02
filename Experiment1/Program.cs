// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables
        double num1, num2;

        // Take input from user
        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = 0;

        if (num2 != 0)
        {
            division = num1 / num2;
        }

        // Display results
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine("Addition: " + addition);
        Console.WriteLine("Subtraction: " + subtraction);
        Console.WriteLine("Multiplication: " + multiplication);

        if (num2 != 0)
        {
            Console.WriteLine("Division: " + division);
        }
        else
        {
            Console.WriteLine("Division: Cannot divide by zero");
        }

        // Pause the console
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}