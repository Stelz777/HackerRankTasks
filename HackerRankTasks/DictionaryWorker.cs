﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class DictionaryWorker
    {
        #region HashTablesRansomNote
        //https://www.hackerrank.com/challenges/ctci-ransom-note/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        public Dictionary<string, int> ConvertArrayToDictionary(string[] input)
        {
            var result = new Dictionary<string, int>();
            foreach (var word in input)
            {
                if (!result.ContainsKey(word))
                {
                    result.Add(word, 1);
                }
                else
                {
                    result[word]++;
                }

            }
            return result;
        }


        public string CheckMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> magazineDictionary = ConvertArrayToDictionary(magazine);
            foreach (var word in note)
            {
                if (!magazineDictionary.ContainsKey(word))
                {
                    return "No";
                }
                else
                {
                    magazineDictionary[word]--;
                    if (magazineDictionary[word] < 0)
                    {
                        return "No";
                    }
                }
            }
            return "Yes";
        }
        #endregion
    }
}
