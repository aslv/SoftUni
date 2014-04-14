using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5___Formatting_Numbers
{
    class Foramtting
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input a floating-point b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input a floating-point c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("|{0, -10:X}|{1}|{2, 10:0.00}|{3, -10:0.000}|", a,
                Convert.ToString(a,2).PadLeft(10,'0'), b, c);
        }
    }
}
