using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var dict = new Dictionary<int, char>();
            foreach (int n in nums)
            {
                if (dict.ContainsKey(n)) return true;
                dict.Add(n, 'x');
            }
            return false;
        }
    }
}
