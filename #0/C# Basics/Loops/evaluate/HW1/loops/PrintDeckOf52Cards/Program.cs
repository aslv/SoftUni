using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeckOf52Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char karo = '\x2666';
            char spatiq = '\x2663';
            char pika = '\x2660';
            char kupa = '\x2665';
            for (int i = 1; i <= 14; i++)
            {
                if (i <= 10)
                {
                    Console.WriteLine(i + "" + karo + " " + i + spatiq + " " + i + pika + " " + i + kupa);
                }
                else 
                {
                    for (i = 11; i <= 14; i++)
                    {
                        switch (i)
                        {
                            case 11: Console.WriteLine("J" + "" + karo + " " + "J" + spatiq + " " + "J" + pika + " " + "J" + kupa); break;
                            case 12: Console.WriteLine("Q" + "" + karo + " " + "Q" + spatiq + " " + "Q" + pika + " " + "Q" + kupa); break;
                            case 13: Console.WriteLine("K" + "" + karo + " " + "K" + spatiq + " " + "K" + pika + " " + "K" + kupa); break;
                            case 14: Console.WriteLine("A" + "" + karo + " " + "A" + spatiq + " " + "A" + pika + " " + "A" + kupa); break;
                            default: break;
                        }
                    }
                }
            }
        }
    }
}
