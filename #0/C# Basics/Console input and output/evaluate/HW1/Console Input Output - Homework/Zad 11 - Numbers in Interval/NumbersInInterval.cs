using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_11___Numbers_in_Interval
{
    class NumbersInInterval
    {
        static void Main(string[] args)
        {
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    if(i - start < 5)
                        Console.Write(i);
                    else
                        Console.Write(", {0}", i);
                }
            }
            if(p != 0)
                Console.WriteLine();
            else
                Console.WriteLine("-");
            Console.WriteLine("p: {0}", p);
        }
    }
}
