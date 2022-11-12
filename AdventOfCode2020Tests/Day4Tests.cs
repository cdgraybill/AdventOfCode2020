﻿using AdventOfCode2020.Days;
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
        private readonly List<string> TestInput = new List<string>
        {
            "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
            "byr:1937 iyr:2017 cid:147 hgt:183cm",
            "",
            "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
            "hcl:#cfa07d byr:1929",
            "",
            "hcl:#ae17e1 iyr:2013",
            "eyr:2024",
            "ecl:brn pid:760753108 byr:1931",
            "hgt:179cm",
            "",
            "hcl:#cfa07d eyr:2025 pid:166559648",
            "iyr:2011 ecl:brn hgt:59in"
        };

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

        [Test]
        [TestCase("1920")]
        [TestCase("2002")]
        [TestCase("7")]
        [TestCase("100000")]
        [TestCase("-6")]
        public void IsValidBirthYear(string birthYear)
        {
            var day4 = new Day4Problem();
            var isValidBirthYear = day4.IsValidBirthYear(birthYear);

            Assert.IsTrue(isValidBirthYear);
        }

        [Test]
        [TestCase("2010")]
        [TestCase("2020")]
        [TestCase("7")]
        [TestCase("100000")]
        [TestCase("-6")]
        public void IsValidIssueYear(string issueYear)
        {
            var day4 = new Day4Problem();
            var isValidIssueYear = day4.IsValidIssueYear(issueYear);

            Assert.IsTrue(isValidIssueYear);
        }

        [Test]
        [TestCase("2010")]
        [TestCase("2020")]
        [TestCase("7")]
        [TestCase("100000")]
        [TestCase("-6")]
        public void IsValidExpirationYear(string expirationYear)
        {
            var day4 = new Day4Problem();
            var isValidExpirationYear = day4.IsValidExpirationYear(expirationYear);

            Assert.IsTrue(isValidExpirationYear);
        }
    }
}
