using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Days
{
    public class Day1Problem
    {
        public List<int> ParseInput()
        {
            List<int> input = File.ReadLines(@"ProblemInputs\Day1.txt")
                .Select(x => Convert.ToInt32(x))
                .ToList();

            return input;
        }

        public int MultiplyTwoNumbers(List<int> entries)
        {
            int answer = 0;
            entries = ParseInput();

            for (int i = 1; i < entries.Count; i++)
            {
                for (int j = 2; j < entries.Count; j++)
                {
                    int firstNum = entries[i - 1];
                    int secondNum = entries[j];

                    answer = firstNum + secondNum;

                    if (answer == 2020)
                    {
                        answer = firstNum * secondNum;
                        return answer;
                    }
                }
            }

            return answer;
        }

        public int MultiplyThreeNumbers()
        {
            int answer = 0;
            List<int> entries = ParseInput();

            for (int i = 2; i < entries.Count; i++)
            {
                for (int j = 3; j < entries.Count; j++)
                {
                    for (int k = 4; k < entries.Count; k++)
                    {
                        int firstNum = entries[i - 2];
                        int secondNum = entries[j - 1];
                        int thirdNum = entries[k];

                        answer = firstNum + secondNum + thirdNum;

                        if (answer == 2020)
                        {
                            answer = firstNum * secondNum * thirdNum;
                            return answer;
                        }
                    }
                }
            }

            return answer;
        }
    }
}
