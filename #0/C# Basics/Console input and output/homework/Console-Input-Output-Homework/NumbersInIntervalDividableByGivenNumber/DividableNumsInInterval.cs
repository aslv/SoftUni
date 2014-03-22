using System;

namespace NumbersInIntervalDividableByGivenNumber
{
    class DividableNumsInInterval
    {
        static void Main()
        {
            Console.Write("start = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("end = ");
            int end = int.Parse(Console.ReadLine());

            while (start % 5 != 0)
            {
                start++;
            }
            int p;
            if (start > end)
            {
                p = 0;
            }
            else if (start == end)
            {
                p = 1;
            }
            else
            {
                p = (end - start) / 5 + 1;
            }
            Console.WriteLine("p = {0}", p);
        }
    }
}
