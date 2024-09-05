using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EXC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] array =
            {/*
                {2,8,3,7,9,5,4,1,6 },
                {6,9,1,8,4,2,5,3,7 },     doğru çözülmüş sudoku örneği
                {4,7,5,6,3,1,2,9,8 },
                {7,5,6,9,8,4,3,2,1 },
                {1,3,9,5,2,6,7,8,4 },
                {8,2,4,1,7,3,6,5,9 },
                {9,4,2,3,6,8,1,7,5 },
                {5,6,7,2,1,9,8,4,3 },
                {3,1,8,4,5,7,9,6,2 }*/

                {2,8,3,7,9,5,4,1,6 },
                {6,9,1,8,4,2,5,3,7 },
                {4,7,5,6,3,1,2,9,8 },
                {7,5,6,9,8,4,3,2,1 },
                {2,3,9,5,2,6,7,8,4 },
                {8,2,4,1,7,3,6,5,9 },
                {9,4,2,3,6,8,1,7,5 },
                {5,6,7,2,1,9,8,4,3 },
                {3,1,8,4,5,7,9,6,2 }
                
            };

            bool correct = true;

            for(int i = 0; i< array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
              //satır toplamı 45 olma durumu kontrolü

              int sumRow=0;
              for (int i = 0; i < array.GetLength(0); i++)
              {
                sumRow = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                  {
                      sumRow += array[i, j];

                  }
                  if (sumRow != 45)
                  {
                      Console.WriteLine("Sum of the row number {0} is not 45!",i+1);
                    correct= false;
                  }

              }


            //sütün toplamı 45 olma durumu kontrolü
            int sumColoum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sumColoum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sumColoum += array[j,i];

                }
                if (sumColoum != 45)
                {
                    Console.WriteLine("Sum of the coloum number {0} is not 45!", i + 1);
                    correct = false;
                }
              
            }

            /* blok toplamı 45 olma turumu kontrolü, baslangic degerleri  0,0  0,3  0,6
                                                                          3,0  3,3  3,6
                                                                          6,0  6,3  6,6*/


            int sum = 0, counterRow = 0, counterColoum = 0, counter = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)            //bu for döngüsüyle  00,30 ve 60 olan blokları taramış olacağız
                {
                    counter++;
                    sum += array[i, j];
                    if ((i + 1) % 3 == 0 && counter == 9)   //eğer i+1%3=0 olıursa demekki satirları gezerken bir bloğu tamamladı
                    {                                    //eğer counter 9 olmuşsa demekki bir bloktraki bütün elemanları saydı

                        if (sum != 45)
                        {
                            Console.WriteLine("Sum of the block that starts at [{0},{1}] indexes is not 45! ", counterRow, counterColoum);
                            correct= false;
                        }


                        counterRow += 3;
                        counter = 0;
                        sum = 0;
                        break;
                    }


                }
            }


            counterRow = 0; counterColoum +=3;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 3; j < 6; j++)            //bu for döngüsüyle  30,33 ve 63 olan blokları taramış olacağız
                {
                    counter++;
                    sum += array[i, j];
                    if ((i + 1) % 3 == 0 && counter == 9)   //eğer i+1%3=0 olıursa demekki satirları gezerken bir bloğu tamamladı
                    {                                        //eğer counter 9 olmuşsa demekki bir bloktraki bütün elemanları saydı

                        if (sum != 45)
                        {
                            Console.WriteLine("Sum of the block that starts at [{0},{1}] indexes is not 45! ", counterRow, counterColoum);
                            correct = false;
                        }

                        counterRow += 3;
                        counter = 0;
                        sum = 0;
                        break;
                    }


                }
            }



            counterRow = 0;
            counterColoum +=3;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 6; j < array.GetLength(1); j++)            //bu for döngüsüyle  06,36 ve 66 olan blokları taramış olacağız
                {
                    counter++;
                    sum += array[i, j];
                    if ((i + 1) % 3 == 0 && counter == 9)   //eğer i+1%3=0 olıursa demekki satirları gezerken bir bloğu tamamladı
                    {                                         //eğer counter 9 olmuşsa demekki bir bloktraki bütün elemanları saydı

                        if (sum != 45)
                        {
                            Console.WriteLine("Sum of the block that starts at [{0},{1}] indexes is not 45! ", counterRow, counterColoum);
                            correct = false;
                        }

                        counterRow += 3;
                        counter = 0;
                        sum = 0;
                        break;
                    }


                }
            }


            //satırlarda her sayıdan bir tane var mı kontrolü
            bool row = false;
            for (int a = 0; a < array.GetLength(0); a++)
            {
                row = false;
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    for (int c = 0; c < array.GetLength(1); c++)
                    {
                        if (b != c && array[a, b] == array[a, c])
                        {
                            row = true;
                            break;
                        }
                    }
                }
                if (row)
                {
                    Console.WriteLine("Row {0} does not contain numbers from 1 to 9.", a + 1);
                    correct = false;
                }
              
            }
           
                //sütünda her sayıdan bir tane var mı kontrolü;
                bool column = false;
            for (int a = 0; a < array.GetLength(1); a++)
            {
                column = false;
                for (int b = 0; b < array.GetLength(0); b++)
                {
                    for (int c = 0; c < array.GetLength(0); c++)
                    {
                        if (b != c && array[b, a] == array[c, a])
                        {
                            column = true;
                            break;
                        }
                    }
                }
                if (column)
                {
                    Console.WriteLine("Column {0} does not contain numbers from 1 to 9.", a + 1);
                    correct = false;
                }
                
            }

            /* bloklarda her sayıdan bir tane olma durumu kontrolü, baslangic degerleri  0,0  0,3  0,6
                                                                                         3,0  3,3  3,6
                                                                                         6,0  6,3  6,6
           


            */
            int[] arr1 = new int[9], arr2 = new int[9], arr3 = new int[9], arr4 = new int[9], arr5 = new int[9], arr6 = new int[9], arr7 = new int[9], arr8 = new int[9], arr9 = new int[9];
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0, count8 = 0, count9 = 0;


            for (int a = 0; a < array.GetLength(0); a++)                         //Hocam ,evet biliyorum bu kısım çok uzun oldu (:
            {                                                                    //Ama ne yazık ki bloklarda her sayıdan bir tane olma kontrolünü kısa bir çözüm ile yapamadım.   
                for (int b = 0; b < array.GetLength(1); b++)                     //Ödevimi de o kısmı tamamlanmamış bir şekilde atmak istemedim. 
                {                                                                //Bu nedenle çözümüm uzun oldu.
                                                                                 //Ama doğru çalışıyor :)
                    if (a < 3)
                    {
                                                                                 //Her bir bloğu bir array a tanımladım ve o şekide unic olma durumunu kontrol ettirdim.

                        if (b < 3)
                        {
                            arr1[count1] = array[a, b];
                            count1++;

                        }
                        else if (b < 6)
                        {
                            arr2[count2] = array[a, b];
                            count2++;
                        }
                        else
                        {
                            arr3[count3] = array[a, b];
                            count3++;
                        }
                    }
                    else if (a < 6)
                    {


                        if (b < 3)
                        {
                            arr4[count4] = array[a, b];
                            count4++;
                        }
                        else if (b < 6)
                        {
                            arr5[count5] = array[a, b];
                            count5++;
                        }
                        else
                        {
                            arr6[count6] = array[a, b];
                            count6++;
                        }
                    }
                    else
                    {

                        if (b < 3)
                        {
                            arr7[count7] = array[a, b];
                            count7++;
                        }
                        else if (b < 6)
                        {
                            arr8[count8] = array[a, b];
                            count8++;
                        }
                        else
                        {
                            arr9[count9] = array[a, b];
                            count9++;
                        }
                    }
                }
            }

            counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr1[i] == arr1[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [0,0] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }
            counter = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr2[i] == arr2[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [0,3] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }

            counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr3[i] == arr3[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [0,6] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }

            counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr4[i] == arr4[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [3,0] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }

            counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr5[i] == arr5[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [3,3] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }
            counter = 0;


            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr6[i] == arr6[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [3,6] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }
            counter = 0;


            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr7[i] == arr7[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [6,0] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }
            counter = 0;


            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr8[i] == arr8[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [6,3] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }
            counter = 0;


            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr9[i] == arr9[j])
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Block that starts at [6,6] indexes does not contain numbers from 1 to 9.");
                correct = false;
            }

            if (correct)
            {
                Console.WriteLine("Sudoku is solved correctly");
            }

            Console.ReadKey();
        }
    }
}
