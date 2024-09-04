using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number:");
            number=int.Parse(Console.ReadLine());

            int statament1 = number;
            int statament2 = number;
            
            int odd=1,even=0;
            

            
            while (statament2 > 0)
            {
                statament1 = statament2 % 10;
                odd *= statament1;
                statament2 =statament2 / 100;
                
            }



             statament1 = number;
             statament2 = number;

            while (statament2 >0)
            {
                statament2 = statament2 / 10;
                statament1 = statament2 % 10;
                statament2 = statament2 / 10;
                even +=statament1;
               



            }
            


            Console.WriteLine("Product of odd numbers is:{0}",odd);
            Console.WriteLine("Sum of even numbers: {0}",even);
            Console.ReadLine();


        }
    }
}
