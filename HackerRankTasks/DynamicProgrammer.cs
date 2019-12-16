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
    }
}
