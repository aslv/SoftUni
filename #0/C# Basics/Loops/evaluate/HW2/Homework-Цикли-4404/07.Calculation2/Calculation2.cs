using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculation2
{
    class Calculation2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers, using 'enter' after each:");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (n > 1 && k > 1 && n < 100 && k < 100)
            {
                int factN = 1;
                int factK = 1;
                int factNAndK = 1;
                int result = 0;

                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                }

                for (int j = 1; j <= k; j++)
                {
                    factK *= j;
                }

                for (int z = 1; z <= n - k; z++)
                {
                    factNAndK *= z;
                }

                result = factN / (factK * factNAndK);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
