using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalHexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string hex = "";
            long dec = long.Parse(Console.ReadLine());
            long ostatuk = 0;
            while (dec != 0)
            {
                ostatuk = dec % 16;

                dec = dec / 16;
                switch (ostatuk)
                {
                    case 1: hex = "1" + hex; break;
                    case 2: hex = "2" + hex; break;
                    case 3: hex = "3" + hex; break;
                    case 4: hex = "4" + hex; break;
                    case 5: hex = "5" + hex; break;
                    case 6: hex = "6" + hex; break;
                    case 7: hex = "7" + hex; break;
                    case 8: hex = "8" + hex; break;
                    case 9: hex = "9" + hex; break;
                    case 10: hex = "a" + hex; break;
                    case 11: hex = "b" + hex; break;
                    case 12: hex = "c" + hex; break;
                    case 13: hex = "d" + hex; break;
                    case 14: hex = "e" + hex; break;
                    case 15: hex = "f" + hex; break;
                    default: Console.Write("greshka"); break;
                }
            }
            Console.WriteLine(hex);
        }
    }
}
