using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculation
{
    class Calculation
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter two integers, using 'enter' after each:");
           int n = int.Parse(Console.ReadLine());
           int x = int.Parse (Console.ReadLine());

        double N = 1;
        double X = 1;
        double result = 1;
 
        for (int i = 1; i <= n; i++)
        {
            N *= i;
            X *= x;
            result += N / X;
        }
 
        Console.WriteLine("{0:f5}", result);
        }
    }
}
