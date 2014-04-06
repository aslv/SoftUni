using System;

namespace MultiplicationSign
{
    class MultSign
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            int? positives = 0;
            if (a > 0)
            {
                positives++;
            }
            else if (a < 0)
            {
                positives--;
            }
            else
            {
                positives = null;
            }

            if (b > 0)
            {
                positives++;
            }
            else if (b < 0)
            {
                positives--;
            }
            else
            {
                positives = null;
            }

            if (c > 0)
            {
                positives++;
            }
            else if (c < 0)
            {
                positives--;
            }
            else
            {
                positives = null;
            }

            char result;
            if (positives == null)
            {
                result = '0';
            }
            else
            {
                if (positives == -1 || positives == 3)
                {
                    result = '+';
                }
                else
                {
                    result = '-';
                }
            }
            Console.WriteLine(result);
        }
    }
}
