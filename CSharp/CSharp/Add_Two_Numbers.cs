using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int nextVal = 0;
            ListNode solution = new ListNode();
            ListNode first = solution;
            while (l2 != null || l1 != null || nextVal > 0)
            {
                int currVal = nextVal;
                if (l1 != null)
                {
                    currVal += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    currVal += l2.val;
                    l2 = l2.next;
                }
                ListNode nextNode = new ListNode(currVal % 10);
                nextVal = currVal / 10;
                solution.next = nextNode;
                solution = solution.next;
            }
            return first.next;
        }
    }
}
