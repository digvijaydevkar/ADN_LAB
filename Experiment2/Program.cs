// See https://aka.ms/new-console-template for more information
using System;

class Student
{
    // Private data members (Encapsulation)
    private string name = "";
    private int age;

    // Public methods to set values
    public void SetDetails(string n, int a)
    {
        name = n;
        age = a;
    }

    // Public method to display values
    public void DisplayDetails()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object of Student class
        Student s1 = new Student();

        // Taking input from user
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter student age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Using methods (Encapsulation)
        s1.SetDetails(name, age);

        Console.WriteLine("\n--- Student Details ---");
        s1.DisplayDetails();

        Console.ReadKey();
    }
}
