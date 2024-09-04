using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // equation=2x*2x+4x-6
            double a = 2d;
            double b = 4d;
            double c = -6d;
            double delta = b * b - 4 * a * c;
            double sqrtDelta = Math.Sqrt(delta);
            double firstRoot = (-b + sqrtDelta) / (2 * a);
            double secondRoot = (-b - sqrtDelta) / (2 * a);
            

            int i = 0;

            while (i >=0)
            {
                i++;
                Random rnd = new Random();
                int root1 = rnd.Next(0,11);
                int root2 = rnd.Next(-10,1);

                Console.WriteLine("{0}. iteration -  Root1: {1}   Root2:{2}", i, root1, root2);
                if (firstRoot == root1 && secondRoot == root2)
                {
                    break;
                }

                

            }
              Console.ReadKey();
        }
    }
}
