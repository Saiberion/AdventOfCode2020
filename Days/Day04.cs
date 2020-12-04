using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public class Day04 : Day
    {
        public Day04()
        {
            Load("inputs/day04.txt");
        }

        private bool isPassportValid(Dictionary<string, string> p)
        {
            return p.ContainsKey("byr") && p.ContainsKey("iyr") && p.ContainsKey("eyr") && p.ContainsKey("hgt") && p.ContainsKey("hcl") && p.ContainsKey("ecl") && p.ContainsKey("pid");
        }

        override public void Solve()
        {
            List<Dictionary<string, string>> passports = new List<Dictionary<string, string>>();
            Dictionary<string, string> passport;
            int validPassports = 0;

            passport = new Dictionary<string, string>();
            for (int i = 0; i < Input.Count; i++)
            {
                if (string.IsNullOrEmpty(Input[i]))
                {
                    // blank line --> new passwort
                    passports.Add(passport);
                    passport = new Dictionary<string, string>();
                }
                else
                {
                    string[] splitted = Input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s in splitted)
                    {
                        string[] splitted2 = s.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        if (passport.ContainsKey(splitted2[0]))
                        {
                            passport[splitted[0]] = splitted[1];
                        }
                        else
                        {
                            passport.Add(splitted2[0], splitted2[1]);
                        }
                    }
                }
            }
            passports.Add(passport);

            foreach(Dictionary<string, string> p in passports)
            {
                if (isPassportValid(p))
                {
                    validPassports++;
                }
            }

            Part1Solution = validPassports.ToString();
            Part2Solution = "TBD";
        }
    }
}
