In this question, you are asked to divide students into groups based on their grades.
• You will be given 3 different arrays to indicate groups.
• You will be given 5 different student’s info about their group and ID.
• Students take an exam which consist of 10 questions.
• Each student gets different score from different questions.
• For each student, you are asked to find closest group based on their grade by looking their
Euclidian distance.

![image](https://github.com/user-attachments/assets/be86159b-f095-4958-b3c6-4dfafbd029ec)

As you can figure it out yourself, Group 1 has lower scores than Group 2 and Group 2 has
lower scores than Group 3. This indicate that a student with lower scores should be in
Group 1, a student with average scores should be in Group 2 and a student with high
scores should be in Group 3.
• You will present these groups as different single dimensional arrays.

![image](https://github.com/user-attachments/assets/b51687e3-7164-4e1f-9d19-046d5c5d8dec)

Table in Figure 5 has 11 columns, first column indicates student’s ID, and the other 10
columns indicate the grades that a student gets from each question.
• As we stated before, you need to calculate Euclidian distance between each student and
groups and find the smallest distance (minimum difference of grades) and print it.
• To find Euclidian distance between a student and a group, you need to substract the grades
of each question, take the 2nd power of the it and sum it. Then you need to take the square
root of the summation.
• You can search for Euclidian Distance on the web for more info.

![image](https://github.com/user-attachments/assets/7afc302c-dc56-4eff-8636-3ab13be3add4)
