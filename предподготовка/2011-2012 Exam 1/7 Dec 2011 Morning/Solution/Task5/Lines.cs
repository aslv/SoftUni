using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Lines
    {
        const byte N = 8, LEN = 8;
        static string[] a;
        static int CountSubstrings(string text, string pattern)
        {
            int count = 0, i = 0;
            if (text.Equals(pattern))
            {
                return 1;
            }
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                count++;
                i += pattern.Length;
            }
            return count;
        }
        static int CountLongestLineInColumns(int index, string pattern)
        {
            string text = "";
            foreach (string row in a)
            {
                text += row[index];
            }
            return CountSubstrings(text, pattern);
        }

        static void Main()
        {
            a = new string[N];
            for (byte i = 0; i < N; i++)
            {
                a[i] = Convert.ToString(byte.Parse(Console.ReadLine()), 2);
                if (a[i].Length < LEN)
                {
                    //Console.WriteLine(a[i].Length);
                    a[i] = a[i].Insert(0, new string('0', LEN - a[i].Length));
                }
            }

            int temp, currentMaxLen, currentMaxCount, rowMaxCount = 0, rowMaxLen = 0;
            for (int row = 0; row < N; row++)
            {
                currentMaxCount = 0;
                currentMaxLen = -1;
                for (int potentionalMaxLen = LEN; potentionalMaxLen > 0; potentionalMaxLen--)
                {
                    temp = CountSubstrings(a[row], new string('1', potentionalMaxLen));
                    if (temp != 0)
                    {
                        currentMaxLen = potentionalMaxLen;
                        currentMaxCount = temp;
                        break;
                    }
                }
                if (currentMaxLen > rowMaxLen)
                {
                    rowMaxLen = currentMaxLen;
                    rowMaxCount = currentMaxCount;
                }
                else if (currentMaxLen == rowMaxLen)
                {
                    rowMaxCount += currentMaxCount;
                }
            }

            int colMaxCount = 0, colMaxLen = 0, maxCount, maxLen;
            for (int col = 0; col < LEN; col++)
            {
                currentMaxCount = 0;
                currentMaxLen = -1;
                for (int potentionalMaxLen = N; potentionalMaxLen > 0; potentionalMaxLen--)
                {
                    temp = CountLongestLineInColumns(col, new string('1', potentionalMaxLen));
                    if (temp != 0)
                    {
                        currentMaxLen = potentionalMaxLen;
                        currentMaxCount = temp;
                        break;
                    }
                }
                if (currentMaxLen > colMaxLen)
                {
                    colMaxLen = currentMaxLen;
                    colMaxCount = currentMaxCount;
                }
                else if (currentMaxLen == colMaxLen)
                {
                    colMaxCount += currentMaxCount;
                }
            }

            //Console.WriteLine("{0} {1}", rowMaxCount, colMaxCount);
            if (rowMaxLen == colMaxLen)
            {
                maxLen = rowMaxLen;
                maxCount = rowMaxCount + colMaxCount;
            }
            else
            {
                if (rowMaxLen > colMaxLen)
                {
                    maxLen = rowMaxLen;
                    maxCount = rowMaxCount;
                }
                else
                {
                    maxLen = colMaxLen;
                    maxCount = colMaxCount;
                }
            }
            Console.WriteLine("{0}\n{1}", maxLen, maxCount);

            //    int longestH = 0, countH = 0, longestV = 0, countV = 0, count, totalLongestH = 0, totalCountH = 0, totalLongestV = 0, totalCountV = 0;
            //    for (int i = 0; i < N; i++)
            //    {
            //        for (int j = LEN, temp; j >= 0; j--)
            //        {
            //            count = 0;
            //            temp = 0;
            //            while (temp < a[i].Length && ((temp = a[i].IndexOf(new string('1', j), temp)) != -1))
            //            {
            //                temp += j;
            //                count++;
            //            }
            //            if (count > longestH)
            //            {
            //                longestH = count;
            //                countH = j;
            //                break;
            //            }
            //        }
            //        if (longestH > totalLongestH)
            //        {
            //            totalLongestH = longestH;
            //            totalCountH = countH;
            //        }
            //    }

            //    string[] b = new string[LEN];
            //    for (int i = 0; i < LEN; i++)
            //    {
            //        for (int j = 0; j < N; j++)
            //        {
            //            b[i] += a[j];
            //        }
            //    }
            //    for (int i = 0; i < LEN; i++)
            //    {
            //        for (int j = N, temp; j >= 0; j--)
            //        {
            //            count = 0;
            //            temp = 0;
            //            while (temp < b[i].Length && ((temp = b[i].IndexOf(new string('1', j), temp)) != -1))
            //            {
            //                i += j;
            //                count++;
            //            }
            //            if (count > longestV)
            //            {
            //                longestV = count;
            //                countV = j;
            //                break;
            //            }
            //        }
            //        if (longestV > totalLongestV)
            //        {
            //            totalLongestV = longestV;
            //            totalCountV = countV;
            //        }
            //    }

            //    if (longestH != longestV)
            //    {
            //        Console.WriteLine("{0}\n{1}", longestH > longestV ? longestH : longestV, longestH > longestV ? countH : countV);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}\n{1}", longestH, countH + countV);
            //    }
        }
    }
}
