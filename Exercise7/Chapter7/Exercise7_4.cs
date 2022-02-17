using System;

/*Exercise 7.4.The purpose of this exercise is to review encapsulation and generalization.
1. Encapsulate the following code fragment, transforming it into a method that takes a
string as an argument and that returns the final value of count.
2. In a sentence or two, describe what the resulting method does (without getting into
the details of how).
--This method takes a string and compares the values of each character in the string.  
    It adds to a counter every time the '(' open parentheses character appears in the string,
    and reduces the counter every time the ')' close parentheses character appears in the string.  
3.Now that you have generalized the code so that it works on any string, what could
you do to generalize it more?
--You could generalize the character that you're looking for and instead use the specific index number of the character in the string.  
    e.g. you want to increase the counter each time the s[0] character appears, and decrease every time the s[len -1] character appears
 */

namespace Chapter7
{
    public class Exercise7_4
    {
        public static void Exercise7_4Method(string str)
        {
            string s = str;
            int len = s.Length;
            int i = 0;
            int count = 0;

            while (i < len)
            {
                char c = s[i];
                if (c == s[0])
                {
                    count++;
                }
                else if (c == s[len-1])
                {
                    count--;
                }
                i++;
            }
            Console.WriteLine(count);
        }
    }
}

