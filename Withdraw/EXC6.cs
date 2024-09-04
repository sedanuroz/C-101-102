using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int withdraw;
            Console.Write("Enter the amount for withdraw:");
            withdraw = int.Parse(Console.ReadLine());

            string rest1 = "Amount in the bank account: ";
            int rest2 = (500 - withdraw);
            int rest3 = 1000 - withdraw;
            string gap = " \n";

            string charged1 = "You are charged with: ";
            double charget2 = rest2 * (-1) * (1.7d);
            double charget3 = 500 * (1.7); 

            string thousandAtMost = "You can withdraw 1000$ at most !\n";

            Console.WriteLine((withdraw < 500)?(rest1+rest2) : 
                (withdraw>1000)?(thousandAtMost +rest1+rest3+gap+charged1+charget3):
                (rest1+rest2+gap+charged1+charget2));

            Console.ReadKey();
        }
    }
}
