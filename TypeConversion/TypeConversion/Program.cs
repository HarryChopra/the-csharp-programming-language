using System;


class Program
{
    static void Main()
    {
        int i = 100;

        // Implicit Conversion with no loss of information. Float is much bigger type than Integer
        float f = i;

        float g = 123.45F;

        // Explicit typecasting (Typecast Operator)
        int h = (int)g; // In this case 123 can get saved into h, but there is going to be loss of information
                        // .45, i.e. the fractional part will be lost.
                        // Overflow Exception can also occur if there is a bigger data attempted to be saved into a smaller.type.
        int h = Convert.ToInt32(g); //Recommended - Verbose and will throw expection if there is overflow exception

        // String to number conversion

        string strNumber = "100";
        int s = int.Parse(strNumber); // Only for a string source.


        //Avoiding exceptions with Parse conversions
        string a = "100TG";
        int b = 0;

        int.TryParse(a, out b);
        Console.WriteLine(b); //0

        // TryParse also returns a boolean
        bool IsConversionSuccessful = int.TryParse(a, out b);
        // if successful else ..
    }
}

