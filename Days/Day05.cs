﻿using System;
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
            List<int> seats = new List<int>();
            foreach(string s in Input)
            {
                string bin = s.Replace('F', '0').Replace('B', '1').Replace('L', '0').Replace('R', '1');
                int seat = Convert.ToInt32(bin, 2);
                seats.Add(seat);
                maxSeatId = Math.Max(maxSeatId, seat);
            }
            Part1Solution = maxSeatId.ToString();
            
            seats.Sort();
            for(int i = 0; i < seats.Count - 1; i++)
            {
                if ((seats[i] + 1) != seats[i + 1])
                {
                    Part2Solution = (seats[i] + 1).ToString();
                    break;
                }
            }
        }
    }
}
