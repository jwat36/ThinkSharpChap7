using System;

/*
 Exercise 7.10. A word is said to be \abecedarian" if the letters in the word appear in
alphabetical order. For example, the following are all 6-letter English abecedarian words.
abdest, acknow, acorsy, adempt, adipsy, agnosy, befist, behint, beknow, bijoux,
biopsy, cestuy, chintz, deux, dehors, dehort, deinos, diluvy, dimpsy
1. Describe a process for checking whether a given word (string) is abecedarian, assum-
ing that the word contains only lower-case letters. Your process can be iterative or
recursive.
--Take in a string input then store it in a char array.  Create a loop to check if each character is greater than the preceding and, if so, return true.  Else, return false.
2. Implement your process in a method called IsAbecedarian.
*/
namespace Chapter7
{
    public class Exercise7_10
    {
        public static bool IsAbcedarian(string str)
        {
            str = str.ToLower(); //convert string to all lower case
            char[] chars = str.ToCharArray(); //store string in char array
            Console.WriteLine(chars.Length);

            for (int i = 0; i < chars.Length - 1; i++) //iterate through all items in the char array
            {
                if (chars[i] > chars[i + 1]) { return false; } //if any character is greater than the next char in the array then the loop stops and returns false

            }
            return true; //if all characters are sequentially larger, then the loop returns true and the function validates the string is abcedarian
        }
    }
}
