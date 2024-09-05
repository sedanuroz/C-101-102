In this question, you are asked to print connected words based on some rules.
• There is a .txt file in the homework’s attachments that contains 3000 English words in a
string variable. The words are separated by comma, alphabetically. Use that string to
complete this exercise.
• The rule for two words to be connected is that the last two letters of a word must be the
same with the first two letters of the other word. For example: problem->emotion->onion.
• First, you will shuffle the words since it is alphabetically ordered so that it should not give
the same connected words each time. You must do 1000 shuffles.
• Then, find a starting index(0-3000) randomly and choose the starting word using the
index. Append the word to a StringBuilder object.
• Subtract the last two letters of the starting word and check if there is a word in the list that
starts with these two letters. If there is, if the word is not used before, append the second
word to the StringBuilder object and repeat these steps until there are no words left that
starts with previous word’s last two letters.
• The reason why we do not select the word that we used before is:
o online->neon->online->neon->.....
• Rules:
o You must use Split method to separate words from each other.
o You must use Substring method to extract first two letters or last two letters of the
words.
o You must use Equals method to check the first two and last two letters of the
words are the same.
o You must use IndexOf method to check if the word is used or not. To do so, you
must check if the StringBuilder object has that word or not. Convert the
StringBuilder object to string using ToString method. Then check if the word
exists using IndexOf method.
o Keep in mind that there are couple of words that has 1 or 2 letters such as “a”, “e”,
“oh”, “eh”. While searching for a new word, do not select words shorter than 3
letters.

• You can modify your output based on Figure 1.

![image](https://github.com/user-attachments/assets/e17525cf-f27a-4541-994b-7943a3189c00)
