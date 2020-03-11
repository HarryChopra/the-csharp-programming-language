// This is namespace declaration. A namespace is used to organise code.
// This line tells to the rest of program that we are going to use code within the System namespace.
// (e.g. System.Console - Fully Qualified namespace) Console class is present within System namespace. 
using System;


class Program

{
    // ENTRY POINT - Main tells the program where the execution should begin and end. 
    static void Main()
    {
        Console.WriteLine("Welcome to C# Training!");
        MainTwo();
    }

    static void MainTwo()
    {
        Console.WriteLine("Wecome again!");
    }
}