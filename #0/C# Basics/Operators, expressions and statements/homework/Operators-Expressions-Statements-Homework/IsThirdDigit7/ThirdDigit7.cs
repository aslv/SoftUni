using System;

namespace IsThirdDigit7
{
    class ThirdDigit7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Is third digit of \'{1}\' 7? -> {0}", (n / 100) % 10 == 7, n);
        }
    }
}
