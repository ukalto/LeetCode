using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Roman_to_Integer
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>{
            {"I",1},
            {"V",5},
            {"X",10},
            {"L",50},
            {"C",100},
            {"D",500},
            {"M",1000}
        };
            int check = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    if ((s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                        || (s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                        || (s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                    )
                    {
                        check += (dict[s[i + 1].ToString()] - dict[s[i].ToString()]);
                        i++;
                    }
                    else
                    {
                        check += dict[s[i].ToString()];
                    }
                }
                else
                {
                    check += dict[s[i].ToString()];
                }
            }
            return check;
        }
    }
}
