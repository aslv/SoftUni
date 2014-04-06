using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;     //needed to print the symbol
        Console.WriteLine("©".PadLeft(4));
        Console.WriteLine("© ©".PadLeft(5));
        Console.WriteLine("©   ©".PadLeft(6));
        Console.WriteLine("© © © ©");
    }
}