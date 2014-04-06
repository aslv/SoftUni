using System;

class OddOrEven
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        bool isOdd = !(numberToCheck % 2 == 0);
        Console.WriteLine(isOdd);
    }
}

