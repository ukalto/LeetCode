using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string prefix = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                char currLetter = strs[0][i];
                foreach (string str in strs)
                {
                    if (str.Length <= i || str[i] != currLetter)
                    {
                        return prefix;
                    }
                }
                prefix += currLetter;
            }
            return prefix;
        }
    }
}
