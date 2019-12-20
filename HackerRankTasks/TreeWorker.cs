using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankTasks
{
    public class TreeWorker
    {
        #region BalancedForest

        public int CalculateMinimumValueToCreateBalancedForest(int[] values, int[][] edges)
        {
            var min = -1;
            var additions = new List<int>();
            for (var i = 0; i < edges.Length; i++)
            {
                for (var b = 0; b < 2; b++)
                {
                    for (var j = i + 1; j < edges.Length; j++)
                    {
                        var firstSubTree = new Dictionary<int, int>();
                        var secondSubTree = new Dictionary<int, int>();
                        var thirdSubTree = new Dictionary<int, int>();
                        var trees = new List<Dictionary<int, int>>();
                        trees.Add(firstSubTree);
                        trees.Add(secondSubTree);
                        trees.Add(thirdSubTree);
                        for (var k = 0; k < edges.Length; k++)
                        {
                            if (b == 0)
                            {
                                if (k == i)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                if (k == i || k == j)
                                {
                                    continue;
                                }
                            }
                            var isFound = false;
                            foreach (var tree in trees)
                            {
                                if (tree.ContainsKey(edges[k][0]))
                                {
                                    isFound = true;
                                    if (!tree.ContainsKey(edges[k][1]))
                                    {
                                        tree.Add(edges[k][1], values[edges[k][1] - 1]);
                                    }
                                }
                                else if (tree.ContainsKey(edges[k][1]))
                                {
                                    isFound = true;
                                    if (!tree.ContainsKey(edges[k][0]))
                                    {
                                        tree.Add(edges[k][0], values[edges[k][0] - 1]);
                                    }
                                }
                            }
                            if (!isFound)
                            {
                                foreach (var tree in trees)
                                {
                                    if (tree.Count == 0)
                                    {
                                        tree.Add(edges[k][0], values[edges[k][0] - 1]);
                                        tree.Add(edges[k][1], values[edges[k][1] - 1]);
                                        break;
                                    }
                                }
                                
                            }
                        }

                        foreach (var tree in trees)
                        {
                            foreach (var anotherTree in trees)
                            {
                                if (tree != anotherTree)
                                {
                                    foreach (var key in anotherTree.Keys)
                                    {
                                        if (tree.ContainsKey(key))
                                        {
                                            foreach (var element in anotherTree)
                                            {
                                                if (!tree.ContainsKey(element.Key))
                                                {
                                                    tree.Add(element.Key, element.Value);
                                                }
                                            }
                                            foreach (var element in anotherTree)
                                            {
                                                anotherTree.Remove(element.Key);
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        for (var k = 0; k < values.Length; k++)
                        {
                            var notAlone = false;
                            foreach (var tree in trees)
                            {
                                if (tree.ContainsKey(k + 1))
                                {
                                    notAlone = true;
                                    break;
                                }
                            }
                            if (!notAlone)
                            {
                                var isAdded = false;
                                foreach (var tree in trees)
                                {
                                    if (tree.Count == 0)
                                    {
                                        isAdded = true;
                                        tree.Add(k + 1, values[k]);
                                        break;
                                    }
                                }
                                if (!isAdded)
                                {
                                    for (var l = 0; l < edges.Length; l++)
                                    {
                                        var success = false;
                                        if ((b == 0 && l != i) || (b == 1 && l != i && l != j))
                                        {
                                            if (edges[l][0] == k + 1)
                                            {
                                                foreach (var tree in trees)
                                                {
                                                    if (tree.ContainsKey(edges[l][1]))
                                                    {
                                                        tree.Add(k + 1, values[k]);
                                                        success = true;
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (edges[l][1] == k + 1)
                                            {
                                                foreach (var tree in trees)
                                                {
                                                    if (tree.ContainsKey(edges[l][0]))
                                                    {
                                                        tree.Add(k + 1, values[k]);
                                                        success = true;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        if (success)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        var sums = new List<int>();
                        foreach (var tree in trees)
                        {
                            sums.Add(tree.Values.Sum());
                        }
                        var isValidCut = false;
                        var firstEqualIndex = -1;
                        var secondEqualIndex = -1;
                        var currentSum = 0;
                        for (var k = 0; k < sums.Count; k++)
                        {
                            for (var l = k + 1; l < sums.Count; l++)
                            {
                                if (sums[k] == sums[l])
                                {
                                    isValidCut = true;
                                    firstEqualIndex = k;
                                    secondEqualIndex = l;
                                    currentSum = sums[k];

                                }
                            }
                        }
                        if (isValidCut)
                        {
                            for (var k = 0; k < sums.Count; k++)
                            {
                                if (k != firstEqualIndex && k != secondEqualIndex)
                                {
                                    int addition = currentSum - sums[k];
                                    if (addition >= 0)
                                    {
                                        additions.Add(addition);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (additions.Count == 0)
            {
                return min;
            }
            else
            {
                foreach (var addition in additions)
                {
                    Console.WriteLine(addition);
                }
                return additions.Min();
            }
        }
        #endregion
    }
}
