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
            Random rnd = new Random();
            int[] array = new int[15];
            int k;

            Console.WriteLine("Randomly created array with length 15 is :");
            for (int a = 0; a < array.Length; a++)
            {
                int index = rnd.Next(-100, 101);
                array[a] = index;
                Console.Write(array[a] + "  ");
            }
            Console.WriteLine("");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                    {
                        if (array[i] < array[j])
                        {
                            k = array[i];
                            array[i] = array[j];
                            array[j] = k;
                        }
                    }
                }
            }

           //i explained that what i did at the top in the first exercise

            Console.WriteLine("");
            Console.WriteLine("Sorted array with length 15 is:");
            for (int b = 0; b < array.Length; b++)    
            {
                Console.Write(array[b] + "  ");         //i writed the elements of array with for loop
            }

            Console.WriteLine("\n");
            int q1 = 15/4;             //i found first quarter's value
            int q3 = 15 - (15 / 4)-1;  //i found last quarter's value
            int median = (15 / 2);     //i found medan's value
            Console.WriteLine("Q1 of the array is: " + array[q1] +"\n"); 
            Console.WriteLine("Q3 of the array is: " + array[q3] + "\n");
            Console.WriteLine("IQR of the array is : " + (  array[q3] - array[q1] ) +"\n");
            Console.WriteLine("Minimum of the array is:"+ array[0]+ "\n");
            Console.WriteLine("Maximum of the array is:"+ array[14]+"\n");
            Console.WriteLine("Median of the array is :{0}", array[median]);

            Console.ReadLine();
        }
    }
}
