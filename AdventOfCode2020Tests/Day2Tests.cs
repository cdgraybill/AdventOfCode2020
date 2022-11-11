using AdventOfCode2020.Days;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020Tests
{
    public class Day2Tests
    {
        [Test]
        public void GetsPasswordPolicy()
        {
            var day2 = new Day2Problem();
            var input = "1-3 f: asff";
            var passwordPolicy = day2.GetPasswordPolicy(input);

            Assert.AreEqual("1-3 f", passwordPolicy);
        }
    }
}
