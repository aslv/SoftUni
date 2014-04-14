using System;
   class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("a= ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b=int.Parse(Console.ReadLine());
            if(a>b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("a= {0}; b= {1}",a,b);
            }
            else Console.WriteLine("a < b, no change was made.");
        }
    }
