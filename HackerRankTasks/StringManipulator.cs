﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankTasks
{
    public class StringManipulator
    {
        #region MakingAnagrams
        //https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        public int CountDeletionsToMakeAnagram(string firstString, string secondString)
        {
            var result = 0;
            for (var character = 'a'; character <= 'z'; character++)
            {
                int counterInFirstString = firstString.Count(current => current == character);
                int counterInSecondString = secondString.Count(current => current == character);
                int min = Math.Min(counterInFirstString, counterInSecondString);
                result += (counterInFirstString - min);
                result += (counterInSecondString - min);
            }
            return result;
        }
        #endregion

        #region AlternatingCharacters
        //https://www.hackerrank.com/challenges/alternating-characters/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        public int CalculateSymbolsToDeleteAmountToGetFavourableString(string input)
        {
            var result = 0;
            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    result++;
                }
            }
            return result;
        }
        #endregion
    }
}
