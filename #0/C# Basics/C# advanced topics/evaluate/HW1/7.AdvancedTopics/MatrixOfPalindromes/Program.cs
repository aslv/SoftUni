using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program to generate a matrix of palindromes of 3 letters with r rows and c columns");
            Console.WriteLine("Write r = ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Write c = ");
            int c = int.Parse(Console.ReadLine());
            string[,] matrix = new string[r, c];

            //fill the matrix with palindromes
            char ch1 = 'a';
            for (int i = 0; i < r; i++)
            {
                char ch2 = ch1;
                for (int j = 0; j < c; j++)
                    {
                        string word = ch1.ToString() + ch2.ToString() + ch1.ToString();
                        matrix[i, j] = word;
                        ch2++;
                    }
                ch1++;
            }

            //print the matrix in the console
            Console.WriteLine("The matrix with {0} rows and {1} columns with palindromes is:", r, c);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
