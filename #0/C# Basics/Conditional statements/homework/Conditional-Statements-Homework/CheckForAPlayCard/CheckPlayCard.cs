using System;

namespace CheckForAPlayCard
{
    class CheckPlayCard
    {
        static void Main()
        {
            string sign = Console.ReadLine();
            int n;
            char c;
            if (int.TryParse(sign, out n))
            {
                if (n >= 2 && n <= 10)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else if (char.TryParse(sign, out c))
            {
                if (c == 'J' || c == 'Q' || c == 'K' || c == 'A')
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
