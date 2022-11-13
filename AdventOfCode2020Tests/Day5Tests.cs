using AdventOfCode2020.Days;
using NUnit.Framework;
using System.Linq;

namespace AdventOfCode2020Tests
{
    public class Day5Tests
    {
        private readonly string[] TestInput =
        {
            "BFFFBBFRRR",
            "FFFBBBFRRR",
            "BBFFBBFRLL"
        };

        private readonly int[] _numberOfRows = Enumerable.Range(1, 127 + 1).ToArray();
        private readonly int[] _numberOfColumns = Enumerable.Range(1, 8 + 1).ToArray();

        [Test]
        public void SplitSeatingInstructions()
        {
            var day5 = new Day5Problem();
            var seatingInstructions = day5.SplitSeatingInstructions(TestInput[0]);

            Assert.AreEqual(7, seatingInstructions.Row.Length);
            Assert.AreEqual(3, seatingInstructions.Seat.Length);
            Assert.AreEqual("BFFFBBF", seatingInstructions.Row);
            Assert.AreEqual("RRR", seatingInstructions.Seat);
        }

        [Test]
        public void GetSeatLocation_Row()
        {
            var day5 = new Day5Problem();
            var seatLocation = day5.GetSeatingLocation('F', 'B', "BFFFBBF", _numberOfRows);

            Assert.IsNotNull(seatLocation);
            Assert.AreEqual(70, seatLocation);
        }

        [Test]
        public void GetSeatLocation_Column()
        {
            var day5 = new Day5Problem();
            var seatLocation = day5.GetSeatingLocation('L', 'R', "RLL", _numberOfColumns);

            Assert.IsNotNull(seatLocation);
            Assert.AreEqual(4, seatLocation);
        }

        [Test]
        public void GetSeatId()
        {
            var day5 = new Day5Problem();
            var seatId = day5.GetSeatId(102, 4);

            Assert.IsNotNull(seatId);
            Assert.AreEqual(820, seatId);
        }
    }
}
