using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day11 : Day
    {
        public Day11()
        {
            Load("inputs/day11.txt");
        }

        public int CountNeighboringOccupiedSeats(int x, int y, char[,] seatingArea)
        {
            int occupied = 0;

            if (((x - 1) >= 0) && ((y - 1) >= 0))
            {
                if (seatingArea[x - 1,y - 1] == '#')
                {
                    occupied++;
                }
            }
            if ((y - 1) >= 0)
            {
                if (seatingArea[x, y - 1] == '#')
                {
                    occupied++;
                }
            }
            if (((x + 1) < seatingArea.GetLength(0)) && ((y - 1) >= 0))
            {
                if (seatingArea[x + 1, y - 1] == '#')
                {
                    occupied++;
                }
            }
            if ((x + 1) < seatingArea.GetLength(0))
            {
                if (seatingArea[x + 1, y] == '#')
                {
                    occupied++;
                }
            }
            if (((x + 1) < seatingArea.GetLength(0)) && ((y + 1) < seatingArea.GetLength(1)))
            {
                if (seatingArea[x + 1, y + 1] == '#')
                {
                    occupied++;
                }
            }
            if ((y + 1) < seatingArea.GetLength(1))
            {
                if (seatingArea[x, y + 1] == '#')
                {
                    occupied++;
                }
            }
            if (((x - 1) >= 0) && ((y + 1) < seatingArea.GetLength(1)))
            {
                if (seatingArea[x - 1, y + 1] == '#')
                {
                    occupied++;
                }
            }
            if ((x - 1) >= 0)
            {
                if (seatingArea[x - 1, y] == '#')
                {
                    occupied++;
                }
            }
            return occupied;
        }

        public char GetNextSeatState(int x, int y, char[,] seatingArea)
        {
            char nextSeatState;

            if (seatingArea[x,y] == '.')
            {
                nextSeatState = '.';
            }
            else
            {
                int neighbors = CountNeighboringOccupiedSeats(x, y, seatingArea);
                if (seatingArea[x,y] == 'L')
                {
                    if (neighbors == 0)
                    {
                        nextSeatState = '#';
                    }
                    else
                    {
                        nextSeatState = 'L';
                    }
                }
                else
                {
                    if (neighbors >= 4)
                    {
                        nextSeatState = 'L';
                    }
                    else
                    {
                        nextSeatState = '#';
                    }
                }
            }

            return nextSeatState;
        }

        override public void Solve()
        {
            char[,] seatingArea = new char[Input[0].Length, Input.Count];
            char[,] newSeatingArea;
            char[,] oldSeatingArea = null;
            int occupiedSeats = 0;

            for (int y = 0; y < Input.Count; y++)
            {
                for (int x = 0; x < Input[y].Length; x++)
                {
                    seatingArea[x, y] = Input[y][x];
                }
            }

            newSeatingArea = seatingArea.Clone() as char[,];

            bool somethingChanged = true;
            while (somethingChanged)
            {
                somethingChanged = false;
                oldSeatingArea = newSeatingArea.Clone() as char[,];
                for (int y = 0; y < oldSeatingArea.GetLength(1); y++)
                {
                    for (int x = 0; x < oldSeatingArea.GetLength(0); x++)
                    {
                        char newState = GetNextSeatState(x, y, oldSeatingArea);
                        if (newSeatingArea[x, y] != newState)
                        {
                            somethingChanged = true;
                        }
                        newSeatingArea[x, y] = newState;
                    }
                }
            }

            for (int y = 0; y < oldSeatingArea.GetLength(1); y++)
            {
                for (int x = 0; x < oldSeatingArea.GetLength(0); x++)
                {
                    if (newSeatingArea[x,y] == '#')
                    {
                        occupiedSeats++;
                    }
                }
            }

            Part1Solution = occupiedSeats.ToString();
            Part2Solution = "TBD";
        }
    }
}
