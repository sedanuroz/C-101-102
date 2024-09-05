For this question, you are asked to create different methods to do different jobs.
➢ static int MaximumFrequency(string str) (6)
➢ static string SortCharacters(string str) (6)
➢ static string ReverseStringsInOddLength(string str) (6)
➢ static string RemoveDuplicates(string str) (6)
➢ static bool IsIsogram(string str) (6)
➢ static bool IsIsogramBySecondDegree(string str) (6)

• MaximumFrequency method takes a string as a parameter and returns the most frequent
letter’s frequency. You must use IndexOf method.
o Input: “holocaust” -> Output: 2
• SortCharacters method takes a string (sentence) as a parameter and returns a string which
contains the words in alphabetical order. For this question, since you can compare words
with each other, use Bubble Sort to sort the string. You must use Split method.
o Input: “David’s parents have three sons” -> Output: “David’s have parents sons
three”

• ReverseStringsInOddLength method takes a string (sentence) as a parameter and returns a
string where only the words that have odd length is reversed. You must use Split method.
o Input: “There is a story house in which everything is yellow.” -> Output: “erehT is
a yrots esuoh in hcihw everything is yellow.”

• RemoveDuplicates method takes a string as a parameter and returns a string where the
occurrences of a character is deleted. Keep in mind that the last occurrence of the

character must stay in the string and the other occurrences should be deleted. You must
use IndexOf methods.
o Input: “abbssatsbbs” -> Output: “atbs”
• IsIsogram method takes a string as a parameter and returns true if the given string is
Isogram, returns false if the given string is not Isogram. Isogram string is a string where
all the characters of the string is different from each other.
o Input: “dialogue” -> Output: true
o Input: “people” -> Output: false
• IsIsogram method takes a string as a parameter and returns true if the given string is
Isogram string by a second degree, returns false if the given string is not Isogram string by
a second degree. Isogram string by a second degree is a string where each character of the
string occurs two times in the string.
o Input: “Vivienne” -> Output: true
o Input: “dialogue” -> Output: false
