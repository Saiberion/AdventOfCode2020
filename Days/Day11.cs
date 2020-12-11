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

        public int CountOccupiedSeatsInSight(int x, int y, char[,] seatingArea, int distance, int seatLimit)
        {
            int occupied = 0;

            if (distance > 0)
            {
                if (((x - distance) >= 0) && ((y - distance) >= 0))
                {
                    if (seatingArea[x - distance, y - distance] == '#')
                    {
                        occupied++;
                    }
                }
                if ((y - distance) >= 0)
                {
                    if (seatingArea[x, y - distance] == '#')
                    {
                        occupied++;
                    }
                }
                if (((x + distance) < seatingArea.GetLength(0)) && ((y - distance) >= 0))
                {
                    if (seatingArea[x + distance, y - distance] == '#')
                    {
                        occupied++;
                    }
                }
                if ((x + distance) < seatingArea.GetLength(0))
                {
                    if (seatingArea[x + distance, y] == '#')
                    {
                        occupied++;
                    }
                }
                if (((x + distance) < seatingArea.GetLength(0)) && ((y + distance) < seatingArea.GetLength(1)))
                {
                    if (seatingArea[x + distance, y + distance] == '#')
                    {
                        occupied++;
                    }
                }
                if ((y + distance) < seatingArea.GetLength(1))
                {
                    if (seatingArea[x, y + distance] == '#')
                    {
                        occupied++;
                    }
                }
                if (((x - distance) >= 0) && ((y + distance) < seatingArea.GetLength(1)))
                {
                    if (seatingArea[x - distance, y + distance] == '#')
                    {
                        occupied++;
                    }
                }
                if ((x - distance) >= 0)
                {
                    if (seatingArea[x - distance, y] == '#')
                    {
                        occupied++;
                    }
                }
            }
            return occupied;
        }

        public char GetNextSeatState(int x, int y, char[,] seatingArea, int distance, int seatLimit)
        {
            char nextSeatState;

            if (seatingArea[x,y] == '.')
            {
                nextSeatState = '.';
            }
            else
            {
                int neighbors = CountOccupiedSeatsInSight(x, y, seatingArea, distance, seatLimit);
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

        //private int RunSeating(int distance, )

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
                        char newState = GetNextSeatState(x, y, oldSeatingArea, 1, 4);
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
