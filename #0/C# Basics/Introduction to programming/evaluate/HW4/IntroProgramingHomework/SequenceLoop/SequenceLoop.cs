//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).
using System;

class SequenceLoop
    {
        static void Main()
        {
            int n = 1000;
            for (int i = 0; i <= n; i++)
			{
                Console.WriteLine("{0}", i % 2 == 0 ? i : -i);
			}
        }
    }

