using System;

namespace FourDigitNumbers
{
    class DigitManipulation
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int thousands = n / 1000;
            int hundreds = n / 100 % 10;
            int tens = n / 10 % 10;
            int ones = n % 10;

            Console.WriteLine("____\nabcd = {0}", n);
            Console.WriteLine("a+b+c+d = {0}", thousands + hundreds + tens + ones);
            Console.WriteLine("____\ndcba = {0}", ones * 1000 + tens * 100 + hundreds * 10 + thousands);
            Console.WriteLine("____\ndabc = {0}", ones * 1000 + thousands * 100 + hundreds * 10 + tens);
            Console.WriteLine("____\nacbd = {0}", thousands * 1000 + tens * 100 + hundreds * 10 + ones);
        }
    }
}
