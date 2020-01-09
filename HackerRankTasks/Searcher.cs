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

        #region SwapNodesAlgo
        public int[][] SwapNodes(int[][] indexes, int[] queries)
        {
            var result = new int[][] { };
            var root = new _30_Days_of_Code.TreeNode(1);
            for (int i = 0; i < indexes.Length; i++)
            {
                InsertIndex(ref root, i + 1, indexes[i]);
            }
            for (int i = 0; i < queries.Length; i++)
            {
                ReverseAtDepth(ref root, queries[i]);
                result[i] = new int[] { };
                TreeToArray(root, ref result[i], 0);
            }
            return result;
        }

        public void TreeToArray(_30_Days_of_Code.TreeNode root, ref int[] result, int counter)
        {
            if (root == null)
            {
                return;
            }
            TreeToArray(root.left, ref result, counter);
            result[counter] = root.data;
            counter++;
            TreeToArray(root.right, ref result, counter);
        }

        public void InsertIndex(ref _30_Days_of_Code.TreeNode root, int value, int[] indexes)
        {
            if (root != null)
            {
                if (root.data == value)
                {
                    InsertNode(ref root.left, indexes[0]);
                    InsertNode(ref root.right, indexes[1]);
                }
                else
                {
                    InsertIndex(ref root.left, value, indexes);
                    InsertIndex(ref root.right, value, indexes);
                }
            }
        }

        public void InsertNode(ref _30_Days_of_Code.TreeNode node, int value)
        {
            if (value == -1)
            {
                node = null;
            }
            else
            {
                node = new _30_Days_of_Code.TreeNode(value);
            }
        }

        public void ReverseAtDepth(ref _30_Days_of_Code.TreeNode root, int query)
        {
            int level = 0;
            var queue = new Queue<_30_Days_of_Code.TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Count > 0)
            {
                _30_Days_of_Code.TreeNode temp = queue.Dequeue();
                if (temp == null)
                {
                    level++;
                    queue.Enqueue(null);
                    if (queue.Peek() == null)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (level == query)
                {
                    _30_Days_of_Code.TreeNode leftChild = temp.left;
                    _30_Days_of_Code.TreeNode rightChild = temp.right;
                    temp.left = rightChild;
                    temp.right = leftChild;
                }
            }
        }
        #endregion
    }
}
