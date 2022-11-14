using AdventOfCode2020.Days;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020Tests
{
    public class Day6Tests
    {
        [Test]
        public void GetGroupAnswerRawStrings()
        {
            var day6 = new Day6Problem();
            var groupAnswers = day6.GetGroupAnswerRawStrings(day6.SampleData);

            Assert.IsNotNull(groupAnswers);
        }
    }
}
