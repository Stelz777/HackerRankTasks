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
    }
}
