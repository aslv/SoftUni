using System;

class Quotes
{
    static void Main()
    {
        string quotedstring = @"The ""use"" of quotations causes difficulties.";
        string withoutquote = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(quotedstring);
        Console.WriteLine(withoutquote);
    }
}