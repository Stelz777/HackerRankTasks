using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankTasks
{
    public class DynamicProgrammer
    {
        #region MaxArraySum
        //https://www.hackerrank.com/challenges/max-array-sum/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dynamic-programming
        public int FindMaxOfTwoNumbers(int first, int second)
        {
            return first > second ? first : second;
        }

        public int CalculateMaxSubsetSum(int[] input)
        {
            var maxes = new int[input.Length];
            maxes[0] = input[0];
            maxes[1] = FindMaxOfTwoNumbers(input[0], input[1]);
            int maxSum = FindMaxOfTwoNumbers(maxes[0], maxes[1]);
            for (var i = 2; i < input.Length; i++)
            {
                var current = new List<int>();
                current.Add(input[i]);
                current.Add(maxSum);
                current.Add(maxes[i - 2] + input[i]);
                maxes[i] = current.Max();
                maxSum = FindMaxOfTwoNumbers(maxSum, maxes[i]);
            }
            return maxSum;
        }
        #endregion

        #region Abbreviation
        public string FindOutCanWeTransformOneStringToAnother(string transformingString, string targetString)
        {
            string positiveResult = "YES";
            string negativeResult = "NO";
            int targetLetterCounter = 0;
            if (!CheckLengthCondition(transformingString, targetString))
            {
                return negativeResult;
            }
            char lastCharacter = '0';
            foreach (var characterInTarget in targetString)
            {
                if (!CheckLetterFromOneStringInAnother(ref transformingString, characterInTarget, ref targetLetterCounter, ref lastCharacter))
                {
                    return negativeResult;
                }
            }
            if (!CheckOnlyLowerLetters(transformingString))
            {
                return negativeResult;
            }
            if (targetLetterCounter == targetString.Length)
            {
                return positiveResult;
            }
            return negativeResult;
        }

        public bool CheckLetterFromOneStringInAnother(ref string transformingString, char characterInTarget, ref int targetLetterCounter, ref char lastCharacter)
        {
            bool isFound = false;
            for (int i = 0; i < transformingString.Length; i++)
            {
                if (char.IsUpper(transformingString[i]) && transformingString[i] != characterInTarget)
                {
                    if (char.ToUpper(lastCharacter) != transformingString[i])
                    {
                        return false;
                    }
                }
                if (char.ToUpper(transformingString[i]) == characterInTarget)
                {
                    targetLetterCounter++;
                    lastCharacter = transformingString[i];
                    transformingString = transformingString.Remove(0, i + 1);
                    isFound = true;
                    
                    break;
                }
                lastCharacter = transformingString[i];
            }
            if (!isFound)
            {
                return false;
            }
            return true;
        }

        public bool CheckOnlyLowerLetters(string transformingString)
        {
            foreach (var character in transformingString)
            {
                if (Char.IsUpper(character))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckLengthCondition(string transformingString, string targetString)
        {
            if (transformingString.Length < targetString.Length)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
