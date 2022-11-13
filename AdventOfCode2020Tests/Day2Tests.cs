using AdventOfCode2020.Days;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventOfCode2020Tests
{
    public class Day2Tests
    {
        [Test]
        public void GetPasswordPolicy_Success()
        {
            var day2 = new Day2Problem();
            var input = "1-3 f: asff";
            var passwordPolicy = day2.GetPasswordPolicy(input);

            Assert.AreEqual("1-3 f", passwordPolicy);
        }

        [Test]
        public void GetPassword_Success()
        {
            var day2 = new Day2Problem();
            var input = "1-3 f: asff";
            var password = day2.GetPassword(input);

            Assert.AreEqual("asff", password);
        }

        [Test]
        public void GetCharacterToCheck_Success()
        {
            var day2 = new Day2Problem();
            var passwordPolicy = "1-3 f";
            var character = day2.GetCharacterToCheck(passwordPolicy);

            Assert.AreEqual("f", character);
        }

        [Test]
        public void GetRangeOfAllowedCharacters_Success()
        {
            var day2 = new Day2Problem();
            var passwordPolicy = "1-3 f";
            var characterRange = day2.GetRangeOfAllowedCharacters(passwordPolicy);

            Assert.AreEqual(characterRange.Min, 1);
            Assert.AreEqual(characterRange.Max, 3);
        }

        [Test]
        public void CheckForValidPassword_Success()
        {
            var day2 = new Day2Problem();
            var password = "asff";
            var passwordPolicy = "1-3 f";
            var isValid = day2.CheckForValidPassword(password, passwordPolicy);

            Assert.True(isValid);
        }

        [Test]
        public void CountNumberOfValidPasswords_PartOne()
        {
            var day2 = new Day2Problem();
            var numberOfValidPasswords = day2.CountNumberOfValidPasswordsPartOne();

            Assert.AreEqual(636, numberOfValidPasswords);
        }

        [Test]
        public void CountNumberOfValidPasswords_PartTwo()
        {
            var day2 = new Day2Problem();
            var numberOfValidPasswords = day2.CountNumberOfValidPasswordsPartTwo();

            Assert.AreEqual(588, numberOfValidPasswords);
        }
    }
}
