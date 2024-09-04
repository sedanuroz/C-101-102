using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int firstRandomForCharactersAmount=0, secondRandomForCharactersAmount=0;

            Random rnd = new Random();
            Console.Write("Enter the number of sentences:");
            number=int.Parse(Console.ReadLine());

            
            while (number>0)
            {
               
                
                    secondRandomForCharactersAmount= firstRandomForCharactersAmount ;
                    firstRandomForCharactersAmount = rnd.Next(3, 11);

                    if(firstRandomForCharactersAmount== secondRandomForCharactersAmount)
                    {
                        if (firstRandomForCharactersAmount == 10)
                        {
                            firstRandomForCharactersAmount=-1;
                        }
                        firstRandomForCharactersAmount += 1;
                    }


                int a = 0;
                while (a == 0)
                {
                    int randomForCharactersType = rnd.Next(97, 123);
                    int r = randomForCharactersType;
                    if(r==97 || r==101 || r==105 || r==111 || r == 117)
                    {
                        a = 0;
                    }
                    else
                    {
                        Console.Write((char)randomForCharactersType);
                        a++;

                    }

                }




                int counter = 2;
                while (counter <= firstRandomForCharactersAmount)
                {
                   
                   int  randomForCharactersType = rnd.Next(97, 123);
                    Console.Write((char)randomForCharactersType);
                    counter++;


                }

                Console.WriteLine("\n");
                number--;

                    
                             
            }
            Console.ReadKey();

        }
    }
}
