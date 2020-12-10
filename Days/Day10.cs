using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day10 : Day
    {
        public Day10()
        {
            Load("inputs/day10.txt");
        }

        override public void Solve()
        {
            List<int> adapters = new List<int>();
            int diff1 = 0, diff3 = 1;

            foreach(string s in Input)
            {
                adapters.Add(int.Parse(s));
            }
            adapters.Add(0);
            adapters.Sort();

            for(int i = 0; i < (adapters.Count - 1); i++)
            {
                switch (adapters[i + 1] - adapters[i])
                {
                    case 1:
                        diff1++;
                        break;
                    case 3:
                        diff3++;
                        break;
                }
            }

            Part1Solution = (diff1 * diff3).ToString();
            Part2Solution = "TBD";
        }
    }
}
