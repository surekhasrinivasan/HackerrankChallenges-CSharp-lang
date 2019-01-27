using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPasswordAlgorithm
{
    // Program to check password

    /*
     * The password should have:
     * 1. min 6 char and max 12 char
     * 2. No two similar chars consecutively
     * 3. 1 lower case
     * 4. 1 upper case
     * 5. 1 special char
     * 6. No white space
    **/
    class Program
    {
        public static bool CheckPassword(string password)
        {
            // Min 6 char and max 12 char
            if (password.Length < 6 || password.Length > 12)
                return false;

            // one upper case
            if (!password.Any(char.IsUpper))
                return false;

            // one lower case
            if (!password.Any(char.IsLower))
                return false;

            // No white space
            if (password.Contains(" "))
                return false;

            // No two similar chars consecutively
            for (int i = 0; i < password.Length - 1; i++)
            {
                if (password[i] == password[i + 1])
                    return false;
            }

            // one special character
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToArray();

            foreach (char sc in specialCharacters)
            {
                if (password.Contains(sc))
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPassword("Alpha$"));

            Console.WriteLine(CheckPassword("@John123 "));

            Console.WriteLine(CheckPassword("Sami&123"));

            bool result = CheckPassword("Smith");
            Console.WriteLine(result);
        }
    }
}