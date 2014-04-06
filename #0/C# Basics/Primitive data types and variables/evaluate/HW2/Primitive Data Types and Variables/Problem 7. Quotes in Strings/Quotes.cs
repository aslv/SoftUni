using System;

class Quotes
{
    static void Main(string[] args)
    {
        string firstPhrase = "The \"use\" of quotations causes difficulties.";
        string secondPhrase = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(firstPhrase + "\n" + secondPhrase);
    }
}