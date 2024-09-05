In this question, you are asked to create some of the Math library’s methods.
• Method signatures are given below:
o static int Min(int number1, int number2)
o static int Max(int number1, int number2)
o static int Pow(int number, int exponent)
o static double Sqrt(int number)
o static void PrintRootsOfEquation(int a, int b, int c)
• Min() method takes two positive integer parameters and returns the smaller number. The
method must check if the numbers are positive numbers. If not, return -1. If numbers are
equal, return 0.
• Max() method takes two positive integer parameters and returns the greater number. The
method must check if the numbers are positive numbers. If not, return -1. If numbers are
equal, return 0.
• Pow() method takes two positive integer parameters as base and exponent and returns a
number which is in the form of numberexponent

. The method must check if the numbers

are positive numbers. If not, return -1.
Figure 1

• Sqrt() method takes a positive integer parameter and returns the square root of the
parameter. The method must check if the number is positive. If not, return -1. You must
use your answer that you gave in Question 7 in Homework-4 for square rooting algorithm.
Data type of the parameter is integer, if you want to pass a double argument, you can
convert your double value to int via type casting. -(int) doubleValue-
• PrintRootsOfEquation() method takes three integer parameters to indicate coefficients of a
quadratic equation. You can create your equation using a, b and c as ax

2 + bx + c = 0.
Keep in mind that these coefficients can be negative too. Hence, do not have to check if
they are positive or negative. First, find delta of the equation. If delta is negative (roots are
imaginary) print an error. If delta is positive, keep finding roots of the equation. Use your
Pow() and Sqrt() methods when you need it. After you find the roots, print the roots.
• As we did not state in this question, do not take inputs from user. You can pass necessary
parameters to your methods manually.

![image](https://github.com/user-attachments/assets/cf610b3b-cbf9-4f4f-a5ea-f37a368fdc91)
