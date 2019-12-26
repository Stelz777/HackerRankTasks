using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks._30_Days_of_Code
{
    public class TreeNode
    {
        public TreeNode left, right;
        public int data;
        public TreeNode(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
