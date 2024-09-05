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
            int[] arrSecond1 = new int[65];        // i created array for first lamp^s second
            for(int i=0; i<arrSecond1.Length; i++)
            {
                arrSecond1[i] = i + 1;
            }

            int[] arrSecond2 = new int[65];                // i created array for second lamp^s second
            for (int i = 0; i < arrSecond1.Length; i++)
            {
                arrSecond2[i] = i + 1;
            }


            string[] arr1 = new string[65];              //i created string for first lamp
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arrSecond1[i] <= 35)
                {
                    arr1[i] = "green";
                }else if (arrSecond1[i] <= 45)
                {
                    arr1[i] = "yellow";
                }
                else 
                {
                    arr1[i] = "red";
                }
            }

            string[] arr2 = new string[65];                    //i created string for first lamp

            for (int j = 0; j < arr2.Length; j++)
            {
                if (arrSecond2[j] <= 10)
                {
                    arr2[j] = "red";
                }
                else if (arrSecond2[j] <= 30)
                {
                    arr2[j] = "green";
                }
                else
                {
                    arr2[j] = "yellow";
                }
            }

              

                 for(int s = 0; s < 65; s++)//i have written the possibilities that will hapen with each new value(with for loop)increasing with the if loops
                 {
                    Console.WriteLine("State of the lamb1:{0}  ,lamb2:{1}  at time {2}\n", arr1[s], arr2[s], arrSecond1[s]);
                    if (arr1[s] =="green" && arr2[s] == "green")
                    {
                        Console.WriteLine("There might be an accient at time {0}\n", arrSecond1[s]);
                    }
                    if(arr1[s] == "green" && arr2[s] == "yellow")
                    {
                        Console.WriteLine("There might be an accient at time {0}\n", arrSecond1[s]);
                    }
                    if (arr1[s] == "yellow" && arr2[s] == "green")
                    {
                        Console.WriteLine("There might be an accient at time {0}\n", arrSecond1[s]);
                    }
                    if (arr1[s] == "yellow" && arr2[s] == "yellow")
                    {
                        Console.WriteLine("There might be an accient at time {0}\n", arrSecond1[s]);
                    }
                    if (arr1[s] == "red" && arr2[s] == "red")
                    {
                        Console.WriteLine("There might be an accient at time {0}\n", arrSecond1[s]);
                    }
                 }
                


                Console.ReadKey();
            

        }
    }
}