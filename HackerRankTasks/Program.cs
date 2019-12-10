using System;
using System.Collections.Generic;

namespace HackerRankTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2DArrayDS
            int[][] numberArray = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                numberArray[i] = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            }
            ArrayWorker arrayWorker = new ArrayWorker();
            int result = arrayWorker.CalculateHourglassSum(numberArray);

            Console.WriteLine(result);
            #endregion

            #region ArrayManipulation
            string[] input = Console.ReadLine().Split(' ');

            int arrayLength = Convert.ToInt32(input[0]);

            int linesAmount = Convert.ToInt32(input[1]);

            int[][] queries = new int[linesAmount][];

            for (int i = 0; i < linesAmount; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long arrayManipulationResult = arrayWorker.FindMaxDifference(arrayLength, queries);

            Console.WriteLine(result);
            #endregion

            #region ArraysLeftRotation
            input = Console.ReadLine().Split(' ');

            arrayLength = Convert.ToInt32(input[0]);

            int offset = Convert.ToInt32(input[1]);

            int[] oneDimensionNumberArray = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            int[] resultArray = arrayWorker.RotateLeft(oneDimensionNumberArray, offset);

            Console.WriteLine(string.Join(" ", result));
            #endregion

            #region MinumumSwaps2
            arrayLength = Convert.ToInt32(Console.ReadLine());

            oneDimensionNumberArray = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            int minSwaps = arrayWorker.CalculateMinimumSwaps(oneDimensionNumberArray);

            Console.WriteLine(result);
            #endregion

            #region NewYearChaos
            int testsAmount = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testsAmount; i++)
            {
                int queueLength = Convert.ToInt32(Console.ReadLine());

                int[] queue = Array.ConvertAll(Console.ReadLine().Split(' '), tempQueue => Convert.ToInt32(tempQueue));
                string minBribes = arrayWorker.CalculateMinimumBribes(queue);
                results.Add(minBribes);
            }
            foreach (var minBribe in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
            #endregion

            #region CountingValleys
            arrayLength = Convert.ToInt32(Console.ReadLine());

            string path = Console.ReadLine();
            Warmuper warmuper = new Warmuper();
            int valleys = warmuper.CountValleys(arrayLength, path);

            Console.WriteLine(result);
            #endregion

            #region JumpingOnTheClouds
            int cloudsLength = Convert.ToInt32(Console.ReadLine());

            int[] clouds = Array.ConvertAll(Console.ReadLine().Split(' '), tempClouds => Convert.ToInt32(tempClouds));
            int minJumps = warmuper.FindMinJumpsOnClouds(clouds);

            Console.WriteLine(result);
            #endregion

            #region RepeatedString
            string inputString = Console.ReadLine();

            long symbolsAmount = Convert.ToInt64(Console.ReadLine());

            long letterCount = warmuper.CountLetterA(inputString, symbolsAmount);

            Console.WriteLine(result);
            #endregion

            #region ClassVsInstance
            testsAmount = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < testsAmount; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                CoderInThirtyDays instance = new CoderInThirtyDays(age);
                instance.PrintAge();
                for (int j = 0; j < 3; j++)
                {
                    instance.IncrementAge();
                }
                instance.PrintAge();
                Console.WriteLine();
            }
            #endregion

            #region DataTypes
            int defaultInteger = 4;
            double defaultDouble = 4.0;
            string defaultString = "HackerRank ";

            int inputInteger;
            double inputDouble;
            

            inputInteger = Convert.ToInt32(Console.ReadLine());
            inputDouble = Convert.ToDouble(Console.ReadLine());
            inputString = Console.ReadLine();

            Console.WriteLine(defaultInteger + inputInteger);

            Console.WriteLine(string.Format("{0:F1}", defaultDouble + inputDouble));

            Console.WriteLine(defaultString + inputString);

            Console.ReadLine();
            #endregion

            #region IntroToConditionalStatements
            int number = Convert.ToInt32(Console.ReadLine());
            CoderInThirtyDays coderInThirtyDays = new CoderInThirtyDays(3);
            Console.WriteLine(coderInThirtyDays.CalculateWeirdness(number));
            #endregion

            #region Loops
            number = Convert.ToInt32(Console.ReadLine());
            coderInThirtyDays.PrintMultiplies(number);
            #endregion

            #region Operators
            double mealCost = Convert.ToDouble(Console.ReadLine());

            int tipPercent = Convert.ToInt32(Console.ReadLine());

            int taxPercent = Convert.ToInt32(Console.ReadLine());

            coderInThirtyDays.CalculateTotalCost(mealCost, tipPercent, taxPercent);
            #endregion

            #region LetsReview
            testsAmount = Convert.ToInt32(Console.ReadLine());
            List<string> inputs = new List<string>();
            for (int i = 0; i < testsAmount; i++)
            {
                inputString = Console.ReadLine();
                inputs.Add(inputString);
            }
            foreach (var reviewInput in inputs)
            {
                string resultString = coderInThirtyDays.RegroupStringByEvenAndOddCharacters(reviewInput);
                Console.WriteLine(resultString);
            }
            #endregion
        }
    }
}
