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

        private bool IsValidPasswordAdvanced(string pw, int idx1, int idx2, char pol)
        {
            return ((pw[idx1] == pol) && (pw[idx2] != pol)) || ((pw[idx1] != pol) && (pw[idx2] == pol));
        }

        override public void Solve()
        {
            int validCount = 0;
            int validCountAdvanced = 0;
            foreach (string s in Input)
            {
                string[] splitted = s.Split(new char[] { '-', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (IsValidPassword(splitted[3], int.Parse(splitted[0]), int.Parse(splitted[1]), splitted[2][0]))
                {
                    validCount++;
                }
                if (IsValidPasswordAdvanced(splitted[3], int.Parse(splitted[0]) - 1, int.Parse(splitted[1]) - 1, splitted[2][0]))
                {
                    validCountAdvanced++;
                }
            }
            Part1Solution = validCount.ToString();
            Part2Solution = validCountAdvanced.ToString();
        }
    }
}
