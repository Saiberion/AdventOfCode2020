using System;
using System.Collections.Generic;
using System.Text;

namespace Days
{
    public enum EBootCodeInstructions
    {
        acc,
        jmp,
        nop
    }

    public class BootCode
    {
        public List<EBootCodeInstructions> Instructions { get; set; }
        public List<int> Arguments { get; set; }
        public List<bool> Executed { get; set; }
        public int Accumulator { get; set; }

        private int programCounter = 0;

        public BootCode()
        {
            Instructions = new List<EBootCodeInstructions>();
            Arguments = new List<int>();
            Executed = new List<bool>();
            Accumulator = 0;
        }

        public void AddInstruction(string instr)
        {
            string[] splitted = instr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (splitted[0].Equals("acc"))
            {
                Instructions.Add(EBootCodeInstructions.acc);
            }
            else if (splitted[0].Equals("jmp"))
            {
                Instructions.Add(EBootCodeInstructions.jmp);
            }
            else if (splitted[0].Equals("nop"))
            {
                Instructions.Add(EBootCodeInstructions.nop);
            }
            Arguments.Add(int.Parse(splitted[1]));
            Executed.Add(false);
        }

        public bool Next()
        {
            if (Executed[programCounter])
            {
                return true;
            }
            else
            {
                Executed[programCounter] = true;
                switch (Instructions[programCounter])
                {
                    case EBootCodeInstructions.acc:
                        Accumulator += Arguments[programCounter++];
                        break;
                    case EBootCodeInstructions.jmp:
                        programCounter += Arguments[programCounter];
                        break;
                    case EBootCodeInstructions.nop:
                        programCounter++;
                        break;
                }
                return false;
            }
        }
    }

    public class Day08 : Day
    {
        public Day08()
        {
            Load("inputs/day08.txt");
        }

        override public void Solve()
        {
            BootCode code = new BootCode();
            for (int i = 0; i < Input.Count; i++)
            {
                code.AddInstruction(Input[i]);
            }

            while (code.Next() == false) ;

            Part1Solution = code.Accumulator.ToString();
            Part2Solution = "TBD";
        }
    }
}
