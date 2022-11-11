using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace AdventOfCode2020.Days
{
    public class Day2Problem
    {
        private readonly string Colon = ": ";
        private readonly string Hyphen = "-";

        public List<string> ParseInput()
        {
            List<string> input = File.ReadLines(@"C:ProblemInputs\Day2.txt")
                .ToList();

            return input;
        }

        public int CountNumberOfValidPasswordsPartOne()
        {
            var numberOfValidPasswords = 0;
            var input = ParseInput();

            foreach (var index in input)
            {
                var password = GetPassword(index);
                var passwordPolicy = GetPasswordPolicy(index);
                var isValidPassword = CheckForValidPassword(password, passwordPolicy);

                if (isValidPassword)
                    numberOfValidPasswords++;
            }

            return numberOfValidPasswords;
        }

        public int CountNumberOfValidPasswordsPartTwo()
        {
            var numberOfValidPasswords = 0;
            var input = ParseInput();

            foreach (var index in input)
            {
                var password = GetPassword(index);
                var passwordPolicy = GetPasswordPolicy(index);
                var isValidPassword = CheckForValidPasswordPartTwo(password, passwordPolicy);

                if (isValidPassword)
                    numberOfValidPasswords++;
            }

            return numberOfValidPasswords;
        }

        public string GetPasswordPolicy(string input)
        {
            var passwordPolicy = input.Split(Colon, StringSplitOptions.RemoveEmptyEntries)[0];

            return passwordPolicy;
        }

        public CharacterRange GetRangeOfAllowedCharacters(string passwordPolicy)
        {
            var allowedRange = passwordPolicy.Split(Hyphen, StringSplitOptions.RemoveEmptyEntries);

            var characterRange = new CharacterRange
            {
                Min = int.Parse(allowedRange[0]),
                Max = int.Parse(allowedRange[1].Remove(allowedRange[1].Length - 2))
            };

            return characterRange;
        }

        public string GetCharacterToCheck(string passwordPolicy)
        {
            var character = passwordPolicy.Substring(passwordPolicy.Length - 1);

            return character;
        }

        public string GetPassword(string input)
        {
            var password = input.Split(Colon, StringSplitOptions.RemoveEmptyEntries)[1];

            return password;
        }

        public bool CheckForValidPassword(string password, string passwordPolicy)
        {
            var numberOfAppearances = 0;
            var character = GetCharacterToCheck(passwordPolicy);

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i].ToString() == character)
                    numberOfAppearances++;
            }

            var characterRange = GetRangeOfAllowedCharacters(passwordPolicy);

            return numberOfAppearances >= characterRange.Min && numberOfAppearances <= characterRange.Max;
        }

        public bool CheckForValidPasswordPartTwo(string password, string passwordPolicy)
        {
            var character = GetCharacterToCheck(passwordPolicy);
            var characterRange = GetRangeOfAllowedCharacters(passwordPolicy);
            var positionOne = password[characterRange.Min - 1].ToString();
            var positionTwo = password[characterRange.Max - 1].ToString();

            return (character == positionOne && character != positionTwo) || (character == positionTwo && character != positionOne);
        }
    }

    public class CharacterRange
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
