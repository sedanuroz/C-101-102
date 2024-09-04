using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nValue;
            while (true) 
            {
                Console.Write("Enter the value n: ");
                 nValue = int.Parse(Console.ReadLine());

                if (nValue == 0 || nValue == 1)
                {
                    Console.WriteLine("You can not 1 or 0 ! "); 
                }

                if(nValue > 1)
                {
                    Console.WriteLine("");
                    break; 
                }

            }



            int sum = 0;
            bool isPrime = true;

            
            for(int i = 2; i <=nValue; i++)
            {
                isPrime = true;
                for(int j = 2; j <i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                    sum += i;
                }

            }




            Console.WriteLine("Sum of the prime numbers is :{0}",sum);
            Console.ReadKey();
        }
    }
}
