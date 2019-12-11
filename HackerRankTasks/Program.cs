﻿using System;
using System.Collections.Generic;
using HackerRankTasks._30_Days_of_Code;

namespace HackerRankTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Run2DArrayDS();

            RunArrayManipulation();

            RunArraysLeftRotation();

            RunMinimumSwaps2();

            RunNewYearChaos();

            RunCountingValleys();

            RunJumpingOnTheClouds();

            RunRepeatedString();

            RunClassVsInstance();

            RunDataTypes();

            RunIntroToConditionalStatements();

            RunLoops();

            RunOperators();

            RunLetsReview();

            RunArrays();
        }

        static void RunArrays()
        {
            var arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));

            var coderInThirtyDays = new CoderInThirtyDays();
            Console.WriteLine(coderInThirtyDays.ReverseArray(numberArray));
        }

        static void Run2DArrayDS()
        {
            var numberArray = new int[6][];

            for (var i = 0; i < 6; i++)
            {
                numberArray[i] = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            }
            var arrayWorker = new ArrayWorker();
            int result = arrayWorker.CalculateHourglassSum(numberArray);

            Console.WriteLine(result);
        }

        static void RunArrayManipulation()
        {
            string[] input = Console.ReadLine().Split(' ');

            var arrayLength = Convert.ToInt32(input[0]);

            var linesAmount = Convert.ToInt32(input[1]);

            var queries = new int[linesAmount][];

            for (int i = 0; i < linesAmount; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }
            var arrayWorker = new ArrayWorker();
            long arrayManipulationResult = arrayWorker.FindMaxDifference(arrayLength, queries);

            Console.WriteLine(arrayManipulationResult);
        }

        static void RunArraysLeftRotation()
        {
            string[] input = Console.ReadLine().Split(' ');

            var arrayLength = Convert.ToInt32(input[0]);

            var offset = Convert.ToInt32(input[1]);

            var oneDimensionNumberArray = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            var arrayWorker = new ArrayWorker();
            int[] resultArray = arrayWorker.RotateLeft(oneDimensionNumberArray, offset);

            Console.WriteLine(string.Join(" ", resultArray));
        }

        static void RunMinimumSwaps2()
        {
            var arrayLength = Convert.ToInt32(Console.ReadLine());

            var oneDimensionNumberArray = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            var arrayWorker = new ArrayWorker();
            int minSwaps = arrayWorker.CalculateMinimumSwaps(oneDimensionNumberArray);

            Console.WriteLine(minSwaps);
        }

        static void RunNewYearChaos()
        {
            var testsAmount = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            for (var i = 0; i < testsAmount; i++)
            {
                var queueLength = Convert.ToInt32(Console.ReadLine());

                int[] queue = Array.ConvertAll(Console.ReadLine().Split(' '), tempQueue => Convert.ToInt32(tempQueue));
                var arrayWorker = new ArrayWorker();
                string minBribes = arrayWorker.CalculateMinimumBribes(queue);
                results.Add(minBribes);
            }
            Console.WriteLine(string.Join(System.Environment.NewLine, results));
            Console.ReadLine();
        }

        static void RunCountingValleys()
        {
            var arrayLength = Convert.ToInt32(Console.ReadLine());

            var path = Console.ReadLine();
            var warmuper = new Warmuper();
            int valleys = warmuper.CountValleys(arrayLength, path);

            Console.WriteLine(valleys);
        }

        static void RunJumpingOnTheClouds()
        {
            var cloudsLength = Convert.ToInt32(Console.ReadLine());

            int[] clouds = Array.ConvertAll(Console.ReadLine().Split(' '), tempClouds => Convert.ToInt32(tempClouds));
            var warmuper = new Warmuper();
            int minJumps = warmuper.FindMinJumpsOnClouds(clouds);

            Console.WriteLine(minJumps);
        }

        static void RunRepeatedString()
        {
            var inputString = Console.ReadLine();

            var symbolsAmount = Convert.ToInt64(Console.ReadLine());
            var warmuper = new Warmuper();
            long letterCount = warmuper.CountLetterA(inputString, symbolsAmount);

            Console.WriteLine(letterCount);
        }

        static void RunClassVsInstance()
        {
            var testsAmount = int.Parse(Console.In.ReadLine());
            for (var i = 0; i < testsAmount; i++)
            {
                var age = int.Parse(Console.In.ReadLine());
                var person = new Person(age);
                person.PrintAge();
                for (var j = 0; j < 3; j++)
                {
                    person.IncrementAge();
                }
                person.PrintAge();
                Console.WriteLine();
            }
        }

        static void RunDataTypes()
        {
            var defaultInteger = 4;
            var defaultDouble = 4.0;
            var defaultString = "HackerRank ";
            var inputInteger = Convert.ToInt32(Console.ReadLine());
            var inputDouble = Convert.ToDouble(Console.ReadLine());
            var inputString = Console.ReadLine();

            Console.WriteLine(defaultInteger + inputInteger);

            Console.WriteLine(string.Format("{0:F1}", defaultDouble + inputDouble));

            Console.WriteLine(defaultString + inputString);

            Console.ReadLine();
        }

        static void RunIntroToConditionalStatements()
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var coderInThirtyDays = new CoderInThirtyDays();
            Console.WriteLine(coderInThirtyDays.CalculateWeirdness(number));
        }

        static void RunLoops()
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var coderInThirtyDays = new CoderInThirtyDays();
            coderInThirtyDays.PrintMultiplies(number);
        }

        static void RunOperators()
        {
            var mealCost = Convert.ToDouble(Console.ReadLine());

            var tipPercent = Convert.ToInt32(Console.ReadLine());

            var taxPercent = Convert.ToInt32(Console.ReadLine());
            var coderInThirtyDays = new CoderInThirtyDays();
            coderInThirtyDays.CalculateTotalCost(mealCost, tipPercent, taxPercent);
        }

        static void RunLetsReview()
        {
            var testsAmount = Convert.ToInt32(Console.ReadLine());
            var inputs = new List<string>();
            for (var i = 0; i < testsAmount; i++)
            {
                var inputString = Console.ReadLine();
                inputs.Add(inputString);
            }
            foreach (var reviewInput in inputs)
            {
                var coderInThirtyDays = new CoderInThirtyDays();
                var resultString = coderInThirtyDays.RegroupStringByEvenAndOddCharacters(reviewInput);
                Console.WriteLine(resultString);
            }
        }
    }
}
