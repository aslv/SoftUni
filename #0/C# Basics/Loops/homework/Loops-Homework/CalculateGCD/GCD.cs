using System;

namespace CalculateGCD
{
    class GCD
    {
        static void Swap(ref int lhs, ref int rhs)
        {
            lhs ^= rhs;
            rhs = lhs ^ rhs;
            lhs ^= rhs;
        }
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int temp;
            do
            {
                if (Math.Abs(a) < Math.Abs(b))
                {
                    Swap(ref a, ref b);
                }
                temp = a;
                a = b;
                b = temp % b;
                //Console.WriteLine("a = {0}  b = {1}", a, b);

            } while (b != 0);
            Console.WriteLine(a);
        }
    }
}
