using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintingDeckOf52Cards
{
    class DeckOf52Cards
    {
        static void Main(string[] args)
        {
           // switch (suits)
            string[] suit = {"\u2660","\u2665","\u2666","\u2663"};        
            string[] cards = {"J", "Q", "K", "A"};

            for (int i = 2; i <= 10; i++)
            {
                for (int suits = 0; suits < suit.Length; suits++)
                {
                    Console.Write("{0}{1} ", i, suit[suits]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < cards.Length; i++)
            {
                for (int z = 0; z < suit.Length; z++)
                {
                    Console.Write("{0}{1} ", cards[i], suit[z]);
                    
                }
                Console.WriteLine();
            }
        }
    }
}
