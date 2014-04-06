using System;

namespace OddAndEvenProduct
{
    class OddEvenProd
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string[] values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int current, oddProduct = 1, evenProduct = 1;
            for (int i = 0; i < n; i++)
            {
                current = int.Parse(values[i]);
                if (i % 2 == 0)
                {
                    oddProduct *= current;
                }
                else
                {
                    evenProduct *= current;
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes\nproduct = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
            }
        }
    }
}
