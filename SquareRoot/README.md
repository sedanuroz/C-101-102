In this question, you will take an integer from user as n (between 0 and 100) to find its
approximate square root.
• Your program should give an error and ask for another integer if the input is smaller than
0 and greater than 100.
• There is a method called Babylonian that is used on finding square root of a number
approximately.
• Babylonian method works as stated below:
a. First, you will generate a random number between 0 and 100. Suppose we call this
integer as X0.
b. Then, you will calculate X1 as X1 = (X0 +
n
X0
) ⁄ 2
and X2 as X2 = (X1 +
n
X1
) ⁄ 2.

c. When Xn is closer to Xn+1 such that their two digits after comma is the same, Xn+1
becomes the approximate square root of integer n (you should continue calculating
X3,X4, ... until you reach the condition).
• You must print all X’s that you have found.


![image](https://github.com/user-attachments/assets/d2a90f1a-feb6-469c-9e3b-5eeb00e4993d)
