using System;

class StringAndObjects
{
    static void Main(string[] args)
    {
        string firstPhrase = "Hello";
        string secondPhrase = "World!";
        object union = firstPhrase + " " + secondPhrase;

        string finalPhrase = union as string;

        Console.WriteLine(finalPhrase);

    }
}
