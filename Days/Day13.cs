using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day13 : Day
    {
        public Day13()
        {
            Load("inputs/day13.txt");
        }

        override public void Solve()
        {
            int earliestDepartureTime = int.Parse(Input[0]);
            List<int> busIDs = new List<int>();
            string[] splitted = Input[1].Split(new char[] { ',', 'x' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in splitted)
            {
                busIDs.Add(int.Parse(s));
            }

            bool resultFound = false;
            for (int time = earliestDepartureTime; resultFound == false; time++)
            {
                foreach(int b in busIDs)
                {
                    if ((time % b) == 0)
                    {
                        Part1Solution = ((time - earliestDepartureTime) * b).ToString();
                        resultFound = true;
                        break;
                    }
                }
            }

            
            Part2Solution = "TBD";
        }
    }
}
