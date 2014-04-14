using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfElements
{
    class Task2
    {
        static void Main()
        {
            string[] values = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = values.Length;
            long[] a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(values[i]);
            }

            long sum = a.Sum(), sum_2 = sum >> 1;
            long diff = long.MaxValue, currentDiff;
            if (sum % 2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    currentDiff = Math.Abs(a[i] - sum_2);
                    if (currentDiff < diff)
                    {
                        diff = currentDiff;
                    }
                    if (currentDiff == 0)
                    {
                        break;
                    }
                }
                if (diff == 0)
                {
                    Console.WriteLine("Yes, sum={0}", sum_2);
                }
                else
                {
                    Console.WriteLine("No, diff={0}", diff << 1);
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    currentDiff = Math.Abs(sum - 2 * a[i]);
                    if (currentDiff < diff)
                    {
                        diff = currentDiff;
                    }
                }
                Console.WriteLine("No, diff={0}", diff);
            }
        }
    }
}
