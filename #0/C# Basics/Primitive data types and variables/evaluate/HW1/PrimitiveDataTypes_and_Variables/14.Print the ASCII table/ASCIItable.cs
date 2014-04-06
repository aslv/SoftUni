using System;

namespace _14.Print_the_ASCII_table
{
    class ASCIItable
    {
        static void Main()
        {
            int code;
            for(int i = 0; i<256; i++)
            {
                code = i;
                Console.WriteLine("|    {0}  -->     {1}     |",code, (char) code);
            }
        }
    }
}
