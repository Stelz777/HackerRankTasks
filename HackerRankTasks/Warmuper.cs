using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTasks
{
    public class Warmuper
    {
        #region CountingValleys
        //https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        public int CountValleys(int arrayLength, string path)
        {
            int result = 0;

            int currentLevel = 0;
            int seaLevel = 0;
            int previousLevel = 0;
            foreach (var character in path)
            {
                if (character.ToString().Equals("U"))
                {
                    currentLevel++;
                }
                if (character.ToString().Equals("D"))
                {
                    currentLevel--;
                    if (currentLevel < seaLevel && previousLevel >= seaLevel)
                    {
                        result++;
                    }
                }
                previousLevel = currentLevel;
            }

            return result;

        }
        #endregion

        #region JumpingOnTheClouds
        //https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        public int FindMinJumpsOnClouds(int[] clouds)
        {
            int result = 0;
            for (int i = 0; i < clouds.Length - 1; i++)
            {
                if (i + 2 < clouds.Length && clouds[i + 2] == 0)
                {
                    result++;
                    i++;
                }
                else if (clouds[i + 1] == 0)
                {
                    result++;
                }
            }
            return result;

        }
        #endregion

        #region RepeatedString
        //https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        public long CountLetterInString(string inputString, string letter)
        {
            long counter = 0L;
            foreach (var character in inputString)
            {
                if (character.ToString().Equals(letter))
                {
                    counter++;
                }
            }
            return counter;
        }

        public long CountLetterA(string inputString, long symbolsAmount)
        {
            long result = 0L;
            long lettersInNormalString = CountLetterInString(inputString, "a");
            long divisionResult = symbolsAmount / inputString.Length;
            int modResult = Convert.ToInt32(symbolsAmount % inputString.Length);
            string modString = inputString.Substring(0, modResult);
            long lettersInSubstring = CountLetterInString(modString, "a");
            result = lettersInNormalString * divisionResult + lettersInSubstring;
            return result;

        }
        #endregion

        #region SockMerchant
        //https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        public int CalculatePairs(int socksAmount, int[] socks)
        {
            var result = 0;
            var socksByColor = new Dictionary<int, int>();
            for (int i = 0; i < socks.Length; i++)
            {
                if (socksByColor.ContainsKey(socks[i]))
                {
                    socksByColor[socks[i]]++;
                }
                else
                {
                    socksByColor.Add(socks[i], 1);
                }
            }
            foreach (var element in socksByColor)
            {
                result += element.Value / 2;
            }
            return result;

        }

        public int CalculatePairsWithLINQ(int socksAmount, int[] socks)
        {
            var socksByColor = socks.Aggregate(new Dictionary<int, int>(), (result, item) =>
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
                }
                return result;
            });

            return socksByColor.Sum(item => item.Value / 2);
        }
        #endregion

    }
}
