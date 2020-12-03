﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day03 : Day
    {
        public Day03()
        {
            Load("inputs/day03.txt");
        }

        override public void Solve()
        {
            int x;
            int y;
            List<int[]> slopes = new List<int[]>()
            {
                new int[] { 1, 1 },
                new int[] { 3, 1 },
                new int[] { 5, 1 },
                new int[] { 7, 1 },
                new int[] { 1, 2 }
            };
            long[] trees = new long[slopes.Count];

            for (int i = 0; i < slopes.Count; i++)
            {
                x = 0;
                y = 0;
                while (true)
                {
                    x = (x + slopes[i][0]) % Input[y].Length;
                    y = y + slopes[i][1];
                    if (y >= Input.Count)
                    {
                        break;
                    }
                    else
                    {
                        if (Input[y][x] == '#')
                        {
                            trees[i]++;
                        }
                    }
                }
            }

            Part1Solution = trees[1].ToString();
            Part2Solution = (trees[0] * trees[1] * trees[2] * trees[3] * trees[4]).ToString();
        }
    }
}
