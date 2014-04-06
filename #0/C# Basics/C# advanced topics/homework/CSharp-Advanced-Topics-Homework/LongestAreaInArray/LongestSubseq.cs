using System;

namespace LongestAreaInArray
{
    class LongestSubseq
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }
            string item = "";
            int currentLength = 1, totalLenght = 0;
            for (int i = 1; i < n; i++)
            {
                if (s[i].Equals(s[i - 1]))
                {
                    currentLength++;
                }
                else
                {
                    if (totalLenght < currentLength)
                    {
                        totalLenght = currentLength;
                        item = s[i - 1];
                    }
                    currentLength = 1;
                }
            }
            if (totalLenght < currentLength)
            {
                totalLenght = currentLength;
                item = s[n - 1];
            }
            Console.WriteLine("\n{0}", totalLenght);
            for (int i = 0; i < totalLenght; i++)
            {
                Console.WriteLine(item);
            }
        }
    }
}