using System;

namespace PrintADeckOf52Cards
{
    class PrintDeck
    {
        static string[] numbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        static char[] colours = { '♣', '♦', '♥', '♠' };
        static void Main()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < colours.Length; j++)
                {
                    Console.Write("{0,2}{1} ", numbers[i], colours[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
