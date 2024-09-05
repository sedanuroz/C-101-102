using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC3
{
    internal class Program
    {
        static string ConvertToLowercase(string str)
        {
            string temp = "";
           
            for(int i= 0; i < str.Length; i++)
            {
                if (str[i] < 97)
                {
                    char a =(char)( (int)str[i] + 32 );
                   temp+= a;


                }
                else
                {
                    temp += str[i];

                }

            }
                    
           
            return temp;
        }

        static string ConvertToUppercase(string str)
        {
            string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >97)
                {
                    char a = (char)((int)str[i] - 32);
                    
                    temp += a;
                }
                else
                {
                    temp += str[i];

                }
            }

            return temp;
        }
     
        static bool IsEqual (string str1,string str2)
        {
            if (str1 == str2)
            {
                return true;
            }
            else
            {
                return false;
            }

        
        }
        
        static char SecondMostFrequentLetter(string str)
        {
            int counter = 1;
            int max1=int.MinValue;
            int max2=int.MinValue;

            char theMostLetter=' ' ;
            char secondMostLetter=' ' ;
            for(int i=0; i<str.Length; i++) //en çok tekrar eden harf 
            {
                for(int j = i + 1; j < str.Length; j++)
                {

                    if (str[i] == str[j])
                    {
                        counter++;

                    }                  
                }
              
                if (counter > max1)
                {
                    theMostLetter = str[i];
                    max1 = counter;
                }
                counter = 1;
            }

            counter = 1;
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == theMostLetter)
                    {
                        break;
                    }
                    else
                    {
                        if (str[i] == str[j])
                        {
                            counter++;

                        }
                    }
                }
               if(counter>max2  && counter < max1)
                {
                    max2 = counter;
                    secondMostLetter = str[i];
                }
                counter = 1;

            }
          
            return secondMostLetter ;
        }

        static bool IsContain(string str1,string str2)
        {
            int count = 0;
            string str = "";
            for (int i = 0; i < str1.Length; i++)
            {

                if (str1[i] == str2[count])
                {
                    str += str1[i];
                    count++;
                    while (count < str2.Length)
                    {
                        str += str1[i + count];
                        count++;


                    }
                    break;
                }

            }
            if (str == str2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToLowercase("YouTube"));
            Console.WriteLine(ConvertToUppercase("YouTube"));

            if (IsEqual("youtube","youtube"))
            {
                Console.WriteLine("Strings are equal!");
            }
            else
            {
                Console.WriteLine("Strings are not equal!");
            }
            Console.WriteLine(SecondMostFrequentLetter("aaabbbbccccc"));
            if (IsContain("Youtube", "tube"))
            {
                Console.WriteLine("Str1 contains str2!");
            }
            else
            {
                Console.WriteLine("Str1 does not contains str2!");
            }
            Console.ReadLine();
        }
    }
}
