using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Days
{
    public class Day1Problem
    {
        public int GetAnswerPartOne(List<int> numbers)
        {
            var answer = 0;
            answer = SortThroughTwoNumbers(numbers, answer);

            return answer;
        }

        public object GetAnswerPartTwo(List<int> numbers)
        {
            var answer = 0;
            answer = SortThroughThreeNumbers(numbers, answer);

            return answer;
        }

        private int SortThroughTwoNumbers(List<int> numbers, int answer)
        {
            for (var i = 1; i < numbers.Count; i++)
            {
                for (var j = 2; j < numbers.Count; j++)
                {
                    var numberOne = numbers[i - 1];
                    var numberTwo = numbers[j];

                    var sum = AddNumbers(numberOne, numberTwo);

                    if (sum == 2020)
                    {
                        answer = MultiplyNumbers(numberOne, numberTwo);
                        break;
                    }
                }
            }

            return answer;
        }

        private int SortThroughThreeNumbers(List<int> numbers, int answer)
        {
            for (int i = 2; i < numbers.Count; i++)
            {
                for (int j = 3; j < numbers.Count; j++)
                {
                    for (int k = 4; k < numbers.Count; k++)
                    {
                        int numberOne = numbers[i - 2];
                        int numberTwo = numbers[j - 1];
                        int numberThree = numbers[k];

                        var sum = AddNumbers(numberOne, numberTwo, numberThree);

                        if (sum == 2020)
                        {
                            answer = MultiplyNumbers(numberOne, numberTwo, numberThree);
                            break;
                        }
                    }
                }
            }

            return answer;
        }

        private int AddNumbers(int numberOne, int numberTwo, int numberThree = 0)
        {
            return numberOne + numberTwo + numberThree;
        }

        private int MultiplyNumbers(int numberOne, int numberTwo, int numberThree = 1)
        {
            return numberOne * numberTwo * numberThree;
        }
    }
}
