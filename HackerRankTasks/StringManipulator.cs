using System;
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

        #region SherlockAndValidString
        //https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        public string CheckValidity(string input)
        {
            var lettersAndCounters = CreateDictionaryLetterToCounter(input);
            bool oneIsMore = false;
            int initialValue = lettersAndCounters.Values.ElementAt(0);
            for (int i = 1; i < lettersAndCounters.Count; i++)
            {
                int currentValue = lettersAndCounters.Values.ElementAt(i);
                if (currentValue == initialValue)
                {
                    continue;
                }
                else if (currentValue == 1 && !oneIsMore)
                {
                    oneIsMore = true;
                }
                else if (Math.Abs(currentValue - initialValue) == 1 && !oneIsMore)
                {
                    oneIsMore = true;
                }
                else
                {
                    return "NO";
                }
                
            }
            return "YES";
        }

        public Dictionary<char, int> CreateDictionaryLetterToCounter(string input)
        {
            var result = new Dictionary<char, int>();
            foreach (var character in input)
            {
                if (result.ContainsKey(character))
                {
                    result[character]++;
                }
                else
                {
                    result.Add(character, 1);
                }
            }
            return result;
        }

        #endregion
    }
}
