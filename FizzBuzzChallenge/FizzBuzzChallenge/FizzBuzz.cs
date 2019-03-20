using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    public static class FizzBuzz
    {
        public static string GetFizzBuzz()
        {
            string str = "";

            for(int i = 1; i <= 100; i++)
            {
                if((i % 3 == 0) && (i % 5 ==0))
                {
                    str += "FizzBuzz" + "\n"; 
                }
                else if(i % 3 == 0)
                {
                    str += "Fizz" + "\n";
                }
                else if(i % 5 == 0)
                {
                    str += "Buzz" + "\n";
                }
                else
                {
                    str += i.ToString() + "\n";
                }
            }
            return str;   
        }
    }
}
