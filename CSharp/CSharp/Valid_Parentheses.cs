using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            string currBrackets = "";
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{') currBrackets += c;
                else
                {
                    if (currBrackets.Length > 0)
                    {
                        switch (c)
                        {
                            case ')':
                                if (currBrackets[currBrackets.Length - 1] == '(') currBrackets = currBrackets.Substring(0, currBrackets.Length - 1);
                                else return false;
                                break;
                            case ']':
                                if (currBrackets[currBrackets.Length - 1] == '[') currBrackets = currBrackets.Substring(0, currBrackets.Length - 1);
                                else return false;
                                break;
                            case '}':
                                if (currBrackets[currBrackets.Length - 1] == '{') currBrackets = currBrackets.Substring(0, currBrackets.Length - 1);
                                else return false;
                                break;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return currBrackets.Length == 0;
        }
    }
}
