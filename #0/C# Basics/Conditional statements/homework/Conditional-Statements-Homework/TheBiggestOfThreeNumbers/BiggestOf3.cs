using System;

namespace TheBiggestOfThreeNumbers
{
    class BiggestOf3
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double biggest = a;
            if (b > biggest)
            {
                biggest = b;
            }
            if (c > biggest)
            {
                biggest = c;
            }
            Console.WriteLine(biggest);
        }
    }
}
