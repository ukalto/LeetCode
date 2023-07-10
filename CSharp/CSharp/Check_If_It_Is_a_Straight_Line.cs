using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Check_If_It_Is_a_Straight_Line
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            int x = coordinates[1][0] - coordinates[0][0];
            int y = coordinates[1][1] - coordinates[0][1];
            for (int i = 1; i < coordinates.Length; i++)
            {
                if (y * (coordinates[i][0] - coordinates[0][0]) != x * (coordinates[i][1] - coordinates[0][1])) return false;
            }
            return true;
        }
    }
}
