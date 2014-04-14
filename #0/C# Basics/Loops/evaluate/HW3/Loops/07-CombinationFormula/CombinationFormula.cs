using System;
using System.Numerics;

    class CombinationFormula
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (n > 1 && k > 1 && n < 100 && k < 100)
            {
                BigInteger factN = 1;
                BigInteger factK = 1;
                BigInteger factNAndK = 1;
                BigInteger result = 0;

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