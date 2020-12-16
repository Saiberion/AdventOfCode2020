using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class TicketField
    {
        public string Name { get; set; }
        public int Min1 { get; set; }
        public int Min2 { get; set; }
        public int Max1 { get; set; }
        public int Max2 { get; set; }

        public TicketField(string name, int min1, int max1, int min2, int max2)
        {
            Name = name;
            Min1 = min1;
            Min2 = min2;
            Max1 = max1;
            Max2 = max2;
        }
    }

    public class Day16 : Day
    {
        public Day16()
        {
            Load("inputs/day16.txt");
        }

        override public void Solve()
        {
            int readSection = 0;
            string[] splitted;
            List<TicketField> ticketFields = new List<TicketField>();
            List<int> myTicketValues = new List<int>();
            List<List<int>> nearbyTickets = new List<List<int>>();
            foreach (string s in Input)
            {
                if (string.IsNullOrEmpty(s))
                {
                    readSection++;
                }
                else
                {
                    switch (readSection)
                    {
                        case 0:
                            splitted = s.Split(new string[] { ": ", "-", " or " }, StringSplitOptions.RemoveEmptyEntries);
                            ticketFields.Add(new TicketField(splitted[0], int.Parse(splitted[1]), int.Parse(splitted[2]), int.Parse(splitted[3]), int.Parse(splitted[4])));
                            break;
                        case 1:
                            if (!s.StartsWith("your"))
                            {
                                splitted = s.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string s2 in splitted)
                                {
                                    myTicketValues.Add(int.Parse(s2));
                                }
                            }
                            break;
                        case 2:
                            if (!s.StartsWith("nearby"))
                            {
                                List<int> ticket = new List<int>();
                                splitted = s.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string s2 in splitted)
                                {
                                    ticket.Add(int.Parse(s2));
                                }
                                nearbyTickets.Add(ticket);
                            }
                            break;
                    }
                }
            }

            List<int> validNumbers = new List<int>();
            foreach(TicketField t in ticketFields)
            {
                for(int i = t.Min1; i <= t.Max1; i++)
                {
                    if (!validNumbers.Contains(i))
                    {
                        validNumbers.Add(i);
                    }
                }
                for (int i = t.Min2; i <= t.Max2; i++)
                {
                    if (!validNumbers.Contains(i))
                    {
                        validNumbers.Add(i);
                    }
                }
            }

            validNumbers.Sort();

            int errorRate = 0;
            foreach(List<int> l in nearbyTickets)
            {
                foreach(int i in l)
                {
                    if (!validNumbers.Contains(i))
                    {
                        errorRate += i;
                    }
                }
            }

            Part1Solution = errorRate.ToString();
            Part2Solution = "TBD";
        }
    }
}
