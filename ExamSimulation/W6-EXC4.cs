using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 2, 5, 1, 2, 5, 3, 1, 2, 6, 1 };
            int[] arr2 = { 5, 4, 7, 6, 3, 9, 4, 5, 5, 6 };
            int[] arr3 = { 9, 7, 6, 8, 4, 10, 8, 7, 9, 9 };

            int[,] students =
            {
                {1,8,9,7,5,10,7,4,5,6,9 },
                {2,4,5,6,4,6,5,3,2,1,7 },
                {3,8,7,9,10,10,4,7,5,10,4 },
                {4,1,4,6,3,2,0,2,3,5,6 },
                {5,2,4,6,5,7,6,7,3,4,5 }
            };
            int group = 0;
            double distance1 = 0, distance2 = 0, distance3 = 0, min;

            for (int i = 0; i < students.GetLength(0); i++)
            {

                distance1 = 0;
                distance2 = 0;
                distance3 = 0;

                for (int j = 1; j < students.GetLength(1); j++)
                {
                    distance1 += Math.Pow(students[i, j] - arr1[j - 1], 2);
                }
                
                for (int j = 1; j < students.GetLength(1); j++)
                {
                    distance2 += Math.Pow(students[i, j] - arr2[j - 1], 2);
                }
               
                for (int j = 1; j < students.GetLength(1); j++)
                {
                    distance3 += Math.Pow(students[i, j] - arr3[j - 1], 2);
                }

                distance1 = Math.Sqrt(distance1);
                distance2 = Math.Sqrt(distance2);
                distance3 = Math.Sqrt(distance3);

                min = distance1;
                group = 1;

                if (distance2 < min)
                {
                    min = distance2;
                    group = 2;
                }
                if (distance3 < min)
                {
                    min = distance3;
                    group = 3;
                }
                Console.WriteLine("Student {0} belongs to group {1}", i+1, group);
            }
            Console.ReadLine();

           

           
        }
    }
}
