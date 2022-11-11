using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace AdventOfCode2020.Days
{
    public class Day2Problem
    {
        public List<string> ParseInput()
        {
            List<string> input = File.ReadLines(@"C:ProblemInputs\Day2.txt")
                .ToList();

            foreach (var line in input)
            {
                switch (line)
                {
                    
                }
            }

            return input;
        }

        public string GetPasswordPolicy(string password)
        {
            var passwordPolicy = string.Concat(password.TakeWhile((c) => c != ':'));

            return passwordPolicy;
        }
    }
}
