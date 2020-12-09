using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day09 : Day
    {
        public Day09()
        {
            Load("inputs/day09.txt");
        }

        private bool IsValidNumber(long nr, List<long> l)
        {
            for (int a = 0; a < (l.Count - 1); a++)
            {
                for (int b = a + 1; b < l.Count; b++)
                {
                    if ((l[a] + l[b]) == nr)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        override public void Solve()
        {
            List<long> encoding = new List<long>();
            for(int i = 0; i < Input.Count; i++)
            {
                if (i < 25)
                {
                    encoding.Add(long.Parse(Input[i]));
                }
                else
                {
                    long nextNr = long.Parse(Input[i]);
                    if (!IsValidNumber(nextNr, encoding))
                    {
                        Part1Solution = nextNr.ToString();
                        break;
                    }
                    else
                    {
                        encoding.RemoveAt(0);
                        encoding.Add(nextNr);
                    }
                }
            }

            Part2Solution = "TBD";
        }
    }
}
