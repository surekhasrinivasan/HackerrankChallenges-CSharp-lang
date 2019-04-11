using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCountVowelsAndConsonants
{
    // Program to count the number of Vowels and Consonants in a string 
    class Program
    {
        static void Main(string[] args)
        {
            char[] sentence = new char[100];
            
            int i, vowels = 0, consonants = 0, specialChars = 0, lengthOfTheString;

            Console.WriteLine("Enter the length of the string to count its vowels and consonants: \n");
            lengthOfTheString = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < lengthOfTheString; i++)
            {
                sentence[i] = Convert.ToChar(Console.Read());
            }
            for (i = 0; sentence[i] != '\0'; i++)
            {
                if(sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u' ||
                    sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] == 'I' || sentence[i] == 'O' || sentence[i] == 'U')
                {
                    vowels = vowels + 1;
                }
                else
                {
                    consonants = consonants + 1;
                }
                if (sentence[i] == '\0' || sentence[i] == ' ' || sentence[i] == '@')
                {
                   specialChars = specialChars + 1;
                }                
            }
            consonants = consonants - specialChars;
            Console.WriteLine("The number of vowels in the string is : {0}", vowels);
            Console.WriteLine("The number of consonants in the string is: {0}", consonants);
            Console.ReadLine();
        }
    }
}
