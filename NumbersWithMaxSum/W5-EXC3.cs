using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];                     //i defined an array and i made the number i received from the user the length of the array
            int k = 0;

            while (length > k)                                   //i defined the array elements by taking them from the user with while loop
            {
                Console.Write("Enter the value:");         
                array[k]=int.Parse(Console.ReadLine());
                k++;

            }

            int max = int.MinValue;                              //i defined 2 variables to find the total maxsimum value:variables are max and total
            int total = 0; 
            for (int i = 0; i < array.Length; i++)                //i used 2 for loop to find the maximum value
            {
                total = 0;                                        //i reset the total for each new i value
                for(int j =i ; j < array.Length; j++)
                {
                    total += array[j];                             //i added each new element to the total 
                    if (total > max)                               //if the total is greater than the max ,the new max  value should be total
                    {
                        max = total;
                    }
                }
            }

            Console.WriteLine("Maximum sum:{0} ",max);       //i printed the maxsimum value on the screen
            Console.ReadKey();

        }
    }
}
