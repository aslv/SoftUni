using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class DancingBits
    {
        /// <summary>
        /// Contains static text methods.
        /// Put this in a separate class in your project.
        /// </summary>
        public static class TextTool
        {
            /// <summary>
            /// Count occurrences of dancing bits.
            /// </summary>
            public static int CountGroupOfDancingBits(string text, string pattern)
            {
                int count = 0;
                int i = 0;
                if (text.Equals(pattern))
                {
                    return 1;
                }
                while ((i = text.IndexOf(pattern, i)) != -1)
                {
                    if (i + pattern.Length == text.Length)
                    {
                        if (text[i - 1] != pattern[0])
                        {
                            count++;
                            //Console.WriteLine(i);
                        }
                    }
                    else if (i==0)
                    {
                        if (text[i + pattern.Length] != pattern[0])
                        {
                            count++;
                            //Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        if (text[i - 1] != pattern[0] && text[i + pattern.Length] != pattern[0])
                        {
                            count++;
                            //Console.WriteLine(i);
                        }
                    }
                    i += pattern.Length;
                }
                return count;
            }
        }

        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string bits = "";
            for (int i = 0, current; i < n; i++)
            {
                current = int.Parse(Console.ReadLine());
                bits += Convert.ToString(current, 2);
            }
            //Console.WriteLine(bits);

            int count;
            string matrix0 = new string('0', k);
            string matrix1 = new string('1', k);
            count = TextTool.CountGroupOfDancingBits(bits, matrix0) + TextTool.CountGroupOfDancingBits(bits, matrix1);

            Console.WriteLine(count);
        }
    }
}
