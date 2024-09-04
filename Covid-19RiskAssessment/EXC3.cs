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
            int age, symptomsCov19, testResult, cov19History, result;
            
            Console.Write("Select your age interval \n 1) 18-40 \n 2) 40-65 \n 3) 65+\n Your choice: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Have you experienced COV19 Symptoms?\n 1)Yes \n 2)No \n Your choice: ");
            symptomsCov19 =int.Parse(Console.ReadLine());

            Console.Write("What is your COV19 test result?\n 1) Positive \n 2) Negative \n Your choise:  ");
            testResult =int.Parse(Console.ReadLine());

            Console.Write("Have you been infected with Cov19 before ? \n 1) Yes \n 2) No \n your choise: ");
            cov19History =int.Parse(Console.ReadLine());

           

            switch (age)
            {
                case 1: age = 5 ;break;
                case 2: age = 15;break;
                case 3: age = 25;break;
            }

            switch (symptomsCov19)
            {
                case 1:symptomsCov19 = 25;break;
                case 2:symptomsCov19 = 0;break;
            }

            switch (testResult)
            {
                case 1:testResult = 25;break;
                case 2:testResult = 0;break;
            }

            switch (cov19History)
            {
                case 1:cov19History = 0;break;
                case 2:cov19History = 25;break;
            }


            result = age + symptomsCov19 + testResult + cov19History;
            Console.WriteLine("Total score of the assesment is:{0}", result);


            if (result < 25)
            {
                Console.WriteLine("Patient should rest at home.");
            }
            else if (result < 50)
            {
                Console.WriteLine("Patient can rest at home with medicine.");
            }
            else if(result < 75)
            {
                Console.WriteLine("Patient should be controlled under the doctor.");
            }
            else
            {
                Console.WriteLine("Patient should be intubated immediately.");
            }


            Console.ReadLine();

        }
    }
}
