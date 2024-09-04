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
            int temperature, wind, humidity, formulaRain;
            Console.WriteLine("Enter temperature value :");
            temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter wind value :");
            wind=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter humudity value :");
            humidity = int.Parse(Console.ReadLine());
            formulaRain = (temperature - wind) * (temperature - wind) - humidity;
            string possibility = (formulaRain >= 575) ? "there will not be rain" :  " there will be rain";
            Console.WriteLine("The result is {0} and {1}", formulaRain, possibility);
            Console.ReadKey();

        }
    }
}
