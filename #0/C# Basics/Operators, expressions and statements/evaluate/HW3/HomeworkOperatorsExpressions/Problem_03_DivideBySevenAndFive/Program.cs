using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        bool isDivided = ( numberToCheck % 5 == 0) && (numberToCheck % 7 ==0) && (numberToCheck != 0) ;
        Console.WriteLine(isDivided);
    }
}

