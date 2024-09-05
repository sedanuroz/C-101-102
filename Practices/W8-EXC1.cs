using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC1
{
    internal class Program
    {
        static int MaximumFrequency(string str)
        {
            int count = 0;
            int num;
            char character ;
            int max = int.MinValue;
            for (int i = 0; i < str.Length; i++)
            {
                num = str.IndexOf(str[i]);
                character = str[num];
                for (int j = 0; j < str.Length; j++)
                {
                    if (character == str[j])
                    {
                        count++;
                    }
                }
                if(count > max)
                {
                    max = count;
                }
                count = 0;
            }
            return max;
            
        }
           static string SortCharacters(string str)
         {
             string[] words = str.Split(' ');
             string temp;
             string sentence = "";

             for (int i = 0; i < words.Length;i++)
             {

                 for (int j = 0; j < words.Length-1; j++)
                 {
                     if ((words[j].CompareTo( words[j+1])==1))
                     {
                        temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                     }
                 }
             }

            str = "";
            for (int i = 0; i < words.Length; i++)
            {
                str+=words[i]+" ";
                if (i == words.Length - 1)
                {
                    str += words[i];
                }
            }



                return str;
         }

 
 
 
        

        static string ReverseStringsInOddLength(string str)
        {
            string[] words = str.Split(' ');
            string temp;
            string sum = "";
           
           
            for(int i = 0; i < words.Length; i++)
            {
                temp = words[i];
                if (i == words.Length - 1)//noktadan dolayı bunu yapıyoruz yoksa son kelimeye . dahilmiş gibi oluyor (ters cevirmeyi yanlış yapıyor)
                {
                    if ((temp.Length - 1) % 2 != 0)
                    {
                        for (int j = (temp.Length) - 2; 0 <= j; j--)
                        {
                            sum += temp[j];
                        }
                        sum += temp[temp.Length - 1];
                    }
                    else
                    {
                        for (int j = 0; j < temp.Length; j++)
                        {
                            sum += temp[j];
                        }
                    }
                }
                else if (temp.Length % 2 != 0)
                {
                    for (int j = (temp.Length) - 1; 0 <= j; j--)
                    {
                        sum += temp[j];
                    }
                    sum += " ";
                }
                else
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        sum += temp[j];
                    }
                    sum += " ";
                }



            }
            return sum;
        }

        static string RemoveDuplicates(string str)
        {
           
          
            for (int i = 0; i < str.Length; i++)
            {
               int num=str.IndexOf(str[i]);
                for(int j = 0; j < str.Length; j++)
                {
                    if (str.IndexOf(str[i], num + 1) != -1)
                    {
                        str = str.Remove(num, 1);

                    }
                }
            }
            return str;
        }
      

        static bool IsIsogram(string str)
        {
            bool isisogram = true;
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
              
                for(int j = 0; j < str.Length; j++)
                {
                    if (i != j  && str[i] == str[j])
                    {
                        isisogram = false;
                    }
                }
            }
            if (isisogram)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static bool IsIsogramBySecondDegree(string str)
        {
            int count = 0;
            bool isisogram = true;
            str=str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                count++;

                for (int j = 0; j < str.Length; j++)
                {
                   
                    if (i != j && str[i] == str[j])
                    {
                        count++;
                    }
                }
                if (count != 2)
                {
                    isisogram = false;
                   
                }
                count = 0;
            }

            if (isisogram)
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
            
            Console.WriteLine(MaximumFrequency("holocaust"));
            Console.WriteLine(SortCharacters("David’s parents have three sons"));
            Console.WriteLine(ReverseStringsInOddLength("There is a story house in which everything is yellow."));
            Console.WriteLine(RemoveDuplicates("abbssatsbbs"));
            Console.WriteLine(IsIsogram("dialogue"));
            Console.WriteLine(IsIsogram("people"));
            Console.WriteLine(IsIsogramBySecondDegree("Vivienne"));
            Console.WriteLine(IsIsogramBySecondDegree("dialogue"));

          
            Console.ReadLine();
        }
    }
}
