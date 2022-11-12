using AdventOfCode2020.Days;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020Tests
{
    public class Day4Tests
    {
        private readonly List<string> ProblemInput = File.ReadLines(@"C:ProblemInputs\Day4.txt").ToList();

        [Test]
        public void SplitFieldIntoKeyValuePair_Success()
        {
            var day4 = new Day4Problem();
            var fieldString = "ecl:gry";
            var passportField = day4.SplitFieldIntoKeyValuePair(fieldString);

            Assert.IsNotNull(passportField);
            Assert.AreEqual("ecl", passportField.Key);
            Assert.AreEqual("gry", passportField.Value);
        }

        [Test]
        public void GetNumberOfValidPassports()
        {
            var day4 = new Day4Problem();
            var numberOfValidPasswords = day4.GetNumberOfValidPasswords(ProblemInput);

            Assert.AreEqual(2, numberOfValidPasswords);
        }
    }
}
