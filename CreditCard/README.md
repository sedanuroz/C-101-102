In this question, you are asked to create several methods to check if a given credit card
number is valid and find which institution logo it has.
• Signatures of the methods are given below:
o static long TakeCardNumber()
o static bool CheckLength(long number)
o static int SumOfOdds(long number)
o static int SumOfEvens(long number)
o static bool IsDivisible(int sumOfEvens, int sumOfOdds)
o static string BelongsTo(long number)
• TakeCardNumber() method takes a card number from user (long variable type) and
returns the number.
• CheckLength() method takes the card number and checks if its length is 16 or not. If the
length is 16, return true. If not, return false.
• SumOfOdds() method takes the card number and sums up the digits that are in the odd
places. Acknowledge that the leftmost digit is the first digit. Return the result.
• SumOfEvens() method takes the card number and sum up the digits that are in the even
places. Acknowledge that the leftmost digit is the first digit. Then, double the number. If
the doubled number is a two-digit number, sum up the digits, repeat this process until
number becomes a one-digit number. Then, return the number.
• IsDivisible() method takes two integer parameters and sum up the parameters. If the result
is divisible by 10, it returns true. If not, return false.
• WhichLogo() method takes the card number and checks which logo is on the card. If the
number starts with 43, return “a Visa logo”. If the number starts with 42, return “a
MasterCard logo”. If the card number does not start with neither of these, return “no
logo”.

![image](https://github.com/user-attachments/assets/87191e8e-cddb-484c-bcf5-1a96cd098b35)
