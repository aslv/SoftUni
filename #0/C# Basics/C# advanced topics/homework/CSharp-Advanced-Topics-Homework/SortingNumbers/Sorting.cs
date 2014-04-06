using System;

namespace SortingNumbers
{
    class Sorting
    {
        static long[] a;
        static void Sort(int lhs, int rhs)
        {
            if (lhs >= rhs)
            {
                return;
            }
            int mid = (rhs + lhs) >> 1;
            Sort(lhs, mid);
            Sort(mid + 1, rhs);
            long[] temp = new long[rhs - lhs + 1];
            int li = lhs, ri = mid + 1;
            for (int i = lhs; i <= rhs; i++)
            {
                if (li == mid + 1)
                {
                    for (int j = i; j <= rhs; j++)
                    {
                        temp[j - lhs] = a[ri];
                        ri++;
                    }
                    break;
                }
                if (ri == rhs + 1)
                {
                    for (int j = i; j <= rhs; j++)
                    {
                        temp[j - lhs] = a[li];
                        li++;
                    }
                    break;
                }

                if (a[li] < a[ri])
                {
                    temp[i - lhs] = a[li];
                    li++;
                }
                else
                {
                    temp[i - lhs] = a[ri];
                    ri++;
                }
            }
            for (int i = lhs; i <= rhs; i++)
            {
                a[i] = temp[i - lhs];
            }
        }
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Sort(0, n - 1);
            foreach (long num in a)
            {
                Console.WriteLine(num);
            }
        }
    }
}
