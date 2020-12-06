using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day06 : Day
    {
        public Day06()
        {
            Load("inputs/day06.txt");
        }

        override public void Solve()
        {
            int sumOfYesAnswersPerGroup = 0;
            List<char> yesAnswers = new List<char>();
            for (int i = 0; i < Input.Count; i++)
            {
                if (string.IsNullOrEmpty(Input[i]))
                {
                    // blank line --> new group
                    sumOfYesAnswersPerGroup += yesAnswers.Count;
                    yesAnswers = new List<char>();
                }
                else
                {
                    foreach (char c in Input[i])
                    {
                        if (!yesAnswers.Contains(c))
                        {
                            yesAnswers.Add(c);
                        }
                    }
                }
            }
            sumOfYesAnswersPerGroup += yesAnswers.Count;
            Part1Solution = sumOfYesAnswersPerGroup.ToString();
            Part2Solution = "TBD";
        }
    }
}
