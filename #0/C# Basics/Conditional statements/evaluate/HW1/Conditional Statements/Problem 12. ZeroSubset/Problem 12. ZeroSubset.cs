using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.ZeroSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 12: We are given 5 integer numbers.
            //Write a program that finds all subsets of these numbers whose sum is 0. 
            //Assume that repeating the same subset several times is not a problem. 

            int[] array = {1, 3, -4, -2, -1};
            int[] bynarySubsets = new int[5];
            int[]  resultArray = new int[5];
            int resultOfDevising = 0;
            int remeinder = 0;
            int bynaryIndex = 0;
            int sum = 0;
            int count = 0;

            for (int i = 1; i <= 31; i++)
            {
                resultOfDevising = i;
                do
                {
                    remeinder = resultOfDevising % 2;
                    resultOfDevising = resultOfDevising / 2;                               
                    bynarySubsets[bynaryIndex] = remeinder;
                    bynaryIndex++;
                } while (resultOfDevising != 0);

                bynaryIndex = 0;

                for (int index = 0; index < resultArray.Length; index++)
                {
                    resultArray[index] = array[index] * bynarySubsets[index];
                }

                for (int ind = 0; ind < resultArray.Length; ind++)
                {
                    sum += resultArray[ind];
                }

                if (sum == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", resultArray[0], resultArray[1], resultArray[2],
                        resultArray[3], resultArray[4], sum);
                    count++;
                }
                else
                {
                    sum = 0;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
