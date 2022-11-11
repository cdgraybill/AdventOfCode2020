using AdventOfCode2020.Days;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020Tests
{
    internal class Day3Tests
    {
        private readonly List<string> testForest = new List<string>
        {
          "..##.......",
          "#...#...#..",
          ".#....#..#.",
          "..#.#...#.#",
          ".#...##..#.",
          "..#.##.....",
          ".#.#.#....#",
          ".#........#",
          "#.##...#...",
          "#...##....#",
          ".#..#...#.#",
        };

        [Test]
        public void GetLengthOfInputLine()
        {
            var day3 = new Day3Problem();
            var lineLength = day3.ParseInput()[0].Length;

            Assert.AreEqual(31, lineLength);
        }

        [Test]
        public void GetTobogganLocationInForestLine_NoDifference()
        {
            var day3 = new Day3Problem();
            var currentPosition = day3.ForestLinePosition = 0;
            var position = day3.GetTobogganLocationInForestLine(testForest[0], currentPosition);

            Assert.AreEqual(3, position);
        }

        [Test]
        public void GetTobogganLocationInForestLine_Difference()
        {
            var day3 = new Day3Problem();
            var currentPosition = day3.ForestLinePosition = 9;
            var position = day3.GetTobogganLocationInForestLine(testForest[0], currentPosition);

            Assert.AreEqual(1, position);
        }

        [Test]
        public void TestInput()
        {
            var day3 = new Day3Problem();
            var forest = day3.ParseInput();
            var numberOfTrees = day3.CountTrees(forest);

            Assert.AreEqual(7, numberOfTrees);
        }

        [Test]
        public void CountTrees_Success()
        {
            var day3 = new Day3Problem();
            var numberOfTrees = day3.CountTrees(testForest);

            Assert.AreEqual(7, numberOfTrees);
        }
    }
}
