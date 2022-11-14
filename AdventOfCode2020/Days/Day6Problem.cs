using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Days
{
    public class Day6Problem
    {
        public readonly List<string> SampleData = new List<string>()
        {
            "abc",

            "",

            "a",
            "b",
            "c",

            "",

            "ab",
            "ac",

            "",

            "a",
            "a",
            "a",
            "a",

            "",

            "b"
        };

        public List<string> GetGroupAnswerRawStrings(List<string> problemInput)
        {
            var groupAnswers = new List<string>();
            var sb = new StringBuilder();

            for (int i = 1; i <= problemInput.Count; i++)
            {
                Day4Problem.GetSingleRawStringOfProblemInput(problemInput, sb, i);
                groupAnswers.Add(sb.ToString());
            }

            return groupAnswers;
        }
    }
}
