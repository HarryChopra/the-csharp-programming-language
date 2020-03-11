using System;

class Program {
    static void Main () {

        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;
        // EvenNumbers[3] = 6; // Cant hold more than the length of the array
        Console.WriteLine(EvenNumbers[3]);
    }
}