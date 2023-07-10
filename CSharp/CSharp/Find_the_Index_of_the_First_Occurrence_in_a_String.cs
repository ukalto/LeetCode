using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public int StrStr(string haystack, string needle)
        {
            int pointer = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[pointer]) pointer++;
                else pointer = 0;
                if (pointer == needle.Length) return i - (pointer - 1);
            }
            return -1;
        }
    }
}
