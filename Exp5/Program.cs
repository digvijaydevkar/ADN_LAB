// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Program started...");

        // Calling async method
        Task task = DoWorkAsync();

        Console.WriteLine("Main method continues working...");

        // Wait for async task to complete
        await task;

        Console.WriteLine("Program finished.");
        Console.ReadKey();
    }

    // Async method
    static async Task DoWorkAsync()
    {
        Console.WriteLine("Task started...");

        // Simulating long-running task (3 seconds delay)
        await Task.Delay(3000);

        Console.WriteLine("Task completed after delay.");
    }
}
