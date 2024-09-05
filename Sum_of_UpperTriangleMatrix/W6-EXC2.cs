using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {/*
                {2,7,3,2,1 },
                {1,2,2,6,1 },
                {4,2,9,3,1 },
                {2,5,1,3,6 },
                {3,6,9,2,1 }
            */

                {2,7,3 },
                {1,2,2 },
                {4,2,9 }

            };
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n");

            int k = 0;int sum = 0;
            while (k < arr.GetLength(0))
            {
                for (int i = k; i < arr.GetLength(1); i++)
                {
                    sum += arr[k, i];
                }
                k++;
            }
            Console.WriteLine("Sum of the upper triangle is:{0}",sum);
            Console.ReadKey();
        }          
    }
}
