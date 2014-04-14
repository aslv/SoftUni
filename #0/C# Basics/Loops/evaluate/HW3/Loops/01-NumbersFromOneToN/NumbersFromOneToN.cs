using System;

    class NumbersFromOneToN
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }

