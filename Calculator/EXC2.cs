using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation, firstInteger, secondInterger;
            double result;

            Console.Write("Select an operation : ");
            operation = int.Parse(Console.ReadLine());
            Console.Write("Enter first integer :");
            firstInteger = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            secondInterger = int.Parse(Console.ReadLine());


            if (operation == 4)
            {
                if (secondInterger == 0)
                {
                    Console.WriteLine("Error! Second integer can not be 0.");
                    Console.WriteLine("Please ,enter second integer again.");
                }
                else
                {
                     
                    result = (double)firstInteger / secondInterger;
                    Console.WriteLine("Result of the operation is {0} ", result);
                  
                }
               


            }
            else {

                switch (operation)
                {

                    case 1:
                        result = firstInteger + secondInterger;
                        Console.WriteLine("Result of the operation is {0} ", result);
                        break;
                    case 2:
                        result = firstInteger - secondInterger;
                        Console.WriteLine("Result of the operation is {0} ", result);
                        break;
                    case 3:
                        result = firstInteger * secondInterger;
                        Console.WriteLine("Result of the operation is {0} ", result);
                        break;
                  

                    default:
                        Console.WriteLine("Unknown operation !");
                        break;

                }



            }

           

            Console.ReadLine();

        }   

        
    }
}
