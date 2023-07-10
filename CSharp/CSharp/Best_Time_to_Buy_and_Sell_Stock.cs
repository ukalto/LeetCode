using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            int min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min) min = prices[i];
                else if (prices[i] - min > max) max = prices[i] - min;
            }
            GC.Collect();
            return max;
        }
    }
}
