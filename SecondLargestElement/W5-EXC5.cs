using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();

            Console.WriteLine("Newly created list is :");
            for(int i=0;i<array.Length; i++)        // i created  elements for array randomly
            {
                int index=random.Next(0,51);
                array[i]=index;
                Console.Write(array[i]+"  ");
            }
            Console.WriteLine();


            int greatest = 0;
           
            for (int i = 1; i < array.Length; i++)                     //i found the array element with the largest index value
            {
                greatest = greatest < array[i] ? array[i] : greatest;
                
            }

            Console.WriteLine("Gratest item:{0}", greatest);            //i writed the greatest value.

            int secondGreatest = 0;                                                    
            for (int i = 1; i < array.Length; i++)                          // found the second largest value with for loop and if 
            {
                if (array[i] < greatest)
                {
                    if (array[i] > secondGreatest)
                    {
                        secondGreatest = array[i];
                    }
                }
                
            }
            Console.WriteLine("Second greatest item:{0}", secondGreatest);   //i writed the second largest value

            Console.ReadKey();
        }
    }
}
