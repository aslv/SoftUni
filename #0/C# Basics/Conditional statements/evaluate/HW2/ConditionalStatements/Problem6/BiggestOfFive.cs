using System;
   class BiggestOfFive
    {
        static void Main()
        {
            Console.Write("n1= ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("n2= ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("n3= ");
            double n3 = double.Parse(Console.ReadLine());
            Console.Write("n4= ");
            double n4 = double.Parse(Console.ReadLine());
            Console.Write("n5= ");
            double n5 = double.Parse(Console.ReadLine());
            if (n1 < n2) n1 = n2;
            if (n1 < n3) n1 = n3;
            if (n1 < n4) n1 = n4;
            if (n1 < n5) n1 = n5;
            Console.WriteLine("The biggest number is " + n1);
        }
    }