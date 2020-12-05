using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day05 : Day
    {
        public Day05()
        {
            Load("inputs/day05.txt");
        }

        override public void Solve()
        {
            int maxSeatId = 0;
            foreach(string s in Input)
            {
                string bin = s.Replace('F', '0').Replace('B', '1').Replace('L', '0').Replace('R', '1');
                int seat = Convert.ToInt32(bin, 2);
                maxSeatId = Math.Max(maxSeatId, seat);
            }
            Part1Solution = maxSeatId.ToString();
            Part2Solution = "TBD";
        }
    }
}
