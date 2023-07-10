using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Palindrome_Number {
        public bool IsPalindrome(int x)
        {
            string xS = x.ToString();
            char[] charArray = xS.ToCharArray();
            Array.Reverse(charArray);
            return xS == new string(charArray);
        }
    }
}
