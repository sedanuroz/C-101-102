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
            Random rnd=new Random();            // i defined random                     
            int[] array = new int[15];          // i defined array
            int k;                              //i defined constant value for change the array element

            Console.WriteLine("Randomly created array with length 15 is :");  
            
            for(int a = 0; a < array.Length; a++)  //i have generated a random number according to the array size
            {
                int index = rnd.Next(-100, 101);    //i generated a random number for each  new 'a' value
                array[a] = index;                   //i assigned the generated random number to the a. element of the array
                Console.Write(array[a]+"  "  );     //i have printed the element of array on the screen
            }
            Console.WriteLine("");

            for(int i = 0; i < array.Length; i++)   //i used two separate for loops to campare on element of the array with 
            {                                       //other elements
                for(int j=0;j<array.Length; j++)
                {
                    if (i != j)                     //i used this condition because ,for example i dont want compare array[0] and [0]
                    {
                        if (array[i] < array[j])    //i compared two array
                        {                           
                            k = array[i];           //i changed the locatıon of the element
                            array[i] = array[j];
                            array[j] = k;
                        }
                    }
                }
            }

           

            Console.WriteLine("");
            Console.WriteLine("Sorted array with length 15 is:");
            for(int b = 0; b < array.Length; b++)       //i used to for loop to print each element to the screen 
            {
                Console.Write(array[b]+"  ");
            }

            Console.ReadLine();
            
        }
    }
}
