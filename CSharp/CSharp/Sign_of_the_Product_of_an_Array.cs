using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Sign_of_the_Product_of_an_Array
    {
        public int ArraySign(int[] nums)
        {
            int countNegative = 0;
            foreach (int n in nums)
            {
                if (n == 0) return 0;
                else if (n < 0) countNegative++;
            }
            GC.Collect();
            return countNegative % 2 == 0 ? 1 : -1;
        }
    }
}
