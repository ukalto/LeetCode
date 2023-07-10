using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var dict1 = new Dictionary<char, int>();
            var dict2 = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                try
                {
                    dict1.Add(s[i], 1);
                }
                catch (ArgumentException)
                {
                    dict1[s[i]] += 1;
                }
                try
                {
                    dict2.Add(t[i], 1);
                }
                catch (ArgumentException)
                {
                    dict2[t[i]] += 1;
                }
            }
            return !dict1.Except(dict2).Any();
        }
    }
}
