using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks._30_Days_of_Code
{
    public class Calculator : AdvancedArithmetic
    {
        //https://www.hackerrank.com/challenges/30-more-exceptions/problem

        public string Power(int baseNumber, int exponent)
        {
            var exceptionMessage = "n and p should be non-negative";
            try
            {
                if (baseNumber < 0 || exponent < 0)
                {
                    throw new Exception(exceptionMessage);
                }
                double result = Math.Pow(Convert.ToDouble(baseNumber), Convert.ToDouble(exponent));
                return result.ToString();
            }
            catch
            {
                return exceptionMessage;
            }
        }

        public int CalculateDivisorsSum(int number)
        {
            var result = 0;
            for (var i = number; i > 0; i--)
            {
                if (number % i == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
