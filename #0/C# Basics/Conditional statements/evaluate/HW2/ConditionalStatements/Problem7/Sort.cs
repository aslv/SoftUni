using System;
    class Sort
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            if (a < b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if (a < c)
            {
                a = a + c;
                c = a - c;
                a = a - c;
            }
            if (b < c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            Console.WriteLine("{0} {1} {2}",a,b,c);
        }
    }
