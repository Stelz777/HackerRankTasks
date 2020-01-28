using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class StackWorker
    {
        #region BalancedBrackets
        //https://www.hackerrank.com/challenges/balanced-brackets/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=stacks-queues

        private string yesAnswer = "YES";
        private string noAnswer = "NO";

        public string ProcessClosingBracket(Stack<char> brackets, char openingBracket)
        {
            if (brackets.Count > 0 && brackets.Peek() == openingBracket)
            {
                brackets.Pop();
                return yesAnswer;
            }
            else
            {
                return noAnswer;
            }
        }

        public string SolveBracketsBalanceInExpression(string expression)
        {
            var brackets = new Stack<char>();
            for (var i = 0; i < expression.Length; i++)
            {
                switch (expression[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        brackets.Push(expression[i]);
                        break;
                    case ')':
                        if (ProcessClosingBracket(brackets, '(').Equals(noAnswer))
                        {
                            return noAnswer;
                        }
                        break;
                    case '}':
                        if (ProcessClosingBracket(brackets, '{').Equals(noAnswer))
                        {
                            return noAnswer;
                        }
                        break;
                    case ']':
                        if (ProcessClosingBracket(brackets, '[').Equals(noAnswer))
                        {
                            return noAnswer;
                        }
                        break;
                }
            }
            if (brackets.Count == 0)
            {
                return yesAnswer;
            }
            else
            {
                return noAnswer;
            }
        }
        #endregion

        #region QueuesATaleOfTwoStacks
        //https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=stacks-queues
        private Stack<int> oldStack = new Stack<int>();
        private Stack<int> newStack = new Stack<int>();

        public void Put(int value)
        {
            oldStack.Push(value);
        }

        public void Pop()
        {
            TransferOneStackToEmptyAnother(oldStack, newStack);
            newStack.Pop();
        }

        public int Peek()
        {
            TransferOneStackToEmptyAnother(oldStack, newStack);
            return newStack.Peek();
        }

        public void TransferOneStackToEmptyAnother(Stack<int> source, Stack<int> target)
        {
            if (target.Count == 0)
            {
                TransferAllElementsFromOneStackToAnother(source, target);
            }
        }

        public void TransferAllElementsFromOneStackToAnother(Stack<int> source, Stack<int> target)
        {
            while (source.Count != 0)
            {
                target.Push(source.Pop());
            }
        }
        #endregion

        #region CastleOnTheGrid
        //https://www.hackerrank.com/challenges/castle-on-the-grid/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=stacks-queues
        public int CalculateMinimumMovesToReachGoal(string[] grid, int startX, int startY, int goalX, int goalY)
        {
            return 0;
        }
        #endregion

        #region LargestRectangle
        //https://www.hackerrank.com/challenges/largest-rectangle/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=stacks-queues
        public void StoreHeightCount(Dictionary<int, int> heights, int height, int count)
        {
            if (heights.ContainsKey(height))
            {
                heights[height] += count;
            }
            else
            {
                heights.Add(height, count);
            }
        }
        
        public long CalculateLargestRectangle(int[] height)
        {
            var current = new Stack<int>();
            var heights = new Dictionary<int, int>();
            int maxRectangle = 0;

            if (height.Length > 0)
            {
                current.Push(height[0]);
                StoreHeightCount(heights, height[0], 1);
            }

            for (var i = 1; i < height.Length; i++)
            {
                int peek = current.Peek();
                if (peek > height[i])
                {
                    int count = 0;
                    while (current.Count != 0 && peek > height[i])
                    {
                        current.Pop();
                        count = heights[peek];
                        if (count * peek > maxRectangle)
                        {
                            maxRectangle = count * peek;
                        }
                        heights[peek] = 0;
                        peek = current.Count == 0 ? 0 : current.Peek();
                    }
                    if (peek < height[i])
                    {
                        current.Push(height[i]);
                        StoreHeightCount(heights, height[i], count);
                    }
                }
                else if (peek < height[i])
                {
                    current.Push(height[i]);
                }
                foreach (var uniqueHeight in current)
                {
                    StoreHeightCount(heights, uniqueHeight, 1);
                }
            }
            foreach (var uniqueHeight in heights.Keys)
            {
                int temp = heights[uniqueHeight] * uniqueHeight;
                if (temp > maxRectangle)
                {
                    maxRectangle = temp;
                }
            }
            return maxRectangle;
        }
        #endregion
    }
}
