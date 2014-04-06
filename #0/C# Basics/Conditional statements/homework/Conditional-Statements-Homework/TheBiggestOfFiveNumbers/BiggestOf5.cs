using System;

namespace TheBiggestOfFiveNumbers
{
    class BiggestOf5
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());

            double biggest = a;
            if (b > biggest)
            {
                biggest = b;
            }
            if (c > biggest)
            {
                biggest = c;
            }
            if (d > biggest)
            {
                biggest = d;
            }
            if (e > biggest)
            {
                biggest = e;
            }
            Console.WriteLine(biggest);
        }
    }
}
