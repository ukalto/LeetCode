using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] + 1 > 9)
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        var arr = new int[digits.Length + 1];

                        arr[0] = 1;
                        digits.CopyTo(arr, 1);
                        return arr;
                    }
                }
                else
                {
                    digits[i] += 1;
                    return digits;
                }
            }
            return digits;
        }
    }
}
