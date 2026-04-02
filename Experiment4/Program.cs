// See https://aka.ms/new-console-template for more information
using System;

// Declare delegate
delegate int Operation(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        // 1. Using normal method with delegate
        Operation op1 = Add;
        Console.WriteLine("Addition using method: " + op1(10, 5));

        // 2. Using anonymous method
        Operation op2 = delegate (int x, int y)
        {
            return x * y;
        };
        Console.WriteLine("Multiplication using anonymous method: " + op2(10, 5));

        // 3. Using lambda expression
        Operation op3 = (x, y) => x - y;
        Console.WriteLine("Subtraction using lambda: " + op3(10, 5));

        Console.ReadKey();
    }

    // Normal method
    static int Add(int a, int b)
    {
        return a + b;
    }
}