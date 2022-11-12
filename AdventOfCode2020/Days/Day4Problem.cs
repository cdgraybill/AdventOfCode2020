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
        public Dictionary<string, string> ParseInputIntoPassport(List<string> input)
        {
            Dictionary<string, string> passport = new Dictionary<string, string>();
            var sb = new StringBuilder();

            GetPassportFields(input, sb);
            CreatePassportDictionary(passport, sb);

            return passport;
        }

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

        private void CreatePassportDictionary(Dictionary<string, string> passport, StringBuilder sb)
        {
            var passportFields = sb.ToString().Split(" ");
            foreach (var passportField in passportFields)
            {
                var keyValuePair = SplitFieldIntoKeyValuePair(passportField);
                passport[keyValuePair.Key] = keyValuePair.Value;
            }
        }

        private static void GetPassportFields(List<string> input, StringBuilder sb)
        {
            foreach (var inputItem in input)
            {
                if (!string.IsNullOrEmpty(inputItem))
                    sb.Append(inputItem);
                else
                    break;
            }
        }
    }

    public class PassportField
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}