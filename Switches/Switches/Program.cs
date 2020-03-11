using System;


class Program
{
    static void Main()
    {
        StarBucks();
    }

    static void StarBucks()
    {
        Console.WriteLine("Welcome to Starbucks!");
        Console.WriteLine("Please select your coffee serving size.");
        Console.WriteLine("**Note: We are only serving caffe lattes today!");
        Console.WriteLine(" 1 - Tall, 2 - Grande, 3 - Venti\n");

        int UserInput = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPlease enter the quantity:");
        int UserQty = int.Parse(Console.ReadLine());
        int total = 0;

        switch (UserInput)
        {
            case 1:
                ProcessOrder("Tall");
                break;
            case 2:
                ProcessOrder("Grande");
                break;
            case 3:
                ProcessOrder("Venti");
                break;
        }

        void ProcessOrder(string sizeDes)
        {
            Console.WriteLine("\n{0} cups of caffe latte ({1}), coming up!", UserQty, sizeDes);
            total = UserInput * UserQty;
            Console.WriteLine("Your total is £{0}. Please pay at the counter. Thanks!", total);
        }

    }
}

