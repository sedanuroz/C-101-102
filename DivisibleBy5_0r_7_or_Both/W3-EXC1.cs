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

            int number;
            Console.Write("Enter the number:");
            number = int.Parse(Console.ReadLine());

            bool isRightValue = false;

            if(number>500)
            {
                Console.WriteLine( "Error ! Number {0} is bigger than 500",number);
            }
            else if(number<0)
            {
                Console.WriteLine("Error! Number {0} is smaller then 0.",number);

            }
            else if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("Number {0} is divisible by both 5 and 7.", number);
            }
           
            else if (number % 5 == 0)
            {
                Console.WriteLine("Number {0} is divisible by 5.",number);
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Number {0} is divisible by 7.", number);
            }
            else
            {
                Console.WriteLine("Number {0} is not divisible by 5 or 7.", number);
            }
            


            Console.ReadKey();

            }

        }
    }

