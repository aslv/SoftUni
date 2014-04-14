using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n > 1 && n < 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j <= n + i; j++)
                    {
                        Console.Write(j + " ");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }