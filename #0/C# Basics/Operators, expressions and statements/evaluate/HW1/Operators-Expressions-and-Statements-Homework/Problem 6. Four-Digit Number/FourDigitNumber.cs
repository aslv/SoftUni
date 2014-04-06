using System;

namespace Problem_6.Four_Digit_Number
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Write your number: ");
            int number = int.Parse(Console.ReadLine());
            string stringNumber = number.ToString();

            int firstDigit = number % 10;         // 1
            int restNumberTwo = number / 10;      // 201
            int secondDigit = restNumberTwo % 10;  // 1
            int restNumberThree = restNumberTwo / 10; // 20
            int thirdDigit = restNumberThree % 10;   // 0
            int restNumberFour = restNumberThree / 10;  // 2
            int fourthDigit = restNumberFour % 10; // 2

            Console.WriteLine("The sum of the digits is : " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("The number in reversed order is : " + firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("The number with last digit in the first position is : " + firstDigit + fourthDigit + thirdDigit + secondDigit);
            Console.WriteLine("The number with exchanged second and third digit is : " + fourthDigit + secondDigit + thirdDigit + firstDigit);
        }
    }
}
