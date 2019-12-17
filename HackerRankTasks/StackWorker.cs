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
    }
}
