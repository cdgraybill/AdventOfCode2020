using AdventOfCode2020.Days;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020Tests
{
    public class Day1Tests
    {
        private readonly List<int> Numbers = File.ReadLines(@"ProblemInputs\Day1.txt")
                .Select(x => Convert.ToInt32(x))
                .ToList();

        [Test]
        public void GetAnswer_PartOne()
        {
            Day1Problem day1 = new Day1Problem();
            var sum = day1.GetAnswerPartOne(Numbers);

            Assert.AreEqual(2020, sum);
        }

        [Test]
        public void GetAnswer_PartTwo()
        {
            Day1Problem day1 = new Day1Problem();
            var sum = day1.GetAnswerPartTwo(Numbers);

            Assert.AreEqual(2020, sum);
        }
    }
}