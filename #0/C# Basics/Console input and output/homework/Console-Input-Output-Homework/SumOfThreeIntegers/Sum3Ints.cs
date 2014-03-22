using System;

namespace SumOfThreeIntegers
{
    class Sum3Ints
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }
}
