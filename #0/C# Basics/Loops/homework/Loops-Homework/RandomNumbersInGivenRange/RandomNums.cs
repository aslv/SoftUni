using System;

namespace RandomNumbersInGivenRange
{
    class RandomNums
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max = ");
            int max = int.Parse(Console.ReadLine());

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", rand.Next(min, max + 1));
            }
            Console.WriteLine();
        }
    }
}
