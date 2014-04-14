using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double oll = 0;
            int t= 0;
            double sum = 0;
            string hex = Console.ReadLine();
            for (int i = 0; i < hex.Length; i++)
            {
               
                switch(hex[hex.Length-1-i])
                {
                case '1': t = 1; break;
                case '2': t = 2; break;
                case '3': t = 3; break;
                case '4': t = 4; break;
                case '5': t = 5; break;
                case '6': t = 6; break;
                case '7': t = 7; break;
                case '8': t = 8; break;
                case '9': t = 9; break;
                case 'A': t = 10; break;
                case 'B': t = 11; break;
                case 'C': t = 12; break;
                case 'D': t = 13; break;
                case 'E': t = 14; break;
                case 'F': t = 15; break;
                default: Console.Write("greshka"); break;
                }
                sum = Math.Pow(16, i);
                oll += t * sum;      

            }
            Console.Write(oll);
        }
    }
}
