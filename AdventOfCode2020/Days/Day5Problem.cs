using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Days
{
    public class Day5Problem
    {
        public readonly string[] TestInput =
        {
            "BFFFBBFRRR",
            "FFFBBBFRRR",
            "BBFFBBFRLL"
        };

        public readonly int[] _numberOfRows = Enumerable.Range(0, 128).ToArray();
        public readonly int[] _numberOfColumns = Enumerable.Range(0, 8).ToArray();

        public readonly List<string> ProblemInput = File.ReadLines(@"C:ProblemInputs\Day5.txt").ToList();

        public SeatingInstructions SplitRawInstructions(string rawInstrutions)
        {
            var seatingInstructions = new SeatingInstructions()
            {
                Row = rawInstrutions[..7],
                Column = rawInstrutions.Substring(7, 3)
            };

            return seatingInstructions;
        }

        public int GetSeatingLocation(char directionOne, char directionTwo, string seatingInstruction, int[] section)
        {
            var seatLocation = 0;

            foreach (var direction in seatingInstruction)
            {
                switch (direction)
                {
                    case var _ when direction.Equals(directionOne):
                        section = section.Take(section.Length / 2).ToArray();
                        break;
                    case var _ when direction.Equals(directionTwo):
                        section = section.Skip(section.Length / 2).ToArray();
                        break;
                    default:
                        break;
                }

                if (section.Length == 1)
                    seatLocation = section[0];
            }

            return seatLocation;
        }

        public int GetSeatId(int rowNumber, int columnNumber)
        {
            return rowNumber * 8 + columnNumber;
        }

        public HashSet<int> GetSeatIds(IEnumerable<string> testInput)
        {
            var seatIds =  new HashSet<int>();

            foreach (var rawInstruction in testInput)
            {
                var seatingInstructions = SplitRawInstructions(rawInstruction);

                var rowLocation = GetSeatingLocation('F', 'B', seatingInstructions.Row, _numberOfRows);
                var columnLocation = GetSeatingLocation('L', 'R', seatingInstructions.Column, _numberOfColumns);

                var seatId = GetSeatId(rowLocation, columnLocation);

                seatIds.Add(seatId);
            }

            return seatIds;
        }

        public int GetLargestSeatId(IEnumerable<string> problemInput)
        {
            var seatIds = GetSeatIds(problemInput);
            return seatIds.Max();
        }
    }

    public class SeatingInstructions
    {
        public string Column { get; set; }
        public string Row { get; set; }
    }
}
