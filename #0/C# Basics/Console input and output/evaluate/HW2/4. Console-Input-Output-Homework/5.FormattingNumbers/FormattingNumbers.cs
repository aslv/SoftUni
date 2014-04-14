using System;

class FormattingNumbers
{
    static void Main()
    {
        int a;
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 499) Console.WriteLine("Invalid input!!!");

        double b;
        while (!double.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Invalid input!!!");

        double c;
        while (!double.TryParse(Console.ReadLine(), out c)) Console.WriteLine("Invalid input!!!");

        string hack = String.Empty; // опитвам се да нагодя, сумите да са през 10 символа както е по-условие
        Console.Write("|{0:X}{1, -10}|{2}|{1, -10}{3:F2}|", a, hack, Convert.ToString(a, 2).PadLeft(10, '0'), b);

        bool check = Convert.ToString(c).IndexOf(".") > 0;
        Console.WriteLine(check ? "{0:0.000}" : "{0}", c);

        Console.WriteLine();
    }
}

