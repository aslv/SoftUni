using System;

class ThirdDigidIsSeven
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        int numberDevided = numberToCheck % 1000;
        int thirdNumber = numberDevided / 100;
        bool thirdDigitIsSeven = (thirdNumber == 7);
        Console.WriteLine(thirdDigitIsSeven);
    }
}

