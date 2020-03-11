using System;


class Program
{
    static void Main()
    {
        string Name = "\"Harry Chopra\"";
        string DirPath = "\\etc\\hosts";

        // Verbatim Literal - Escape sequences ignored. Greater Readibility.
        string NewDirPath = @"\etc\hosts";
        bool b = true;

        //How to check Min and max value within VS
        Console.WriteLine(int.MinValue);

        // Escape sequence characters
        Console.WriteLine(Name);

        Console.WriteLine(DirPath);

        Console.WriteLine(NewDirPath);
        
    }

}
