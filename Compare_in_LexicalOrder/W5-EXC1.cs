using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first, second;
            Console.Write("Enter the first string:");
            first = Console.ReadLine();
            Console.Write("Enter the second string:");
            second = Console.ReadLine();

            
            for(int i = 0; i < first.Length; i++)
            {
                
                if (first[i] != second[i])
                {
                    if((int)first[i] < (int)second[i])
                    {
                        Console.WriteLine("First string comes before second string.");
                       
                    }
                    else
                    {
                        Console.WriteLine("Second string comes before first string.");
                        
                    }
                    break;
                   
                }
                
                
            }
            Console.ReadKey();
        }
    }
}
