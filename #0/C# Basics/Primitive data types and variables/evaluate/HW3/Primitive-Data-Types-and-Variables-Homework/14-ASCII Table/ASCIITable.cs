using System;

class ASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;     //this way more characters will be displayed correctly
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine((char)i);
        }
        //some character can never be displayed - for example beep, space, new line and so on
    }
}