using System;
using System.Collections.Generic;
using System.Linq;
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

        #region MarkAndToys
        //https://www.hackerrank.com/challenges/mark-and-toys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
        public int BuyMaximumToys(int[] prices, int money)
        {
            var result = 0;
            Array.Sort(prices);
            foreach (var price in prices)
            {
                money -= price;
                if (money >= 0)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
        #endregion

        #region FraudlentActivityNotifications
        //https://www.hackerrank.com/challenges/fraudulent-activity-notifications/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
        public int CountDaysWhenNotificationsWereSent(int[] spentMoney, int trailingDays)
        {
            var currentSpent = new List<int>();
            var notificationsCounter = 0;
            for (int i = 0; i < spentMoney.Length; i++)
            {
                if (i < trailingDays)
                {
                    currentSpent.Add(spentMoney[i]);
                    continue;
                }
                else
                {
                    currentSpent.Sort();
                    double median = FindMedian(currentSpent);
                    currentSpent.Add(spentMoney[i]);
                    
                    if (spentMoney[i] >= 2 * median)
                    {
                        notificationsCounter++;
                    }
                }
            }
            return notificationsCounter;
        }

        public double FindMedian(List<int> workingCopy)
        {
            if (workingCopy.Count % 2 == 0)
            {
                return workingCopy[workingCopy.Count / 2];
            }
            else
            {
                return (double)(workingCopy[workingCopy.Count / 2] + workingCopy[workingCopy.Count / 2 - 1]) / (double) 2;
            }
        }

        #endregion
    }
}
