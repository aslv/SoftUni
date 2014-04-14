using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8___Numbers_from_1_to_n
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            byte n;
            Console.Write("Input n: ");
            n = byte.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }
    }
}
