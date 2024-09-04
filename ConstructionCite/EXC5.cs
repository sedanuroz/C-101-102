using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC5_TRUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstSiteX, firstSiteY,secondSiteX,secondSiteY,distanceFirst,distanceSecond;
            int schoolX = -7, schoolY = 5 ;
            Console.Write("Enter x of Site 1: ");
            firstSiteX = int.Parse(Console.ReadLine());
            Console.Write("Enter y of Site 1: ");
            firstSiteY = int.Parse(Console.ReadLine());
            Console.Write("Enter x of Site 2: ");
            secondSiteX = int.Parse(Console.ReadLine());
            Console.Write("Enter y of Site 2: ");
            secondSiteY = int.Parse(Console.ReadLine());

            distanceFirst = (firstSiteX -schoolX)* (firstSiteX - schoolX) +( firstSiteY -schoolY)* (firstSiteY - schoolY);
            distanceSecond = (secondSiteX -schoolX)* (secondSiteX - schoolX) +( secondSiteY -schoolY)* (secondSiteY - schoolY);
           
            string allowed1 = (distanceFirst >= 120) ? "allowed" : "not allowed";
            string allowed2 = (distanceSecond >= 120) ? "allowed" : "not allowed";

            Console.WriteLine("Distance from Site 1 to school: {0}",distanceFirst) ;
            Console.WriteLine("Distance from Site 2 to school: {0}",distanceSecond);
            Console.WriteLine("Construction site 1 is {0}", allowed1);
            Console.WriteLine("Construction site 2 is {0}", allowed2);

            Console.ReadKey();
           
            
        }
    }
}
