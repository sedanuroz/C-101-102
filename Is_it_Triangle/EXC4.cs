using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side1,side2,side3,angle1,angle2,angle3;

            Console.Write("Enter the first side: ");
            side1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second side: ");
            side2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third side: ");
            side3 = int.Parse(Console.ReadLine());

            Console.Write("Enter the first angle: ");
            angle1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second angle: ");
            angle2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third angle: ");
            angle3 = int.Parse(Console.ReadLine());

            bool result1=(side2+ side3)>side1 && (side1+side3)>side2 && (side1+side2)>side3;
            bool result2 = angle1 > 0 && angle2 > 0 && angle3 > 0 && (angle1 + angle2 + angle3 == 180);

            if (result1)
            {
                Console.WriteLine("Sides are meeting the conditions. ");
            }
            else
            {

                Console.WriteLine("Sides are not meeting the conditions.");
            }


            if(result2)
            {
                Console.WriteLine("Angles are meeting the conditions.");
            }
            else
            {
                Console.WriteLine("Angles are not meeting the conditions.");
            }

            if(result1 && result2)
            {
                if(side1==side2 && side2 == side3)
                {
                    Console.WriteLine("Eqilateral triangle.");
                }
                else if(side1!=side2 && side1!=side3 && side2!=side3)
                {
                    Console.WriteLine("Scalene triangle.");
                }
                else
                {
                    Console.WriteLine("Isosceles triangle.");
                }
            }

            Console.ReadLine();

        
        }
    }
}
