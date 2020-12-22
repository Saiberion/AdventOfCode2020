using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day22 : Day
    {
        public Day22()
        {
            Load("inputs/day22.txt");
        }

        override public void Solve()
        {
            List<int>[] decks = new List<int>[2];

            decks[0] = new List<int>();
            decks[1] = new List<int>();

            int playerIdx = -1;
            string[] splitted;

            foreach(string s in Input)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    if (s.StartsWith("Player"))
                    {
                        splitted = s.Split(new string[] { "Player ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                        playerIdx = int.Parse(splitted[0]) - 1;
                    }
                    else
                    {
                        decks[playerIdx].Add(int.Parse(s));
                    }
                }
            }

            while ((decks[0].Count > 0) && (decks[1].Count > 0))
            {
                if (decks[0][0] > decks[1][0])
                {
                    decks[0].Add(decks[0][0]);
                    decks[0].Add(decks[1][0]);
                }
                else
                {
                    decks[1].Add(decks[1][0]);
                    decks[1].Add(decks[0][0]);
                }
                decks[0].RemoveAt(0);
                decks[1].RemoveAt(0);
            }

            if (decks[0].Count > 0)
            {
                playerIdx = 0;
            }
            else
            {
                playerIdx = 1;
            }

            int score = 0;
            for(int i = 0; i < decks[playerIdx].Count; i++)
            {
                score += (decks[playerIdx].Count - i) * decks[playerIdx][i];
            }

            Part1Solution = score.ToString();
            Part2Solution = "TBD";
        }
    }
}
