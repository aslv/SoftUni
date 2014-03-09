using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Task2
{
    class Tribonacci
    {
        static void Main()
        {
            BigInteger Tcurrent, Tbefore, Tbeforebefore, value;
            short n;

            Tbeforebefore=BigInteger.Parse(Console.ReadLine());
            Tbefore = BigInteger.Parse(Console.ReadLine());
            Tcurrent = BigInteger.Parse(Console.ReadLine());
            n = short.Parse(Console.ReadLine());

            for (short i = 4; i <= n; i++)
            {
                value = Tbeforebefore + Tbefore + Tcurrent;
                Tbeforebefore = Tbefore;
                Tbefore = Tcurrent;
                Tcurrent = value;
            }

            Console.WriteLine(Tcurrent);
        }
    }
}
