using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_10___Fibonacci_Numbers
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            Console.Write("Input n: ");
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
        }
    }
}
