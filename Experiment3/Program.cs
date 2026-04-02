// See https://aka.ms/new-console-template for more information
using System;

// Class 1: Holds student data
class Student
{
    public string Name { get; set; } = "";
    public int Marks { get; set; }
}

// Class 2: Handles result calculation
class ResultCalculator
{
    public string CalculateResult(int marks)
    {
        if (marks >= 40)
            return "Pass";
        else
            return "Fail";
    }
}

// Class 3: Handles display
class Display
{
    public void Show(Student student, string result)
    {
        Console.WriteLine("\n--- Student Result ---");
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Marks: " + student.Marks);
        Console.WriteLine("Result: " + result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        // Input
        Console.Write("Enter student name: ");
        s.Name = Console.ReadLine() ?? "";

        Console.Write("Enter marks: ");
        s.Marks = Convert.ToInt32(Console.ReadLine());

        // Processing
        ResultCalculator rc = new ResultCalculator();
        string result = rc.CalculateResult(s.Marks);

        // Output
        Display d = new Display();
        d.Show(s, result);

        Console.ReadKey();
    }
}
