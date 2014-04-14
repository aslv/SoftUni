using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class Program                   
    {
        static void Main(string[] args)
        {
            
            int x =1;
            int n = int.Parse(Console.ReadLine());
            int nN = n;
            for (int a = 1; a <= n; a++)
            {
                
    
                for (int i = x; i <= nN; i++)
                {
                    string space = " ";
                    if (a>9||i>8)
                    {
                        space = "";
                    }
                   
                   
                    Console.Write(i+" "+space);              
                } 
                Console.WriteLine();
                nN++;
                x++;    
            }
        }
    }
}
