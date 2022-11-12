using System;
using System.Collections.Generic;
using System.Globalization;
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
        private readonly string[] EyeColors = new[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

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

        public int GetNumberOfValidPasswords(List<string> problemInput)
        {
            var numberOfValidPasswords = 0;
            var passports = new List<Dictionary<string, string>>();
            var sb = new StringBuilder();

            for (int i = 1; i <= problemInput.Count; i++)
            {
                GetRawPassportString(problemInput, sb, i);

                if (string.IsNullOrEmpty(problemInput[i - 1]) || i == problemInput.Count)
                {
                    numberOfValidPasswords = CountValidPasswords(numberOfValidPasswords, passports, sb);
                }
            }

            return numberOfValidPasswords;
        }

        private void AddFieldsToPassport(Dictionary<string, string> passport, string rawPassportString)
        {
            var passportFields = rawPassportString.Split(" ");
            var adjustedFields = passportFields.SkipLast(1).ToArray();
            foreach (var passportField in adjustedFields)
            {
                var keyValuePair = SplitFieldIntoKeyValuePair(passportField);
                passport[keyValuePair.Key] = keyValuePair.Value;
            }
        }

        private bool IsValidPassport(Dictionary<string, string> passport)
        {
            var isValid = true;
            isValid = HasMandatoryKeys(passport, isValid);

            if (isValid == false)
            {
                return isValid;
            }
            else
            {
                var valueChecks = new List<bool>();
            }

            return isValid;
        }

        private bool HasMandatoryKeys(Dictionary<string, string> passport, bool isValid)
        {
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

        private int CountValidPasswords(int numberOfValidPasswords, List<Dictionary<string, string>> passports, StringBuilder sb)
        {
            var passport = CreatePassport(sb.ToString());
            passports.Add(passport);

            if (IsValidPassport(passport))
                numberOfValidPasswords++;

            sb.Clear();
            return numberOfValidPasswords;
        }

        private Dictionary<string, string> CreatePassport(string rawPassportString)
        {
            var passport = new Dictionary<string, string>();
            AddFieldsToPassport(passport, rawPassportString);
            return passport;
        }

        private static void GetRawPassportString(List<string> problemInput, StringBuilder sb, int i)
        {
            if (!string.IsNullOrEmpty(problemInput[i - 1]))
                sb.Append(problemInput[i - 1] + " ");
        }

        public bool IsValidBirthYear(string birthYear)
        {
            return IsValidNumber(birthYear, 1920, 2002);
        }

        public bool IsValidIssueYear(string issueYear)
        {
            return IsValidNumber(issueYear, 2010, 2020);
        }

        public bool IsValidExpirationYear(string expirationYear)
        {
            return IsValidNumber(expirationYear, 2020, 2030);
        }

        private static bool IsValidNumber(string value, int min, int max)
        {
            var number = Convert.ToInt32(value);
            var isValidNumber = false;

            if (min <= number && number <= max)
                isValidNumber = true;

            return isValidNumber;
        }

        public bool IsValidHeight(string height)
        {
            var measurementUnit = height.Substring(height.Length - 2);
            var heightValue = height.Substring(0, height.Length - 2);
            var isValidHeight = false;

            switch (measurementUnit)
            {
                case "cm":
                    isValidHeight = IsValidNumber(heightValue, 150, 193);
                    break;
                case "in":
                    isValidHeight = IsValidNumber(heightValue, 59, 76);
                    break;
                default:
                    break;
            }

            return isValidHeight;
        }

        public bool IsHexColor(string hexColor)
        {
            var res = 0;
            var parsedHexColor = hexColor.Substring(1, hexColor.Length -1);

            if (parsedHexColor.Length != 6)
                return false;

            var isHexColor = int.TryParse(parsedHexColor,
                NumberStyles.HexNumber,
                CultureInfo.InvariantCulture, out res);

            return isHexColor;
        }

        public bool IsValidEyeColor(string eyeColor)
        {
            var isValid = true;

            if (!EyeColors.Contains(eyeColor))
                isValid = false;

            return isValid;
        }

        public bool IsValidPassportId(string passportId)
        {
            var isValid = false;

            if (passportId.Length == 9)
                isValid = true;

            return isValid;
        }
    }

    public class PassportField
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}