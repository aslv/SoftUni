using System;
using System.Numerics;
using CalculateExpression2;

namespace CalculateCatalanNumber
{
    class CatalanNum
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine("i = {0}  -->  ({3} {0}) = {1}  -->  CatN = {2}", i, CalculateFactorial.FactorialDivision(2 * i, i), CalculateFactorial.FactorialDivision(2 * i, i) / CalculateFactorial.Factorial(i + 1), 2 * i);
            //}
            Console.WriteLine("{0}-th Catalan number is {1}", n, CalculateFactorial.FactorialDivision(2 * n, n) / CalculateFactorial.Factorial(n + 1));
        }
    }
}
