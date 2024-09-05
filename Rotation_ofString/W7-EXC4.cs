using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC4
{
    internal class Program
    {
        
        static bool IsRotation(string str1,string str2)
        {
            int ordınal = 0;
            int count = 0;
            
          
            if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {

                for (int i = 0; i < str1.Length; i++)
                {
                    for (int j = i; j < str1.Length; j++)
                    {
                        if (str1[i] == str2[j] && str1[i + 1] == str2[j + 1] && str1[i + 2] == str2[j + 2])
                        {

                            ordınal = j;//str1 in kaçıncı harfinde aynı harfe rastladığını bulduk

                            count++;

                        }
                        if (count != 0)
                        {
                            break;
                        }

                    }

                    if (count != 0)
                    {
                        break;
                    }
                }

              
                int a = (str1.Length - (ordınal - 1));   //string toplayacak str1 için;   a dan başlayacak length bitene kadar
                int b = ordınal - 1;                     //string toplayacak str2 için     0 dan başlayacak b ye kadar
                string strA1 = "";
                string strB1 = "";
                for (int i = a; i < str1.Length; i++)     //str1 a dan lengte kadar dogrumu
                {
                    strA1 += str1[i];
                }
                for (int i = 0; i < b; i++)   //str2 o dan b ye kadar dogrumu 
                {
                    strB1 += str2[i];
                }

                a = (str1.Length - (ordınal - 1));
                b = ordınal - 1;
                string strA2 = "";
                string strB2 = "";

                for (int j = 0; j < a - 1; j++)   //str1  0 dan a ya kadar dogrumu
                {
                    strA2 += str1[j];
                }
                for (int j = ordınal; j < str2.Length; j++)// str2 ordınal  dan lengthe dogrumu 
                {
                    strB2 += str2[j];
                }

                if(strA1==strB1  && strA2 == strB2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }



        static void Main(string[] args)
        {
            string str1 ="first solve the problem then write the code";
            string str2 ="write the code first solve the problem then";
            if (IsRotation(str1, str2))
            {
                Console.WriteLine("Str1 is a rotation of str2 or vice versa");
            }
            else
            {
                Console.WriteLine("Srt1 is not a rotation of str2");
            }
            Console.ReadLine();
        }
    }
}
