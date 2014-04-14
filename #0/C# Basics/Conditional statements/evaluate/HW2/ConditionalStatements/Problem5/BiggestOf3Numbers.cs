using System;
    class BiggestOf3Numbers
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            if (a < b) a = b;
            if (a < c) a = c;
            Console.WriteLine("The biggest number is " + a);
        }
    }
