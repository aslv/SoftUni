using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Matrix_Of_Palindromes
{
    static void Main()
    {
        Console.WriteLine("Enter number for row and col");
        Console.Write("row = ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("col = ");
        int c = int.Parse(Console.ReadLine());

        string[,] matrix = new string[r, c];

        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
            }
        }

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