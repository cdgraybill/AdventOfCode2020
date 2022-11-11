using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Days
{
    public class Day3Problem
    {
        public int ForestLinePosition { get; set; }

        public List<string> ParseInput()
        {
            List<string> input = File.ReadLines(@"C:ProblemInputs\Day3.txt")
                .ToList();

            return input;
        }

        public int GetTobogganLocationInForestLine(string forestLine, int currentPosition)
        {
            ForestLinePosition = currentPosition + 3;

            if (ForestLinePosition >= forestLine.Length)
            {
                var difference = ForestLinePosition - forestLine.Length;
                ForestLinePosition = difference;
            }

            return ForestLinePosition;
        }

        public int CountTrees(List<string> forest)
        {
            int numberOfTrees = 0;

            for (int i = 1; i < forest.Count; i++)
            {
                var forestLine = forest[i];
                var newPosition = GetTobogganLocationInForestLine(forestLine, ForestLinePosition);

                if (forestLine[newPosition] == '#')
                    numberOfTrees++;
            }

            return numberOfTrees;
        }
    }
}
