using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your first name:");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name:");
        string LastName = Console.ReadLine();

        // String Concatenation
        Console.WriteLine("Welcome to the training, " + FirstName + " " + LastName);

        // Placeholder Syntax (Recommended)
        Console.WriteLine("Welcome to the training, {0} {1}", FirstName, LastName);
    }
}