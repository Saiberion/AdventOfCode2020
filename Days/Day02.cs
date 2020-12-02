using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day02 : Day
    {
        public Day02()
        {
            Load("inputs/day02.txt");
        }

        private bool IsValidPassword(string pw, int min, int max, char pol)
        {
            int countedPol = 0;
            for(int i = 0; i < pw.Length; i++)
            {
                if (pw[i] == pol)
                {
                    countedPol++;
                }
            }
            return ((countedPol >= min) && (countedPol <= max));
        }

        override public void Solve()
        {
            int validCount = 0;
            foreach (string s in Input)
            {
                string[] splitted = s.Split(new char[] { '-', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (IsValidPassword(splitted[3], int.Parse(splitted[0]), int.Parse(splitted[1]), splitted[2][0]))
                {
                    validCount++;
                }
            }
            Part1Solution = validCount.ToString();
            Part2Solution = "TBD";
        }
    }
}
