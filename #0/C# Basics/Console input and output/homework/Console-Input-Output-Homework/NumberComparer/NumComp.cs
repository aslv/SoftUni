using System;

namespace NumberComparer
{
    class NumComp
    {
        static void Main()
        {
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            // first way
            Console.WriteLine("The greater number between {1} and {2} is {0}", a > b ? a : b, a, b);
            // second way
            Console.WriteLine("The greater number between {1} and {2} is {0}", ((a + b) + Math.Abs(a - b)) / 2, a, b);
        }
    }
}
