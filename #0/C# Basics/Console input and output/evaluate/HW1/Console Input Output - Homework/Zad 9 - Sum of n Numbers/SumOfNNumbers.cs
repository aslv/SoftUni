using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_9___Sum_of_n_Numbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            byte count = byte.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Input a number: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
