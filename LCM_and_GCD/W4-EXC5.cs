using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1, number2, i = 0, gcd = 0,lcm=0 ;
            Console.Write("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());
            int smallestNumber = number1;
            
            if (smallestNumber >number2)
            {
          
                smallestNumber = number2;
            }


            i = smallestNumber;
            while ( i>0)
            {
               
                if(number1%i==0   && number2 % i == 0)
                {
                    
                    gcd=i;
                    break;
                }
                i--;
            }



            int j =0;
            while( (number1*number2)>=j)
            {
                j++;
                if(j%number1==0  && j % number2 == 0)
                {
                    lcm = j;
                    break;
                }
                
            }

            Console.WriteLine("LCM of {0} and {1} is: {2}",number1,number2,lcm);
            Console.WriteLine("GCD of {0} and {1} is: {2}", number1, number2, gcd);
            Console.ReadKey();

        }
    }
}
