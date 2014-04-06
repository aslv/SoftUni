using System;

namespace SortThreeNumbersWithNestedIfs
{
    class SortThreeNums
    {
        static void Swap(ref double lhs, ref double rhs)
        {
            lhs += rhs;
            rhs = lhs - rhs;
            lhs -= rhs;
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (b > a)
            {
                Swap(ref a, ref b);
            }
            if (c > a)
            {
                Swap(ref a, ref c);
            }
            if (c > b)
            {
                Swap(ref c, ref b);
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
