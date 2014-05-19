using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        /* 7. Write a program to generate the following matrix of palindromes of 3 letters with r rows and c
         * columns:
         * 
         * Input Output
         * 3 6   aaa aba aca ada aea afa
         *       bbb bcb bdb beb bfb bgb
         *       ccc cec cdc cfc cgc chc
         *       
         * 2 3   aaa aba aca
         *       bbb bcb bdb
         *       
         * 1 1   aaa
         * 
         * 1 3   aaa aba aca
         */

        Console.Write("Enter row = ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter col = ");
        int height = int.Parse(Console.ReadLine());
        string[,] matrix = new string[width, height];

        //Make matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
            }
        }

        
        //Print matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}