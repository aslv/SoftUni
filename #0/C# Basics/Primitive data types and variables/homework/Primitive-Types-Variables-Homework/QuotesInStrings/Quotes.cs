using System;

namespace QuotesInStrings
{
    class Quotes
    {
        static void Main()
        {
            string statement0 = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(statement0);
            string statement1 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(statement1);
        }
    }
}
