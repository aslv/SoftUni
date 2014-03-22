using System;

namespace ComparingFloats
{
    class CompareFloats
    {
        static void Main()
        {
            double lhs, rhs, eps = 0.000001;
            Console.Write("Enter the first number: ");
            lhs = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            rhs = double.Parse(Console.ReadLine());
            Console.WriteLine("Are {0} and {1} equal?", lhs, rhs);
            bool equal = Math.Abs(lhs - rhs) < eps;
            Console.WriteLine(equal);
        }
    }
}
