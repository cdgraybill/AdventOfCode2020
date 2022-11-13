using System.Linq;

namespace AdventOfCode2020.Days
{
    public class Day5Problem
    {
        public SeatingInstructions SplitSeatingInstructions(string rawInstrutions)
        {
            var seatingInstructions = new SeatingInstructions()
            {
                Row = rawInstrutions[..7],
                Seat = rawInstrutions.Substring(7, 3)
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

            return seatLocation - 1;
        }

        public object GetSeatId(int rowNumber, int columnNumber)
        {
            return rowNumber * 8 + columnNumber;
        }
    }

    public class SeatingInstructions
    {
        public string Row { get; set; }
        public string Seat { get; set; }
    }
}
