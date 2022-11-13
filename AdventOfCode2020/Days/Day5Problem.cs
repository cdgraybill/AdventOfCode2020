using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Days
{
    public class Day5Problem
    {
        private readonly int[] _numberOfRows = new int[128];
        private readonly int[] _numberOfColumns = new int[9];

        public SeatingInstructions SplitSeatingInstructions(string rawInstrutions)
        {
            var seatingInstructions = new SeatingInstructions()
            {
                Row = rawInstrutions[..7],
                Seat = rawInstrutions.Substring(7, 3)
            };

            return seatingInstructions;
        }

        public int GetSeatingLocation(char directionOne, char directionTwo, string seatingInstruction)
        {
            int seatingLocation = 0;

            foreach (var direction in seatingInstruction)
            {
                switch (direction)
                {
                    case var _ when direction.Equals(directionOne):

                        break;
                    case var _ when direction.Equals(directionTwo):

                        break;
                    default:
                        break;
                }
            }

            return 0;
        }
    }

    public class SeatingInstructions
    {
        public string Row { get; set; }
        public string Seat { get; set; }
    }
}
