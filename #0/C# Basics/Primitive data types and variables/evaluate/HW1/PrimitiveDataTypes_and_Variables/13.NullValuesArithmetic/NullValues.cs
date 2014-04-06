using System;

namespace _13.NullValuesArithmetic
{
    class NullValues
    {
        static void Main()
        {
            int? intForNull = null;
            double? realForNull = null;
            Console.WriteLine("Value for integer variable 1 is: --> {0} <--", intForNull);
            Console.WriteLine("Value for double  variable 2 is: --> {0} <--", realForNull);
            Console.WriteLine("The values for first and second variables is NULL! To change this...");
            Console.Write("Enter some value for first variable: ");
            intForNull = int.Parse(Console.ReadLine());
            intForNull += intForNull;                                       //Summing the variable 1 with himself
            Console.WriteLine("The value for int is:            --> {0} <--", intForNull);
            Console.Write("Enter some value for second variable: ");
            realForNull = double.Parse(Console.ReadLine());
            realForNull += realForNull;                                     //Summing the variable 2 with himself
            Console.WriteLine("The value for real is:           --> {0} <--", realForNull);

        }
    }
}
