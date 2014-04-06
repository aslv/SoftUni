using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfPalindromes
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter r and c :");
            string[] values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int r = int.Parse(values[0]), c = int.Parse(values[1]);
            StringBuilder word;
            for (int i = 0; i < r; i++)
            {
                word = new StringBuilder(new string((char)('a' + i), 3));
                Console.Write("{0} ", word);
                for (int j = 1; j < c; j++)
                {
                    word[1] = (char)(word[1] + 1);
                    Console.Write("{0} ", word);
                }
                Console.WriteLine();
            }
        }
    }
}
