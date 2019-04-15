using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChallenge3
{
    public static class ReplaceSpace
    {
        public static string Replace(string str)
        {
            str = str.Trim();
            str = str.Replace(" ", "%20");
            return str;        
        }
    }
}
