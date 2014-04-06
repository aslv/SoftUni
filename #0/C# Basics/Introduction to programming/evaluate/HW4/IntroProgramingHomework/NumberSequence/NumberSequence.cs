//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;

    class NumberSequence
    {
        static void Main()
        {
            int number =10;
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("{0}", i % 2 == 0 ? i : -i);
            }
               
        }
    }
