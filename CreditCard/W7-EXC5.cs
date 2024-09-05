using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC5
{
    internal class Program
    {

        static long TakeCardNumber()
        {
            Console.Write("Enter your credit card number:");
            long cardNumber=long.Parse(Console.ReadLine());
            return cardNumber;
        }
        static bool CheckLength(long number)
        {
            int counter = 1;

            while (number / 10 != 0)
            {
                if(  (number/10) != 0)
                {
                    counter++;
                    number = number / 10;
                }     

            }
            if (counter == 16)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static int SumOfOdds(long number)
        {
            long cardNumber = number; ;
            int counter = 1;
            long sum = 0;

            while (number / 10 != 0)
            {
                if ((number / 10) != 0)
                {
                    counter++;
                    number = number / 10;
                }

            }

            number = cardNumber;
            if (counter % 2 == 0)
            {
                counter = counter / 2;
                while (counter>0)
                {
                    number=number / 10;
                    sum += number % 10;
                    number = number / 10;
                    counter--;
                }
            }
            else
            {
                counter = counter / 2;
                while (counter > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                    number = number / 10; 
                    counter--;
                    if (counter == 0)
                    {
                        sum += number % 10;
                    }
                }

            }
            return (int)sum;

        }
        static int SumOfEvens(long number)
        {

            long cardNumber = number; 
            int counter = 1;
            long sum = 0;
            int num = 0;

            while (number / 10 != 0)
            {
                if ((number / 10) != 0)
                {
                    counter++;
                    number = number / 10;
                }

            }

            number = cardNumber;

            if (counter % 2 == 0)
            {
                counter = counter / 2;
                while (counter > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                    number = number / 10;
                    counter--;
                }

            }
            else
            {
                counter = counter / 2;
                while (counter > 0)
                {
                    number = number / 10;
                    sum += number % 10;
                    number = number / 10;
                    counter--;
                    Console.WriteLine(sum);

                }
            }

            num = 0;
            sum *= 2;
            while ((sum / 10) != 0)
            {
                num += (int)sum % 10;
                sum = sum / 10;
                num += (int)sum;
                sum = num;
                num = 0;
            }

            return (int)sum;
        }
       
        static bool IsDivisible(int sumOfDigits, int sumOfOdds)
        {
            int sum = sumOfDigits + sumOfOdds;
            if ((sum / 10) != 0)
            {
                return true;
            }
            else
            {
               return  false;
            }
        }
        
        static string BelongsTo(long number)
        {
            long cardNumber = number;
            int counter = 1;

            while (number / 10 != 0)
            {
                if ((number / 10) != 0)
                {
                    counter++;
                    number = number / 10;
                }

            }

            long digit = 1;
            while (counter >2)
            {
                digit *= 10;
                counter--;
            }

            cardNumber /= digit;
            if (cardNumber == 43)
            {
                return " a Visa logo";
            }else if (cardNumber == 42)
            {
                return "a MasterCard logo";
            }
            else
            {
                return "no logo";
            }
            
            
        }
        static void Main(string[] args)
        {
            long number = TakeCardNumber();
           bool lengthFlag = false;
            if (CheckLength(number))
            {
                lengthFlag = true;
            }
            int  oddResult = SumOfOdds(number);
            int  evenResult = SumOfEvens(number);

            bool divisible = false;
            if (IsDivisible(evenResult, oddResult))
            {
                divisible = true;
            }

            if(lengthFlag && divisible)
            {
                Console.WriteLine("Credit card number is valid! This car has "+BelongsTo(number));
            }
            else
            {
                Console.WriteLine("Credit card is no valid!");
            }
            Console.ReadLine();

        }

    }
}
