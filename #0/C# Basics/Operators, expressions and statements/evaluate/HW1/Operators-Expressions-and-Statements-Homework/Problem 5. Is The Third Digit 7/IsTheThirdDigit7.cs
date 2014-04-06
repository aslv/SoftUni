using System;

namespace Problem_5.Is_The_Third_Digit_7
{
    class IsTheThirdDigit7
    {
        static void Main()
        {
            Console.Write("Write your number: ");
            int number = int.Parse(Console.ReadLine());
            int number1 = number / 100;
            int thirdDigit = number1 % 10;

            bool isSeven = thirdDigit == 7;
            Console.WriteLine("The third digit is 7 -> " + isSeven);
        }
    }
}
