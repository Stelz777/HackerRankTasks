using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class Searcher
    {
        #region HashTablesIceCreamParlor
        public string WhatFlavors(int[] cost, int money)
        {
            var iceCreams = new Dictionary<int, int>();
            for (var i = 0; i < cost.Length; i++)
            {
                int complement = money - cost[i];
                if (iceCreams.ContainsKey(complement))
                {
                    int output;
                    if (iceCreams.TryGetValue(complement, out output))
                    {

                    }
                    return $"{ output } { i + 1 }";
                }
                if (!iceCreams.ContainsKey(cost[i]))
                {
                    iceCreams.Add(cost[i], i + 1);
                }
            }
            return string.Empty;
        }
        #endregion
    }
}
