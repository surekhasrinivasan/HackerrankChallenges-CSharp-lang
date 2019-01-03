using System;

namespace StringChallenge
{
    // Given a string find the first non-repeating character and return the character, if not return underscore
    class Program
    {
        static void Main()
        {
            //char firstNonRepeatChar = firstNonRepeatingCharacter("abcdabc");
            //Console.WriteLine(firstNonRepeatChar);

            Console.WriteLine("Enter a string: ");
            string str1 = Console.ReadLine();

            char firstNonRepeatChar = firstNonRepeatingCharacter(str1);
            Console.WriteLine(firstNonRepeatChar);
        }

        // function loops through the string and returns first non-repeating character 
        public static char firstNonRepeatingCharacter(string str)
        {
            char letter;
            bool seen = false;

            for (int i = 0; i < str.Length; i++)
            {
                letter = str[i];
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == letter)
                    {
                        if (seen)
                        {
                            seen = false;
                            break;
                        }
                        seen = true;
                    }
                }

                if (seen)
                {
                    //Console.WriteLine(letter); // return
                    return letter;
                }
            }
            //Console.WriteLine('_');
            return '_';
        }
    }
}