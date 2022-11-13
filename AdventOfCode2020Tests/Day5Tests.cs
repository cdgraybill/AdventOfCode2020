using AdventOfCode2020.Days;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
