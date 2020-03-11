using System;


class Program
{
    static void Main()
    {
        //Single line
        // Console.WriteLine("Hello World!");

        /* Multi-line
         * Console.WriteLine("Hello World!");
        Console.WriteLine("Hello World!"); */


        Console.WriteLine("Hello World!");

        // XML documentation provides meaningful definition of classes et al
        new SampleClass();

    }
}


/// <summary>
/// This is sample class and a sample description - XML documentaiton comments
/// </summary>
public class SampleClass
{

}