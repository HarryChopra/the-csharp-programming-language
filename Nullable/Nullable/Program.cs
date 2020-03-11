using System;


// Value Types - int, float, double, structs, enums etc
// By default value types are non-nullable.
// To make them nullable add a ?
// Reference Type - Interface, class, delegates, arrays etc. Default value is Null

class Program
{
    static void Main()
    {
        string Name = null; // Okay
        // int i = null; Int is a Non-nullable value type. Cant be initialised to Null

        bool? AreYouMajor = null; // Can save three values. Use case: Optional fields or Null in DB columns
        string Output = AreYouMajor == true ? "User is a Major" : AreYouMajor == false ? "User is not a Major" : "No answer provided";

        Console.WriteLine(Output);

        // null Coalescing

        int? TicketsOnSale = 100;
        int AvailableTickets = TicketsOnSale ?? 0; // If null, use 0

        Console.WriteLine(AvailableTickets);
    }
}

