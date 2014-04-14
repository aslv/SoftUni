using System;
   class choice
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Please enter an integer");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine(n+1);
                        
                    } break;
                case 2:
                    {
                        Console.WriteLine("Please enter a double");
                        double n = double.Parse(Console.ReadLine());
                        Console.WriteLine(n + 1);

                    } break;
                case 3:
                    {
                        Console.WriteLine("Please enter an string");
                        string str = Console.ReadLine();
                        Console.WriteLine(str+"*");
                    } break;
            }
        }
    }




