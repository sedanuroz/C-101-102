using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace EXC2
{
    internal class Program
    {
        
       
        static int Min(int number1,int number2)
        {


            int min = number1;
            if (number1 == number2)
            {
                return 0;
            }
            else if(number1<0 || number2 < 0)
            {
                return -1;
            }
            else if (number2 < min)
            {
                min=number2;
                return min;
            }
            else
            {
                return min;
            }

        }


        static int Max(int number1, int number2)
        {

            int max = number1;
            if (number1 == number2)
            {
                return 0;
            }
            else if (number1 < 0 || number2 < 0)
            {
                return -1;
            }
            else if (number2 > max)
            {
                max = number2;
                return max;
            }
            else
            {
                return max;
            }

        }

        static int Pow(int number ,int exponent)
        {
            if(number<0 || exponent < 0)
            {
                return -1;
            }
            int multiple = 1;
            while (exponent > 0)
            {
                multiple *= number;
                exponent--;
            }
            return multiple;
        }
        
        static double Sqrt(int number)
        {
            Random rnd = new Random();
            float firstEstimate = rnd.Next(0, 101);

            float secondEstimate = 0f;

            while (true)
            {
                secondEstimate = (firstEstimate + (number / firstEstimate)) / 2f;

                if (firstEstimate == secondEstimate)
                {
                    break;
                }
               
                firstEstimate = secondEstimate;


            }

            return secondEstimate;
     
        }

        static void PrintrootsOfEquation(int a,int b,int c)
        {
            int delta = Pow(b, 2) - (4 * a * c);
            if (delta < 0)
            {
                Console.WriteLine("Error!!!");
            }
            else
            {
                Console.WriteLine("Root1: " + (-b + (int)Sqrt(delta)) /(2*a)) ;
                Console.WriteLine("Root2: " + (-b - (int)Sqrt(delta)) / (2 * a));
            }

        }

        
        static void Main(string[] args)
        {
            Console.WriteLine(Min(3,5));
            Console.WriteLine(Max(3,5));
            Console.WriteLine(Pow(5,3));
            Console.WriteLine(Sqrt(66));
            PrintrootsOfEquation(2, 4, -6);
            
            Console.ReadKey();

        }
    }
}
