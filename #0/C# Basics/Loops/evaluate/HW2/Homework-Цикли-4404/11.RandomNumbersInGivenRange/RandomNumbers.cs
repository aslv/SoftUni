using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max = ");
            int max = int.Parse(Console.ReadLine());

            if (min <= max)
            {
                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    Console.Write(random.Next(min, max + 1) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
