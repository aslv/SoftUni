using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem06_Four_Digit_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter four digit number:" );
            int n = int.Parse(Console.ReadLine());
            int a, b, c, d;
            d = n % 10;
            n = n / 10;
            c = n % 10;
            n = n / 10;
            b = n % 10;
            n = n / 10;
            a = n;
            Console.WriteLine( "The sum of the digits: {0}", a + b + c + d);
            Console.WriteLine(" The riverse order is: {0}{1}{2}{3}", d,c,b,a);
            Console.WriteLine(" The re-ordered number is: {0}{1}{2}{3}", a, c, b, d);

        }
    }
}
