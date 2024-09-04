using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a, b, c, formulaDelta;
            Console.WriteLine("Enter value a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value c : ");
            c = int.Parse(Console.ReadLine());

            formulaDelta = (b * b) - 4 * a * c;
            Console.WriteLine("Delta of the equation : {0} ",formulaDelta) ;
            Console.ReadKey();

        }
    }
}
