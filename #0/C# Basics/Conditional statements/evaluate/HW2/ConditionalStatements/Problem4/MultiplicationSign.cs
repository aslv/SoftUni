using System;
   class MultiplicationSign
   {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            int negativ=0;
            if (a == 0 || b == 0 || c == 0) Console.WriteLine(0);
            else
            {
                if (a < 0) negativ++;
                if (b < 0) negativ++;
                if (c < 0) negativ++;
                if (negativ % 2 == 0) Console.WriteLine("+");
                else Console.WriteLine("-");
            }
            

        }
    }

