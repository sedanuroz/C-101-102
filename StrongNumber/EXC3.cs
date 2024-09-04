using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number to check whether it is Strong number: ");
            number = int.Parse(Console.ReadLine());

            
            int sum = 0;

            
            int statament1 = number;
            int statament2 = number;


            while (statament1 > 0)
            {
                statament2 = statament1 % 10;
                statament1 /= 10;
               
                int factoriel = 1;
                for (int i = 1; i <= statament2; i++)
                {

                    factoriel *= i;
                }
                sum+=factoriel;
                
            }


            if (sum == number)
            {
                Console.WriteLine("{0} is a strong number.",number);
            }
            else
            {
                Console.WriteLine("{0} is  not a strong number.", number);
            }

           




            
                Console.ReadKey();
        }
    }
}
