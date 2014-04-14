using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicStrings
{
    class Task4
    {
        //enum Weights { K = 1, S = 3, N = 4, P = 5 };
        static int[] values = { 1, 4, 5, 3 };
        static char[] keys = { 'k', 'n', 'p', 's' };
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 16)
            {
                Console.WriteLine("No");
            }
            else
            {
                int leftSum, rightSum;
                bool f = false;
                for (int _0 = 0; _0 < 4; _0++)
                {
                    for (int _1 = 0; _1 < 4; _1++)
                    {
                        for (int _2 = 0; _2 < 4; _2++)
                        {
                            for (int _3 = 0; _3 < 4; _3++)
                            {
                                for (int _4 = 0; _4 < 4; _4++)
                                {
                                    for (int _5 = 0; _5 < 4; _5++)
                                    {
                                        for (int _6 = 0; _6 < 4; _6++)
                                        {
                                            for (int _7 = 0; _7 < 4; _7++)
                                            {
                                                leftSum = values[_0] + values[_1] + values[_2] + values[_3];
                                                rightSum = values[_4] + values[_5] + values[_6] + values[_7];
                                                if (Math.Abs(leftSum - rightSum) == n)
                                                {
                                                    f = true;
                                                    Console.Write(keys[_0]);
                                                    Console.Write(keys[_1]);
                                                    Console.Write(keys[_2]);
                                                    Console.Write(keys[_3]);
                                                    Console.Write(keys[_4]);
                                                    Console.Write(keys[_5]);
                                                    Console.Write(keys[_6]);
                                                    Console.Write(keys[_7]);
                                                    Console.WriteLine();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (f == false)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
