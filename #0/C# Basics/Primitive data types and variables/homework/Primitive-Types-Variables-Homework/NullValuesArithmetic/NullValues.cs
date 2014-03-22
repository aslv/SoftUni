using System;

namespace NullValuesArithmetic
{
    class NullValues
    {
        static void Main()
        {
            int? i = null;
            Console.WriteLine(i);
            Nullable<double> d = null;
            Console.WriteLine(d);
            i += 5;
            d += 9.03;
            Console.WriteLine(i);
            Console.WriteLine(d);
        }
    }
}
