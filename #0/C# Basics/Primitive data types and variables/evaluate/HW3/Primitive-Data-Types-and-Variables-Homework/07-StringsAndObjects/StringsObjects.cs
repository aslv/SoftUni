using System;

class StringsObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concatenated = hello + " " + world;
        string helloworld = (string)concatenated;
        Console.WriteLine(helloworld);
    }
}