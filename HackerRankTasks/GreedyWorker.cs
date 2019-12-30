using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class GreedyWorker
    {
        #region MinimumAbsoluteDifferenceInAnArray
        //https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms
        public int CalculateMinimumAbsoluteDifference(int[] input)
        {
            var min = int.MaxValue;
            Array.Sort(input);
            for (int i = 0; i < input.Length - 1; i++)
            {
                int currentMin = Math.Abs(input[i + 1] - input[i]);
                if (currentMin < min)
                {
                    min = currentMin;
                }
                if (min == 0)
                {
                    return min;
                }
            }
            return min;
        }
        #endregion

        #region LuckBalance
        //https://www.hackerrank.com/challenges/luck-balance/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms
        public int CalculateLuckBalance(int maxImportantLoses, int[][] contests)
        {
            var result = 0;
            var importantContests = new List<int>();
            for (var i = 0; i < contests.Length; i++)
            {
                if (contests[i][1] == 0)
                {
                    result += contests[i][0];
                }
                else if (contests[i][1] == 1)
                {
                    importantContests.Add(contests[i][0]);
                }
            }
            importantContests.Sort();
            importantContests.Reverse();
            for (var i = 0; i < importantContests.Count; i++)
            {
                if (maxImportantLoses > 0)
                {
                    result += importantContests[i];
                    maxImportantLoses--;
                }
                else
                {
                    result -= importantContests[i];
                }
            }
            return result;
        }
        #endregion
    }
}
