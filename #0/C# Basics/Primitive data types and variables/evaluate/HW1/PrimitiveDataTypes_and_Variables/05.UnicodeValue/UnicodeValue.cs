using System;

namespace _05.UnicodeValue
{
    class UnicodeValue
    {
        static void Main()
        {
            int uniCodeH = 0x48;            //Define HEX variable with number 72
            //Solution of the problem
            int uniCodee = 0x65;            //Define HEX variable with number 101
            int uniCodel = 0x6C;            //Define HEX variable with number 108
            int uniCode_l = 0x6C;           //Define HEX variable with number 108
            int uniCodeo = 0x6F;            //Define HEX variable with number 111
            //Writing of 'Hello' with symbols from Unicode table
            Console.Write("For the unicode character with value 72  is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}", (char)uniCodeH);
            Console.ResetColor();
            //Solution of the problem
            Console.WriteLine("For the unicode character with value 101 is: {0}", (char)uniCodee);
            Console.WriteLine("For the unicode character with value 108 is: {0}", (char)uniCodel);
            Console.WriteLine("For the unicode character with value 108 is: {0}", (char)uniCode_l);
            Console.WriteLine("For the unicode character with value 111 is: {0}", (char)uniCodeo);
        }
    }
}
