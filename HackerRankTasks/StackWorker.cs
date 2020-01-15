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
    }
}
