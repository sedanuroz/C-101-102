using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DENEME
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double unitConsumed, bill, netBill;
            Console.Write("Enter total unit consumed :");
            unitConsumed = double.Parse(Console.ReadLine());

            if (unitConsumed <= 50)
            {
                bill = unitConsumed * (0.50);
            }
            else if (unitConsumed <= 150 && unitConsumed > 50)
            {
                bill = 50 * (0.5) + (unitConsumed - 50) * (0.75);
            }
            else if (unitConsumed <= 250 && unitConsumed > 150)
            {
                bill = 50 * (0.5) + 100 * (0.75) + (unitConsumed - 150) * 1.20;
            }
            else
            {
                bill = 50 * (0.5) + 100 * (0.75) + 100 * 1.20 + (unitConsumed - 250) * 150;
            }


            netBill = bill + (bill * 20) / 100;
            Console.WriteLine("Net electricity bill is {0} $", netBill);
            Console.ReadKey();



        }
    }
}
