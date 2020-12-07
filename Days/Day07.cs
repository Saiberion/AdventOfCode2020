﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Bag
    {
        public string Name { get; set; }
        public List<string> Within { get; set; }
    }

    public class Day07 : Day
    {
        public Day07()
        {
            Load("inputs/day07.txt");
        }

        private List<string> OuterBagNames;

        private void GetOuterBags(string bagName, List<Bag> bags)
        {
            Bag bag = null;
            
            foreach (Bag g in bags)
            {
                if (g.Name.Equals(bagName))
                {
                    bag = g;
                    break;
                }
            }

            if (bag != null)
            {
                foreach (string s in bag.Within)
                {
                    if (!OuterBagNames.Contains(s))
                    {
                        OuterBagNames.Add(s);
                        GetOuterBags(s, bags);
                    }
                }
            }
        }

        override public void Solve()
        {
            List<Bag> bags = new List<Bag>();

            foreach (string s in Input)
            {
                string[] splitted = s.Split(new string[] { " bags contain " }, StringSplitOptions.RemoveEmptyEntries);

                string[] splitted2 = splitted[1].Split(new string[] { " bag, ", " bags, ", " bag.", " bags." }, StringSplitOptions.RemoveEmptyEntries);
                if (!splitted2[0].Equals("no other"))
                {
                    foreach (string s2 in splitted2)
                    {
                        //int amount = int.Parse(s2.Remove(1, s2.Length - 1));
                        string name = s2.Remove(0, 2);
                        Bag bag = null;
                        foreach(Bag g in bags)
                        {
                            if (g.Name.Equals(name))
                            {
                                bag = g;
                                break;
                            }
                        }
                        if (bag == null)
                        {
                            bag = new Bag
                            {
                                Name = name,
                                Within = new List<string>()
                            };
                            bags.Add(bag);
                        }
                        bag.Within.Add(splitted[0]);
                    }
                }
            }

            OuterBagNames = new List<string>();
            GetOuterBags("shiny gold", bags);

            Part1Solution = OuterBagNames.Count.ToString();
            Part2Solution = "TBD";
        }
    }
}
