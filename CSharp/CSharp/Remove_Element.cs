using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int lastIdx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[lastIdx] = nums[i];
                    k++;
                    lastIdx++;
                }
            }
            GC.Collect();
            return k;
        }
    }
}
