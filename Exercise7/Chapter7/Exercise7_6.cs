using System;

/*
 * Exercise 7.6. What is the output of this program? Describe in a sentence what Mystery
does (not how it works).
--The output is:
4 n
3 e
2 l
1 l
0 A
nellA
This method takes a string, counts the length, then builds a string iteratively by looping through each character in the string, 
printing the numeric index and character in reverse order, then returns the reversed string.

 */
namespace Chapter7
{
    public static class Exercise7_6
    {
        public static string Mystery(string s)
        {
            int i = s.Length - 1;
            string total = "";
            while (i >= 0)
            {
                char ch = s[i];
                Console.WriteLine(i + " " + ch);
                total = total + ch;
                i--;
            }
            return total;
        }
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(Mystery("Allen"));
        //}
    }
}

