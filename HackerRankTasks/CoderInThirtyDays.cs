﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class CoderInThirtyDays
    {
        


        #region DataTypes
        //https://www.hackerrank.com/challenges/30-data-types/problem
        public int SumIntegers(int secondInteger)
        {
            var i = 4;
            int result = i + secondInteger;
            return result;
        }

        public string SumDoubles(double secondDouble)
        {
            var d = 4.0;
            return (d + secondDouble).ToString("{0:F1}");
        }

        public string ConcatenateString(string secondString)
            => $"HackerRank { secondString }";
        
        #endregion

        #region IntroToConditionalStatements
        //https://www.hackerrank.com/challenges/30-conditional-statements/problem
        public string CalculateWeirdness(int number)
        {
            if (number % 2 == 1)
            {
                return "Weird";
            }
            else
            {
                if (number >= 2 && number <= 5)
                {
                    return "Not Weird";
                }
                else if (number >= 6 && number <= 20)
                {
                    return "Weird";
                }
                else if (number > 20)
                {
                    return "Not Weird";
                }
            }
            return string.Empty;
        }
        #endregion

        #region Loops
        //https://www.hackerrank.com/challenges/30-loops/problem
        public string GetMultipleExpression(int number, int currentIndex)
            => $"{ number } x { currentIndex } = { number * currentIndex }";        

        public void PrintMultiplies(int number)
        {
            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine(GetMultipleExpression(number, i));
            }
        }
        #endregion

        #region Operators
        //https://www.hackerrank.com/challenges/30-operators/problem
        public string CalculateTotalCost(double mealCost, int tipPercent, int taxPercent)
        {
            double tip = mealCost * tipPercent / 100.0;
            double tax = mealCost * taxPercent / 100.0;
            double totalCost = mealCost + tip + tax;
            var roundedTotalCost = Convert.ToInt32(Math.Round(totalCost));
            var totalCostStringPresentation = roundedTotalCost.ToString();
            Console.WriteLine(totalCostStringPresentation);
            return totalCostStringPresentation;
        }
        #endregion

        #region LetsReview
        //https://www.hackerrank.com/challenges/30-review-loop/problem
        public string RegroupStringByEvenAndOddCharacters(string input)
        {
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < input.Length; i += 2)
            {
                stringBuilder.Append(input[i]);
            }
            stringBuilder.Append(' ');
            for (var i = 1; i < input.Length; i += 2)
            {
                stringBuilder.Append(input[i]);
            }
            return stringBuilder.ToString();
        }
        #endregion

        #region Arrays
        //https://www.hackerrank.com/challenges/30-arrays/problem
        public string ReverseArray(int[] input)
        {
            int[] temp = input;
            Array.Reverse(temp);
            return string.Join(' ', temp);
        }
        #endregion

        #region DictionariesAndMaps
        //https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
        public Dictionary<string, string> GeneratePhoneBook(string[] input)
        {
            var result = new Dictionary<string, string>();
            foreach (var record in input)
            {
                string[] splitRecord = record.Split(' ');
                result.Add(splitRecord[0], splitRecord[1]);
            }
            return result;
        }

        public string FindNumberInPhoneBook(Dictionary<string, string> phoneBook, string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                return $"{ name }={ phoneBook[name] }";
            }
            else
            {
                return "Not found";
            }
        }
        #endregion
    }
}




