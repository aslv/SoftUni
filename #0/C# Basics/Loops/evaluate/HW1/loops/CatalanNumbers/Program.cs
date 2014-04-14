using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            if (n > 1 && n < 100)
            {
                BigInteger factoriel = 1;
                BigInteger factorielLOC = 1;
                BigInteger factorielN = 1;
                BigInteger result = 0;
                for (int i = 1; i <= 2 * n; i++)
                {
                    factoriel *= i;
                }

                for (int j = 1; j <= n + 1; j++)
                {
                    factorielLOC *= j;
                }

                for (int k = 1; k <= n; k++)
                {
                    factorielN *= k;
                }

                result = factoriel / (factorielLOC * factorielN);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }
    }
}
        
