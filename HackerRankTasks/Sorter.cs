using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class Sorter
    {
        #region BubbleSort
        //https://www.hackerrank.com/challenges/ctci-bubble-sort/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
        public string[] CountSwaps(int[] input)
        {
            var counter = 0;
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                        counter++;
                    }
                }
            }
            var result = new string[3];
            result[0] = $"Array is sorted in { counter } swaps.";
            result[1] = $"First Element: { input[0] }";
            result[2] = $"Last Element: { input[input.Length - 1] }";
            return result;
        }
        #endregion
    }
}
