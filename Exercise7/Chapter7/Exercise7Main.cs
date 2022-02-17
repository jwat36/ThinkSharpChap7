using System;

/*
Exercise 7.4. The purpose of this exercise is to review encapsulation and generalization.
Exercise 7.5. The point of this exercise is to explore types and fill in some of the details that aren't covered in the chapter.
Exercise 7.6. What is the output of this program? Describe in a sentence what Mystery does (not how it works).
Exercise 7.10. A word is said to be "abecedarian" if the letters in the word appear in alphabetical order. For example, 
the following are all 6-letter English abecedarian words. abdest, agnosy, biopsy, deux, dimpsy
  1. Describe a process for checking whether a given word (string) is abecedarian, assuming that the word contains only lower-case letters. 
    Your process can be iterative or recursive.
  2. Implement your process in a method called IsAbecedarian.
*/
namespace Chapter7
{
    public static class Exercise7Main
    {

            
        public static void Main(string[] args)
        {
            Exercise7_4.Exercise7_4Method("Whatever");
            Test_Exercise7_5.Test();
            Exercise7_6.Mystery("Allen");
            Exercise7_10.IsAbcedarian("ABC");
        }

 

    }
}
