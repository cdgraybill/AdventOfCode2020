using AdventOfCode2020.Days;
using NUnit.Framework;
using System.Collections.Generic;

namespace AdventOfCode2020Tests
{
    public class Day1Tests
    {
        [Test]
        public void MultiplyTwoNumbers_CorrectAnswer()
        {
            //arrange
            Day1Problem day1 = new Day1Problem();
            List<int> data = day1.ParseInput();

            //act
            var sum = day1.MultiplyTwoNumbers(data);

            //assert
            Assert.AreEqual(2020, sum);
        }
    }
}