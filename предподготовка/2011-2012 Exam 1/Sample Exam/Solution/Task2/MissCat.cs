using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class MissCat
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            byte[] a = new byte[n];
            int[] votes = new int[11];
            for (int i = 0; i < n; i++)
            {
                a[i] = byte.Parse(Console.ReadLine());
                votes[a[i]]++;
            }
            int maxCount = -1, maxNumber = -1;
            for (int i = 1; i <= 10; i++)
            {
                if (votes[i]>maxCount)
                {
                    maxCount = votes[i];
                    maxNumber = i;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
