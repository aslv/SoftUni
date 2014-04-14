using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string binary = Console.ReadLine();
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }
                sum += Math.Pow(2, i);
            }

            Console.WriteLine(sum);     
        }
    }
}
