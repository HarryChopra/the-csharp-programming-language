using System;


class Program
{
    static void Main()
    {
        // If Else loops
        //LoopOne();

        // Switch loops
        LoopTwo();
    }

    static void LoopOne()
    {
        Console.WriteLine("Please enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 10)
        {
            Console.WriteLine("Number {0} is outside range", num);
        }
        else if (num > 0)
        {
            Console.WriteLine("Number {0} is within range", num);
        }
    }
    static void LoopTwo()
    {
        Console.WriteLine("Please enter your number: ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 10:
                Console.WriteLine("Your number is {0}", num);
                break;
            case 20:
                Console.WriteLine("Your number is {0}", num);
                break;
            case 30:
                Console.WriteLine("Your number is {0}", num);
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 or 30");
                break;
        }
    }
}

