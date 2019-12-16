using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestHackerRank
{
    public class UnitTestHourglassSum
    {
        [Fact]
        public void CasualHourglassSumTest()
        {
            var array = new int[6][];
            array[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            array[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            array[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            array[3] = new int[] { 0, 0, 2, 4, 4, 0 };
            array[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            array[5] = new int[] { 0, 0, 1, 2, 4, 0 };
            var expectedResult = 19;
            var arrayWorker = new HackerRankTasks.ArrayWorker();
            int result = arrayWorker.CalculateHourglassSum(array);
            Assert.Equal(expectedResult, result);
        }

        public class UnitTestArrayManipulation
        {
            [Fact]
            public void CasualArrayManipulationTest()
            {
                var zerosAmount = 5;
                var queries = new int[][]
                {
                new int[] { 1, 2, 100 },
                new int[] { 2, 5, 100 },
                new int[] { 3, 4, 100 }
                };
                var expectedResult = 200L;
                TestEquality(zerosAmount, queries, expectedResult);
            }

            public void TestEquality(int zerosAmount, int[][] queries, long expectedResult)
            {
                var arrayWorker = new HackerRankTasks.ArrayWorker();
                long result = arrayWorker.FindMaxDifference(zerosAmount, queries);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestRotLeft
        {
            [Theory]
            [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 5, 1, 2, 3, 4 })]
            public void RotLeftTheory(int[] integerArray, int rotationsAmount, int[] expectedResult)
            {
                var arrayWorker = new HackerRankTasks.ArrayWorker();
                int[] result = arrayWorker.RotateLeft(integerArray, rotationsAmount);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestMinimumSwaps
        {
            [Theory]
            [InlineData(new int[] { 4, 3, 1, 2 }, 3)]
            [InlineData(new int[] { 2, 3, 4, 1, 5 }, 3)]
            [InlineData(new int[] { 1, 3, 5, 2, 4, 6, 7 }, 3)]
            public void MinimumSwapsTheory(int[] unorderedArray, int expectedResult)
            {
                var arrayWorker = new HackerRankTasks.ArrayWorker();
                int result = arrayWorker.CalculateMinimumSwaps(unorderedArray);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestMinimumBribes
        {
            [Theory]
            [InlineData(new int[] { 2, 1, 5, 3, 4 }, "3")]
            [InlineData(new int[] { 2, 5, 1, 3, 4 }, "Too chaotic")]
            [InlineData(new int[] { 5, 1, 2, 3, 7, 8, 6, 4 }, "Too chaotic")]
            [InlineData(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 }, "7")]
            public void MinimumBribesTheory(int[] queue, string expectedResult)
            {
                var arrayWorker = new HackerRankTasks.ArrayWorker();
                string result = arrayWorker.CalculateMinimumBribes(queue);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestCountingValleys
        {
            [Theory]
            [InlineData(8, "UDDDUDUU", 1)]
            [InlineData(12, "DDUUDDUDUUUD", 2)]
            public void CountingValleysTheory(int steps, string path, int expectedResult)
            {
                var warmuper = new HackerRankTasks.Warmuper();
                int result = warmuper.CountValleys(steps, path);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestJumpingOnClouds
        {
            [Theory]
            [InlineData(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
            [InlineData(new int[] { 0, 0, 0, 0, 1, 0 }, 3)]
            [InlineData(new int[] { 0, 0, 0, 1, 0, 0 }, 3)]
            public void JumpingOnCloudsTheory(int[] clouds, int expectedResult)
            {
                var warmuper = new HackerRankTasks.Warmuper();
                int result = warmuper.FindMinJumpsOnClouds(clouds);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestRepeatedString
        {
            [Theory]
            [InlineData("aba", 10, 7)]
            [InlineData("a", 1000000000000, 1000000000000)]
            public void RepeatedStringTheory(string stringToRepeat, long numberOfCharactersToConsider, long expectedResult)
            {
                var warmuper = new HackerRankTasks.Warmuper();
                long result = warmuper.CountLetterA(stringToRepeat, numberOfCharactersToConsider);
                Assert.Equal(expectedResult, result);
            }
        }

        public class SockMerchantTester
        {
            [Fact]
            public void TestNineSocksThreeColors()
            {
                var socksAmount = 9;
                var socks = new int[9] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
                var expectedResult = 3;
                TestEquality(socksAmount, socks, expectedResult);
            }

            [Fact]
            public void TestTenSocksThreeColors()
            {
                var socksAmount = 10;
                var socks = new int[10] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
                var expectedResult = 4;
                TestEquality(socksAmount, socks, expectedResult);
            }

            [Fact]
            public void TestHundredSocksOneColor()
            {
                var socksAmount = 100;
                var socks = new int[100];
                for (var i = 0; i < socksAmount; i++)
                {
                    socks[i] = 42;
                }
                var expectedResult = 50;
                TestEquality(socksAmount, socks, expectedResult);
            }

            [Fact]
            public void TestHundredSocksTwentyEightPairs()
            {
                var socksAmount = 100;
                var socks = new int[100]
                {
                50, 49, 38, 49, 78, 36, 25, 96, 10, 67, 78,
                58, 98,  8, 53,  1,  4,  7, 29,  6, 59, 93,
                74,  3, 67, 47, 12, 85, 84, 40, 81, 85, 89,
                70, 33, 66,  6,  9, 13, 67, 75, 42, 24, 73,
                49, 28, 25,  5, 86, 53, 10, 44, 45, 35, 47,
                11, 81, 10, 47, 16, 49, 79, 52, 89, 100, 36,
                 6, 57, 96, 18, 23, 71, 11, 99, 95, 12, 78,
                19, 16, 64, 23, 77,  7, 19, 11,  5, 81, 43,
                14, 27, 11, 63, 57, 62,  3, 56, 50, 9, 13, 45
                };
                var expectedResult = 28;
                TestEquality(socksAmount, socks, expectedResult);
            }

            [Fact]
            public void TestThreeSocksThreeColors()
            {
                var socksAmount = 3;
                var socks = new int[3] { 10, 20, 30 };
                var expectedResult = 0;
                TestEquality(socksAmount, socks, expectedResult);
            }

            [Fact]
            public void TestOneSockOneColor()
            {
                var socksAmount = 1;
                var socks = new int[1] { 100 };
                var expectedResult = 0;
                TestEquality(socksAmount, socks, expectedResult);
            }

            [Fact]
            public void TestHundredSocksThirtyPairs()
            {
                var socksAmount = 100;
                var socks = new int[100]
                {
                44, 55, 11, 15,  4, 72, 26, 91, 80, 14,
                43, 78, 70, 75, 36, 83, 78, 91, 17, 17,
                54, 65, 60, 21, 58, 98, 87, 45, 75, 97,
                81, 18, 51, 43, 84, 54, 66, 10, 44, 45,
                23, 38, 22, 44, 65,  9, 78, 42, 100, 94,
                58,  5, 11, 69, 26, 20, 19, 64, 64, 93,
                60, 96, 10, 10, 39, 94, 15,  4,  3, 10,
                 1, 77, 48, 74, 20, 12, 83, 97,  5, 82,
                43, 15, 86,  5, 35, 63, 24, 53, 27, 87,
                45, 38, 34,  7, 48, 24, 100, 14, 80, 54
                };
                var expectedResult = 30;
                TestEquality(socksAmount, socks, expectedResult);

            }

            [Fact]
            public void TestTwentySocksFiveColors()
            {
                var socksAmount = 20;
                var socks = new int[20]
                {
                4, 5, 5, 5, 6, 6, 4, 1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5
                };
                var expectedResult = 9;
                TestEquality(socksAmount, socks, expectedResult);
            }

            [Fact]
            public void TestFifteenSocksFiveColors()
            {
                var socksAmount = 15;
                var socks = new int[15] { 6, 5, 2, 3, 5, 2, 2, 1, 1, 5, 1, 3, 3, 3, 5 };
                var expectedResult = 6;
                TestEquality(socksAmount, socks, expectedResult);
            }

            public void TestEquality(int socksAmount, int[] socks, int expectedResult)
            {
                var warmuper = new HackerRankTasks.Warmuper();
                int result = warmuper.CalculatePairsWithLINQ(socksAmount, socks);
                Assert.Equal(expectedResult, result);
            }

            [Theory]
            [InlineData(100, new int[] { 50, 49, 38, 49, 78, 36, 25, 96, 10, 67, 78,
                58, 98,  8, 53,  1,  4,  7, 29,  6, 59, 93,
                74,  3, 67, 47, 12, 85, 84, 40, 81, 85, 89,
                70, 33, 66,  6,  9, 13, 67, 75, 42, 24, 73,
                49, 28, 25,  5, 86, 53, 10, 44, 45, 35, 47,
                11, 81, 10, 47, 16, 49, 79, 52, 89, 100, 36,
                 6, 57, 96, 18, 23, 71, 11, 99, 95, 12, 78,
                19, 16, 64, 23, 77,  7, 19, 11,  5, 81, 43,
                14, 27, 11, 63, 57, 62,  3, 56, 50, 9, 13, 45}, 28)]
            [InlineData(3, new int[] { 10, 20, 30 }, 0)]
            [InlineData(1, new int[] { 100 }, 0)]
            [InlineData(100, new int[] { 44, 55, 11, 15,  4, 72, 26, 91, 80, 14,
                43, 78, 70, 75, 36, 83, 78, 91, 17, 17,
                54, 65, 60, 21, 58, 98, 87, 45, 75, 97,
                81, 18, 51, 43, 84, 54, 66, 10, 44, 45,
                23, 38, 22, 44, 65,  9, 78, 42, 100, 94,
                58,  5, 11, 69, 26, 20, 19, 64, 64, 93,
                60, 96, 10, 10, 39, 94, 15,  4,  3, 10,
                 1, 77, 48, 74, 20, 12, 83, 97,  5, 82,
                43, 15, 86,  5, 35, 63, 24, 53, 27, 87,
                45, 38, 34,  7, 48, 24, 100, 14, 80, 54 }, 30)]
            [InlineData(20, new int[] { 4, 5, 5, 5, 6, 6, 4, 1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5 }, 9)]
            [InlineData(15, new int[] { 6, 5, 2, 3, 5, 2, 2, 1, 1, 5, 1, 3, 3, 3, 5 }, 6)]
            public void TestTheory(int socksAmount, int[] socks, int expectedResult)
            {
                var warmuper = new HackerRankTasks.Warmuper();
                int result = warmuper.CalculatePairsWithLINQ(socksAmount, socks);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestAmIOld
        {
            [Theory]
            [InlineData(-1, "You are young.")]
            [InlineData(10, "You are young.")]
            [InlineData(16, "You are a teenager.")]
            [InlineData(18, "You are old.")]
            public void AmIOldTheory(int age, string expectedResult)
            {
                var person = new HackerRankTasks._30_Days_of_Code.Person(age);
                string result = person.CalculateAge(age);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestCalculateResult
        {
            [Theory]
            [InlineData(12, 16)]
            [InlineData(3, 7)]
            public void SumIntegersTheory(int secondInteger, int expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                int result = coderInThirtyDays.SumIntegers(secondInteger);
                Assert.Equal(expectedResult, result);

            }

            [Theory]
            [InlineData(4.0, "8,0")]
            [InlineData(2.8, "6,8")]
            public void SumDoublesTheory(double secondDouble, string expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThirtyDays.SumDoubles(secondDouble);
                Assert.Equal(expectedResult, result);
            }

            [Theory]
            [InlineData("is the best place to learn and practice coding!", "HackerRank is the best place to learn and practice coding!")]
            [InlineData("is my favorite platform!", "HackerRank is my favorite platform!")]
            public void ConcatenateStringsTheory(string secondString, string expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThirtyDays.ConcatenateString(secondString);
                Assert.Equal(expectedResult, result);
            }


        }

        public class UnitTestCalculateWeirdness
        {
            [Theory]
            [InlineData(3, "Weird")]
            [InlineData(24, "Not Weird")]
            public void TestTheory(int number, string expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThirtyDays.CalculateWeirdness(number);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestGetMultiple
        {
            [Theory]
            [InlineData(2, 1, "2 x 1 = 2")]
            [InlineData(2, 10, "2 x 10 = 20")]
            public void GetMultipleTheory(int number, int currentIndex, string expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThirtyDays.GetMultipleExpression(number, currentIndex);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestSolve
        {
            [Theory]
            [InlineData(12.00, 20, 8, "15")]
            public void SolveTheory(double mealCost, int tipPercent, int taxPercent, string expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThirtyDays.CalculateTotalCost(mealCost, tipPercent, taxPercent);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestLetsReview
        {
            [Theory]
            [InlineData("Hacker", "Hce akr")]
            [InlineData("Rank", "Rn ak")]
            public void RegroupStringByEvenAndOddCharactersTheory(string input, string expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThirtyDays.RegroupStringByEvenAndOddCharacters(input);
                Assert.Equal(expectedResult, result);
            }

        }

        public class UnitTestArrays
        {
            [Theory]
            [InlineData(new int[] { 1, 4, 3, 2 }, "2 3 4 1")]
            public void ReverseArrayTheory(int[] input, string expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThirtyDays.ReverseArray(input);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestHashTablesRansomNote
        {
            [Theory]
            [InlineData(new string[] { "two", "times", "three", "is", "not", "four" }, new string[] { "two, times, two, is, four" }, "No")]
            [InlineData(new string[] { "ive", "got", "a", "lovely", "bunch", "of", "coconuts" }, new string[] { "ive", "got", "some", "coconuts" }, "No")]
            [InlineData(new string[] { "o", "l", "x", "imjaw", "bee", "khmla", "v", "o", "v", "o", "imjaw", "l", "khmla", "imjaw", "x" }, new string[] { "imjaw", "l", "khmla", "x", "imjaw", "o", "l", "l", "o", "khmla", "v", "bee", "o", "o", "imjaw", "imjaw", "o" }, "No")]
            public void CheckMagazineTheory(string[] magazine, string[] note, string expectedResult)
            {
                var dictionaryWorker = new HackerRankTasks.DictionaryWorker();
                string result = dictionaryWorker.CheckMagazine(magazine, note);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestBubbleSort
        {
            [Theory]
            [InlineData(new int[] { 1, 2, 3 }, new string[] { "Array is sorted in 0 swaps.", "First Element: 1", "Last Element: 3" })]
            public void CountSwapsTheory(int[] input, string[] expectedResult)
            {
                var sorter = new HackerRankTasks.Sorter();
                string[] result = sorter.CountSwaps(input);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestDictionariesAndMaps
        {
            [Theory]
            [InlineData("sam", "sam=99912222")]
            [InlineData("edward", "Not found")]
            [InlineData("harry", "harry=12299933")]
            public void FindNumberInPhoneBookTheory(string name, string expectedResult)
            {
                var phoneBook = new Dictionary<string, string>
                {
                    { "sam", "99912222" },
                    { "tom", "11122222" },
                    { "harry", "12299933" }
                };
                var coderInThiryDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThiryDays.FindNumberInPhoneBook(phoneBook, name);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestMakingAnagrams
        {
            [Theory]
            [InlineData("cde", "abc", 4)]
            [InlineData("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke", 30)]
            public void CountDeletionsToMakeAnagramTheory(string firstString, string secondString, int expectedResult)
            {
                var stringManipulator = new HackerRankTasks.StringManipulator();
                int result = stringManipulator.CountDeletionsToMakeAnagram(firstString, secondString);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestRecursion3
        {
            [Theory]
            [InlineData(3, 6)]
            public void CalculateFactorialTheory(int number, int expectedResult)
            {
                var coderInThiryDays = new HackerRankTasks.CoderInThirtyDays();
                int result = coderInThiryDays.CalculateFactorial(number);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestMinimumAbsoluteDifferenceInArray
        {
            [Theory]
            [InlineData(new int[] { 3, -7, 0 }, 3)]
            [InlineData(new int[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 }, 1)]
            [InlineData(new int[] { 1, -3, 71, 68, 17 }, 3)]
            public void CalculateMinimumAbsoluteDifferenceTheory(int[] input, int expectedResult)
            {
                var greedyWorker = new HackerRankTasks.GreedyWorker();
                int result = greedyWorker.CalculateMinimumAbsoluteDifference(input);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestHashTablesIceCreamParlor
        {
            [Theory]
            [InlineData(new int[] { 1, 4, 5, 3 ,2 }, 4, "1 4")]
            [InlineData(new int[] { 2, 2, 4, 3 }, 4, "1 2")]
            public void WhatFlavorsTheory(int[] cost, int money, string expectedResult)
            {
                var searcher = new HackerRankTasks.Searcher();
                string result = searcher.WhatFlavors(cost, money);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestBinaryNumbers
        {
            [Theory]
            [InlineData(5, "101")]
            [InlineData(13, "1101")]
            public void ConvertToBinaryTheory(int number, string expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                string result = coderInThirtyDays.ConvertToBinary(number);
                Assert.Equal(expectedResult, result);
            }

            [Theory]
            [InlineData(5, 1)]
            [InlineData(13, 2)]
            public void CountConsecutiveOnesTheory(int number, int expectedResult)
            {
                var coderInThirtyDays = new HackerRankTasks.CoderInThirtyDays();
                int result = coderInThirtyDays.CountConsecutiveOnes(number);
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestInheritance
        {
            [Theory]
            [InlineData("Heraldo", "Memelli", 8135627, new int[] { 100, 80 }, 'O')]
            public void CalculateTheory(string firstName, string lastName, int id, int[] scores, char expectedResult)
            {
                var student = new HackerRankTasks._30_Days_of_Code.Student(firstName, lastName, id, scores);
                char result = student.Calculate();
                Assert.Equal(expectedResult, result);
            }
        }

        public class UnitTestMaxArraySum
        {
            [Theory]
            [InlineData(new int[] { 3, 7, 4, 6, 5 }, 13)]
            [InlineData(new int[] { 2, 1, 5, 8, 4 }, 11)]
            [InlineData(new int[] { 3, 5, -7, 8, 10 }, 15)]
            public void CalculateMaxSubsetSumTheory(int[] input, int expectedResult)
            {
                var dynamicProgrammer = new HackerRankTasks.DynamicProgrammer();
                int result = dynamicProgrammer.CalculateMaxSubsetSum(input);
                Assert.Equal(expectedResult, result);
            }
        }

    }
}
