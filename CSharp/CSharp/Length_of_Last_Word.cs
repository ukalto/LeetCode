using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            return s.Split(' ', (char) StringSplitOptions.RemoveEmptyEntries).Last().Length;
        }
    }
}
