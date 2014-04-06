using System;

namespace Problem_8.Prime_Number_Check
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number > 100) Console.WriteLine("Invalid number!!!");
            bool isPrime = true;
            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0) isPrime = false;
                }
            }
            Console.WriteLine(isPrime);
        }
    }
}
