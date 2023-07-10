using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            int lastIdx = 1;
            int currNum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (currNum != nums[i])
                {
                    currNum = nums[i];
                    nums[lastIdx] = currNum;
                    lastIdx++;
                    k++;
                }
            }
            GC.Collect();
            return k;
        }
    }
}
