using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Days
{
    public class Day4Problem
    {
        private readonly string[] MandatoryKeys = new[] { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };

        public PassportField SplitFieldIntoKeyValuePair(string fieldString)
        {
            var splitString = fieldString.Split(":", StringSplitOptions.RemoveEmptyEntries);

            var passportField = new PassportField()
            {
                Key = splitString[0],
                Value = splitString[1]
            };

            return passportField;
        }

        private void AddFieldsToPassport(Dictionary<string, string> passport, StringBuilder sb)
        {
            var passportFields = sb.ToString().Split(" ");
            var adjustedFields = passportFields.SkipLast(1).ToArray();
            foreach (var passportField in adjustedFields)
            {
                var keyValuePair = SplitFieldIntoKeyValuePair(passportField);
                passport[keyValuePair.Key] = keyValuePair.Value;
            }
        }

        public bool IsValidPassport(Dictionary<string, string> passport)
        {
            var isValid = true;

            foreach (var mandatoryKey in MandatoryKeys)
            {
                if (!passport.Keys.Contains(mandatoryKey))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public int GetNumberOfValidPasswords(List<string> problemInput)
        {
            var numberOfValidPasswords = 0;
            var passports = new List<Dictionary<string, string>>();
            var sb = new StringBuilder();

            for (int i = 1; i <= problemInput.Count; i++)
            {
                if (!string.IsNullOrEmpty(problemInput[i - 1]))
                    sb.Append(problemInput[i - 1] + " ");
                
                if(string.IsNullOrEmpty(problemInput[i - 1]) || i == problemInput.Count)
                {
                    var passport = new Dictionary<string, string>();
                    AddFieldsToPassport(passport, sb);
                    passports.Add(passport);

                    if (IsValidPassport(passport))
                        numberOfValidPasswords++;

                    sb.Clear();
                }
            }

            return numberOfValidPasswords;
        }
    }

    public class PassportField
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}