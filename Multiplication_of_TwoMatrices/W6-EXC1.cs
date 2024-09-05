using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix a:");
            int[,] arr1 =
            {
                {1,4,2 },
                {2,5,1 },
                {1,2,1 }
             
            };

            for(int i=0; i<arr1.GetLength(0); i++)
            {
                for(int j=0; j<arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Matrix b:");
            int[,] arr2 =
            {
                {3,4,2 },
                {3,5,7 },
                {1,2,1 }

            };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine("");
            }

            int[,] arrMatrices = new int[arr1.GetLength(0), arr1.GetLength(1)];
            int sum = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr2.GetLength(1); k++)
                    {
                        sum += arr1[i, k] * arr2[k,j ];
                    }
                    arrMatrices[i,j] = sum;
                    sum = 0;
                }

            }


            Console.WriteLine("The product of the matrices is:");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arrMatrices[i, j] + " ");
                }
                Console.WriteLine("");
            }



            Console.ReadKey();
        }
    }
}
