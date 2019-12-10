using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankTasks
{
    public class ArrayWorker
    {
        #region 2DArrayDS
        //https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        public int CalculateHourglassSum(int[][] numberArray)
        {
            int result = 0;
            List<int> sums = new List<int>();
            for (int i = 0; i < numberArray.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < numberArray[i].Length - 2; j++)
                {
                    int sum = numberArray[i][j] + numberArray[i][j + 1] + numberArray[i][j + 2] + numberArray[i + 1][j + 1] + numberArray[i + 2][j] + numberArray[i + 2][j + 1] + numberArray[i + 2][j + 2];
                    sums.Add(sum);
                }
            }
            result = sums.Max();
            return result;
        }
        #endregion

        #region ArrayManipulation
        //https://www.hackerrank.com/challenges/crush/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        public int[] InitializeDifferences(int[] array, int[] differences)
        {
            int arrayLength = array.Length;
            differences[0] = array[0];
            differences[arrayLength] = 0;
            for (int i = 1; i < arrayLength; i++)
            {
                differences[i] = array[i] - array[i - 1];
            }
            return differences;
        }

        public int[] UpdateDifferences(int[] differences, int start, int end, int value)
        {
            differences[start] += value;
            differences[end] -= value;
            return differences;
        }

        public long FindMaxDifference(int arrayLength, int[][] queries)
        {
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = 0;
            }
            int[] differences = new int[arrayLength + 1];
            differences = InitializeDifferences(array, differences);
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                differences = UpdateDifferences(differences, queries[i][0], queries[i][1], queries[i][2]);
            }
            return differences.Max();
        }
        #endregion

        #region ArraysLeftRotation
        //https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        public int[] RotateLeft(int[] array, int offset)
        {

            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i - offset >= 0)
                {
                    result[i - offset] = array[i];
                }
                else
                {
                    result[array.Length + i - offset] = array[i];
                }
            }

            return result;
        }
        #endregion

        #region MinimumSwaps2
        //https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        public int CalculateMinimumSwaps(int[] numberArray)
        {
            int result = 0;
            int i = 0;
            while (i < numberArray.Length - 1)
            {
                if (numberArray[i] != i + 1)
                {
                    int temp = numberArray[i];
                    numberArray[i] = numberArray[temp - 1];
                    numberArray[temp - 1] = temp;
                    result++;
                }
                else
                {
                    i++;
                }
            }
            return result;
        }
        #endregion

        #region NewYearChaos
        //https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        public string CalculateMinimumBribes(int[] queue)
        {
            int score = 0;
            for (int i = queue.Length - 1; i >= 0; i--)
            {
                if (queue[i] - (i + 1) > 2)
                {
                    return "Too chaotic";

                }
                for (int j = Math.Max(0, queue[i] - 2); j < i; j++)
                {
                    if (queue[j] > queue[i])
                    {
                        score++;
                    }
                }
            }

            return score.ToString();
        }
        #endregion
    }
}
