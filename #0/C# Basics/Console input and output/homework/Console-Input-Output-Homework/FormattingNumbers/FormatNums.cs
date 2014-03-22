using System;

namespace FormattingNumbers
{
    class FormatNums
    {
        static void Main()
        {
            Console.Write("a = ");
            short a = short.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
