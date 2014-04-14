using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalBinaryNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary="";
            ulong ostatuk;
            ulong dec = ulong.Parse(Console.ReadLine());
            while(dec !=0)
            {
                ostatuk = dec % 2;
                dec = dec / 2;
               
              
                binary = ostatuk.ToString() + binary;
                
                
            }
            Console.WriteLine(binary);
        }
    }
}
