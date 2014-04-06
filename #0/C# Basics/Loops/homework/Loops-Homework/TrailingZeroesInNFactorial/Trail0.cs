using System;

namespace TrailingZeroesInNFactorial
{
    class Trail0
    {
        static void Main()
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            uint power5 = 5U, zeroes = 0U;
            while (power5 <= n)
            {
                zeroes += (uint)(n / power5);
                power5 *= 5;
            }
            Console.WriteLine(zeroes);
        }
    }
}
