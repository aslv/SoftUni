using System;

class ASCIITable
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            char ascii = (char) i;
            Console.WriteLine(ascii);
        }
    }
}