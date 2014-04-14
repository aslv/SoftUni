using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4___Number_Comparer
{
    class Compare
    {
        static void Main(string[] args)
        {
            double a, b;
            do
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                //if (a > b)
                //    Console.WriteLine("Greater: {0}", a);
                //else
                //    Console.WriteLine("Greater: {0}", b);
                bool greater = a > b;
                switch(greater)
                {
                    case true: Console.WriteLine("Greater: {0}", a); break;
                    case false: Console.WriteLine("Greater: {0}", b); break;
                }
            }
            while (true);
        }
    }
}
