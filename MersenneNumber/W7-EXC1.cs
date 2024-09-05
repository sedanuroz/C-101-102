using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EXC1
{
    internal class Program
    {

         static int getPositiveNumber()
        {
            int number;
            do
            {
                Console.Write("Enter a positive number:");
                number = int.Parse(Console.ReadLine());
            } while (number < 0);
            return number;
        }

        static void printMersenneNumbers(int number)
        {
            
            int counter= 0;
            for (int i = 0; i <= (Math.Pow(2, i) - 1); i++)
            {
                double formula = (Math.Pow(2, i) - 1);
               for(int j = 0; j <= formula; j++)
                {
                    if (formula % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter != 0)
                {
                    if (formula > number)
                    {
                        break;
                    }
                        Console.WriteLine(formula);
                }
               
            }
           
        }
        static void printPrimMersenneNumbers(int number)
        {
            int counter = 0;
            int counter2 = 0;
            for(int i = 0; i < number; i++)
            {
                double formula = (Math.Pow(2, i) - 1);
                for (int j = 0; j <= formula; j++)
                {
                    if (formula % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter != 0)
                {
                    if (formula > number)
                    {
                        break;
                    }
                    for(int k = 2; k < formula; k++)
                    {
                        if(formula%k== 0)
                        {
                            counter2++;
                            break;
                        }
                    }
                    if(formula>=2  && counter2 == 0)
                    {
                        Console.WriteLine(formula);
                    }
                    counter2 = 0;
                }

            }
        }
        static void Main(string[] args)
        {
            int positiveNumber = getPositiveNumber();
            Console.WriteLine("Mersenne numbers upto "+positiveNumber);
            printMersenneNumbers(positiveNumber);
            Console.WriteLine("Mersenne and prime numbers upto "+positiveNumber);
            printPrimMersenneNumbers(positiveNumber);
            Console.ReadLine();
        }
    }
}
