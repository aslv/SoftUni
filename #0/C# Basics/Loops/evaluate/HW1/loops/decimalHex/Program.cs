using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimalHex
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
                    case 1: hex = hex + "1"; break;
                    case 2: hex = hex + "2"; break;
                    case 3: hex = hex + "3"; break;
                    case 4: hex = hex + "4"; break;
                    case 5: hex = hex + "5"; break;
                    case 6: hex = hex + "6"; break;
                    case 7: hex = hex + "7"; break;
                    case 8: hex = hex + "8"; break;
                    case 9: hex = hex + "9"; break;
                    case 10: hex = hex + "a"; break;
                    case 11: hex = hex + "b"; break;
                    case 12: hex = hex + "c"; break;
                    case 13: hex = hex + "d"; break;
                    case 14: hex = hex + "e"; break;
                    case 15: hex = hex + "f"; break;
                    default: Console.Write("greshka"); break;
                    //case 1 :Console.Write("1"); break;
                    //case 2: Console.Write("2"); break;
                    //case 3: Console.Write("3"); break;
                    //case 4: Console.Write("4"); break;
                    //case 5: Console.Write("5"); break;
                    //case 6: Console.Write("6"); break;
                    //case 7: Console.Write("7"); break;
                    //case 8: Console.Write("8"); break;
                    //case 9: Console.Write("9"); break;
                    //case 10: Console.Write("a"); break;
                    //case 11: Console.Write("b"); break;
                    //case 12: Console.Write("c"); break;
                    //case 13: Console.Write("d"); break;
                    //case 14: Console.Write("e"); break;
                    //case 15: Console.Write("f"); break;
                    //default: Console.Write("greshka"); break;

                }
            }
            Console.WriteLine(hex);
        }
    }
}
