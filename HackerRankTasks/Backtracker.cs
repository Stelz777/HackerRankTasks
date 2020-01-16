using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class Backtracker
    {
        #region RecursionFibonacciNumbers
        //https://www.hackerrank.com/challenges/ctci-fibonacci-numbers/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=recursion-backtracking
        public int CalculateFibonacciNumber(int position)
        {
            if (position == 0)
            {
                return 0;
            }
            else if (position == 1)
            {
                return 1;
            }
            else
            {
                return CalculateFibonacciNumber(position - 1) + CalculateFibonacciNumber(position - 2);
            }
        }
        #endregion

        #region RecursionDavisStaircase
        //https://www.hackerrank.com/challenges/ctci-recursive-staircase/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=recursion-backtracking
        public int CalculateWaysAmountToClimbTheLadder(int stepsAmount)
        {
            if (stepsAmount == 1)
            {
                return 1;
            }
            var results = new int[stepsAmount + 1];
            results[0] = 1;
            return HelpToCalculateWaysForBigLadders(stepsAmount, results);
        }

        public int HelpToCalculateWaysForBigLadders(int stepsAmount, int[] results)
        {
            if (stepsAmount < 0)
            {
                return 0;
            }
            if (results[stepsAmount] != 0)
            {
                return results[stepsAmount];
            }
            if (stepsAmount == 1)
            {
                return 1;
            }
            results[stepsAmount] = HelpToCalculateWaysForBigLadders(stepsAmount - 3, results) + HelpToCalculateWaysForBigLadders(stepsAmount - 2, results) + HelpToCalculateWaysForBigLadders(stepsAmount - 1, results);
            return results[stepsAmount];
        }
        #endregion
    }
}
