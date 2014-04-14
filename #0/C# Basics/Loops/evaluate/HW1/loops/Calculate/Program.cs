using System;
using System.Linq;
using System.Text;


namespace Calculate
{
    class Program
    {
        static void Main()
        
        {
            double sum = 1;                            
            double department = 0;
            double faktoriel = 1;
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            
            double s =x;
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for(int i=1 ;i<=n;i++)
            {
            faktoriel *= i;
            department =faktoriel / s;
            sum += department;
            s = s * x; 
            }
            Console.WriteLine("{0:f5}",sum);
        }
    }
}
