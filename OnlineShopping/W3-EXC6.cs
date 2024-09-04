
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password,price;
            string brandNameOrCompuerID,areYouStudent;
          

            Console.Write("Enter your password: ");
            password = int.Parse(Console.ReadLine());

   



            if (password > 999 && password < 1000000)
            {
                Console.Write("Enter a brand name or a computer ID:");
                brandNameOrCompuerID = Console.ReadLine();


                if (brandNameOrCompuerID == "Dell" || brandNameOrCompuerID == "234")
                {

                    Console.WriteLine("Are you a student ?(Y/N)");
                    areYouStudent = Console.ReadLine();

                    if (areYouStudent == "Y")
                    {
                        price = 2500 - (2500 * 20) / 100;
                        Console.WriteLine("Total price is {0}$.", price);
                    }
                    else
                    {
                        price = 2500;
                        Console.WriteLine("Total price is {0}$.", price);
                    }
                }
                else if (brandNameOrCompuerID == "Asus" || brandNameOrCompuerID == "536")
                {

                    Console.WriteLine("Are you a student ?(Y/N)");
                    areYouStudent = Console.ReadLine();

                    if (areYouStudent == "Y")
                    {
                        price = 1500 - (1500 * 20) / 100;
                        Console.WriteLine("Total price is {0}$.", price);
                    }
                    else
                    {
                        price = 1500;
                        Console.WriteLine("Total price is {0}$.", price);
                    }
                }
                else if (brandNameOrCompuerID == "Monster" || brandNameOrCompuerID == "862")
                {

                    Console.WriteLine("Are you a student ?(Y/N)");
                    areYouStudent = Console.ReadLine();

                    if (areYouStudent == "Y")
                    {
                        price = 1000 - (1000 * 20) / 100;
                        Console.WriteLine("Total price is {0}$.", price);
                    }
                    else
                    {
                        price = 1000;
                        Console.WriteLine("Total price is {0}$.", price);
                    }
                }
                else if (brandNameOrCompuerID == "HP" || brandNameOrCompuerID == "601")
                {
                    Console.WriteLine("Are you a student ?(Y/N)");
                    areYouStudent = Console.ReadLine();

                    if (areYouStudent == "Y")
                    {
                        price = 1750 - (1750 * 20) / 100;
                        Console.WriteLine("Total price is {0}$.", price);
                    }
                    else
                    {
                        price = 1750;
                        Console.WriteLine("Total price is {0}$.", price);
                    }

                }
                else
                {
                    Console.WriteLine("There is no matching brand name or ID according to your input.");
                }
            }
            else
            {
                Console.WriteLine("Password is incorrect !");
            }

            
            Console.ReadKey();




        }
    }
}
