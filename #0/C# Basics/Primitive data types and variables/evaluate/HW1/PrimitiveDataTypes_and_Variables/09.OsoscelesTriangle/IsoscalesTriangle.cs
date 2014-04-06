using System;

namespace _09.OsoscelesTriangle
{
    class IsoscalesTriangle
    {
        static void Main()
        {
            int intChar = 169;
            char symbolC;
            char empty = ' ';
            symbolC = (char)intChar;

            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", empty, empty, empty, empty, symbolC, empty, empty,empty);
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", empty,empty, empty, symbolC, empty, symbolC, empty, empty);
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", empty,empty, symbolC, empty, empty, empty, symbolC, empty);
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", empty,symbolC,empty, symbolC, empty, symbolC, empty, symbolC);
        }
    }
}
