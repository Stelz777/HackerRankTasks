using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class CoderInThirtyDays
    {
        #region ClassVsInstance
        //https://www.hackerrank.com/challenges/30-class-vs-instance/problem
        public int age;

        public CoderInThirtyDays(int initialAge)
        {
            if (initialAge >= 0)
            {
                age = initialAge;
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }

        public void PrintAge()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public string CalculateAge(int age)
        {
            if (age < 13)
            {
                return "You are young.";
            }
            else if (age >= 13 && age < 18)
            {
                return "You are a teenager.";
            }
            else
            {
                return "You are old.";
            }
        }

        public void IncrementAge()
        {
            age++;
        }

        #endregion

        #region DataTypes
        //https://www.hackerrank.com/challenges/30-data-types/problem
        public int SumIntegers(int secondInteger)
        {
            int i = 4;
            int result = i + secondInteger;
            return result;
        }

        public string SumDoubles(double secondDouble)
        {
            double d = 4.0;
            return string.Format("{0:F1}", d + secondDouble);
        }

        public string ConcatenateString(string secondString)
        {
            string s = "HackerRank ";
            return s + secondString;
        }
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
            return "";
        }
        #endregion

        #region Loops
        //https://www.hackerrank.com/challenges/30-loops/problem
        public string GetMultiple(int number, int currentIndex)
        {
            return number.ToString() + " x " + currentIndex.ToString() + " = " + (number * currentIndex).ToString();
        }

        public void PrintMultiplies(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(GetMultiple(number, i));
            }
        }
        #endregion

        #region Operators
        //https://www.hackerrank.com/challenges/30-operators/problem
        public string CalculateTotalCost(double mealCost, int tipPercent, int taxPercent)
        {
            string result = "";
            double tip = mealCost * tipPercent / 100.0;
            double tax = mealCost * taxPercent / 100.0;
            double totalCost = mealCost + tip + tax;
            int roundedTotalCost = Convert.ToInt32(Math.Round(totalCost));
            result = roundedTotalCost.ToString();
            Console.WriteLine(result);
            return result;
        }
        #endregion

        #region LetsReview
        public string RegroupStringByEvenAndOddCharacters(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i += 2)
            {
                result += input[i];
            }
            result += " ";
            for (int i = 1; i < input.Length; i += 2)
            {
                result += input[i];
            }
            return result;
        }
        #endregion
    }
}




