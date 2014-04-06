using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            //With using quoted strings
            string quotes = "The \"use\"";
            string sentence = "of quotations causes difficulties.";
            Console.WriteLine("{0} {1}", quotes, sentence);
            //Without using quoted strings
            string noQuotes = "The \"";
            string sentNoQu = "use\" of quotations causes difficulties.";
            Console.WriteLine(noQuotes + sentNoQu);
        }
    }
}
