using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent, lowestStudent ="a" ,highestStudent="b";
            int numberOfStudent = 7, gradeOfStudent, highestGrade = 0,lowestGrade=100 ;

            while(numberOfStudent > 0)
            {
                numberOfStudent--;
                Console.Write("Enter the student's name :");
                nameOfStudent = Console.ReadLine();
                Console.Write("Enter the student's grade:");
                gradeOfStudent = int.Parse(Console.ReadLine());

               while(gradeOfStudent > 100 || gradeOfStudent < 0)
                {
                    Console.WriteLine("ERROR!!!\nGrades must be between 0 and 100.");
                    Console.Write("Enter the student's grade again:");
                    gradeOfStudent = int.Parse(Console.ReadLine());
                }


               
                
                if (highestGrade < gradeOfStudent)
                {
                    highestGrade = gradeOfStudent;
                    highestStudent = nameOfStudent;
                }else if(lowestGrade > gradeOfStudent)
                {
                    lowestGrade=gradeOfStudent;
                       lowestStudent = nameOfStudent;
                }

            }

            Console.WriteLine("Lowest score belongs to {0}",lowestStudent);
            Console.WriteLine("Highest score belongs to {0}",highestStudent);
            Console.ReadKey();
          
        }
    }
}
