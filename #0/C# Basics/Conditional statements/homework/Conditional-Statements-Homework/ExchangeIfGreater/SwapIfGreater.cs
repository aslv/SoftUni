using System;

namespace ExchangeIfGreater
{
    class SwapIfGreater
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                a += b;
                b = a - b;
                a -= b;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
