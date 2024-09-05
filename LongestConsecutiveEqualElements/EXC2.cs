using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, value = 0 ;
            Console.Write("Enter the legth of the array:");
            int length=int.Parse(Console.ReadLine());
            int[] array = new int[length];

            Console.Write("Enter the integer:");        
            int num = int.Parse(Console.ReadLine());
            array[0] = num;

            for (int i = 1; i < length; i++)
            {
                Console.Write("Enter the integer:");
                num = int.Parse(Console.ReadLine());
                array[i] = num;

                if(array[i]== array[i - 1])
                {
                    counter++;
                    value = num;
                }
            }

            Console.Write("Maximal sequence of consecutive equal elements{");
            while(counter > 0)
            {
                Console.Write(value);
                Console.Write(",");
                counter--;
            }
            Console.Write(value+"}");
            

            Console.ReadKey();

           
        }
    }
}
