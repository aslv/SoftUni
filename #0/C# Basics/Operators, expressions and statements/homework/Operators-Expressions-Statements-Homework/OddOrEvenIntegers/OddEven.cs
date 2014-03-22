using System;

namespace OddOrEvenIntegers
{
    class OddEven
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Is {0} odd? \n{1}", n, (n % 2) != 0);
        }
    }
}
