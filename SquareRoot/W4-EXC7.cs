using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {



            float number;
            Console.Write("Enter the number:");
            number = float.Parse(Console.ReadLine());

            do
            {
               
                Console.WriteLine("ERROR! You can not enter integer smaller than zero or greater than 100");
                Console.WriteLine("Enter the number again:");
                number = float.Parse(Console.ReadLine());


            } while (number > 100 || number < 0);

            Random rnd=new Random();
            float firstEstimate=rnd.Next(0,101);

            float secondEstimate = 0f ;

            while(true)
            {
                secondEstimate = (firstEstimate + (number / firstEstimate) )/ 2f;

                if (firstEstimate == secondEstimate)
                {
                    break;
                }
                Console.WriteLine(secondEstimate);
                firstEstimate = secondEstimate;


            }


            Console.ReadKey();

        }
    }
}
