using AdventOfCode2020.Days;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020Tests
{
    public class Day5Tests
    {
        [Test]
        public void SplitSeatingInstructions()
        {
            var day5 = new Day5Problem();
            var seatingInstructions = day5.SplitRawInstructions(day5.TestInput[0]);

            Assert.AreEqual(7, seatingInstructions.Row.Length);
            Assert.AreEqual(3, seatingInstructions.Column.Length);
            Assert.AreEqual("BFFFBBF", seatingInstructions.Row);
            Assert.AreEqual("RRR", seatingInstructions.Column);
        }

        [Test]
        public void GetSeatLocation_Row()
        {
            var day5 = new Day5Problem();
            var seatLocation = day5.GetSeatingLocation('F', 'B', "BFFFBBF", day5._numberOfRows);

            Assert.IsNotNull(seatLocation);
            Assert.AreEqual(70, seatLocation);
        }

        [Test]
        public void GetSeatLocation_Column()
        {
            var day5 = new Day5Problem();
            var seatLocation = day5.GetSeatingLocation('L', 'R', "RLL", day5._numberOfColumns);

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

        [Test]
        public void GetCollectionOfSeatIds()
        {
            var day5 = new Day5Problem();
            var seatIds = day5.GetSeatIds(day5.TestInput);

            Assert.IsNotNull(seatIds);
            Assert.IsInstanceOf<HashSet<int>>(seatIds);
            Assert.IsTrue(seatIds.Contains(567));
            Assert.IsTrue(seatIds.Contains(119));
            Assert.IsTrue(seatIds.Contains(820));
        }

        [Test]
        public void GetLargestSeatId()
        {
            var day5 = new Day5Problem();
            var seatId = day5.GetLargestSeatId(day5.ProblemInput);

            Assert.IsNotNull(seatId);
            Assert.AreEqual(878, seatId);
        }

        [Test]
        public void GetMySeatId()
        {
            var day5 = new Day5Problem();
            var seatId = day5.GetMySeatId(day5.ProblemInput);

            Assert.IsNotNull(seatId);
            Assert.AreEqual(504, seatId);
        }
    }
}
