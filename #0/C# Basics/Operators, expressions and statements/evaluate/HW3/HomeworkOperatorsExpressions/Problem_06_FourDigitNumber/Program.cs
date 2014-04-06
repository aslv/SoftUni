using System;

class FourDigitNumber
{
    static void Main()
    {
        int fourDigitNumber = int.Parse(Console.ReadLine());
        int a = fourDigitNumber / 1000;
        int b = (fourDigitNumber -(a * 1000))  / 100;
        int c = (fourDigitNumber - ((a * 1000) + (b * 100)))/ 10;
        int d = (fourDigitNumber - ((a * 1000) + (b * 100) + (c * 10)));
        int sum = a + b + c + d;

        Console.WriteLine("{0}", sum); //The sum of the four digits 
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a); //Reverse order
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c); //Last digit in first place
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d); //Switched 2nd and 3rd positions

    }
}

