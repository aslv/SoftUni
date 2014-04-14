using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _15.HexadecimalToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you hexadecimal value: ");
            string hexa = Console.ReadLine();

            long dec = long.Parse(hexa, NumberStyles.HexNumber);

            Console.WriteLine();
        }
    }
}
