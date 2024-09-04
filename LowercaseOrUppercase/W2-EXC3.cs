using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char first, second, third, fourth, fifth;

            Console.Write("Enter the 1st character : ");
            first = char.Parse(Console.ReadLine());

            Console.Write("Enter the 2nd character : ");
            second = char.Parse(Console.ReadLine());

            Console.Write("Enter the 3rd character : ");
            third = char.Parse(Console.ReadLine());

            Console.Write("Enter the 4th character : ");
            fourth = char.Parse(Console.ReadLine());

            Console.Write("Enter the 5th character : ");
            fifth = char.Parse(Console.ReadLine());

            int first1 = (int)first;
            int second1 = (int)second;
            int third1 = (int)third;
            int fourth1 = (int)fourth;
            int fifth1 = (int)fifth;
            int uppercase = 0;
            int lowercase = 0;



            int condition1 = (first1 <= 90) && (first1 >= 65) ? (uppercase++) : (lowercase++);
            int condition2 = (second1 <= 90) && (second1 >= 65) ? (uppercase++) : (lowercase++);
            int condition3 = (third1 <= 90) && (third1 >= 65) ? (uppercase++) : (lowercase++);
            int condition4 = (fourth1 <= 90) && (fourth1 >= 65) ? (uppercase++) : (lowercase++);
            int condition5 = (fifth1 <= 90) && (fifth1 >= 65) ? (uppercase++) : (lowercase++);




            Console.WriteLine("You entered {0} uppercase letters.", uppercase);
            Console.WriteLine("You entered {0} lowercase letters.", lowercase);

            string more = uppercase > lowercase ? "uppercase" : "lowercase";
            Console.WriteLine("You entered more {0} letters. ", more);



            Console.ReadKey();

        }
    }
}
