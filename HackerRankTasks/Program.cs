using System;
using System.Collections.Generic;
using System.Linq;
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

            RunHashTablesRansomNote();

            RunBubbleSort();

            RunDictionariesAndMaps();

            RunMakingAnagrams();

            RunRecursion3();

            RunMinimumAbsoluteDifferenceInAnArray();

            RunHashTablesIceCreamParlor();

            RunBinaryNumbers();

            RunInheritance();

            RunMaxArraySum();

            RunAbstractClasses();

            RunBalancedBrackets();

            RunScope();

            RunRoadsAndLibraries();

            RunLinkedList();

            RunBalancedForest();

            RunExceptionsStringToInteger();

            RunInsertANodeAtASpecificPositionInALinkedList();

            RunBotSavesPrincess();

            RunMoreExceptions();

            RunQueuesAndStacks();

            RunInterfaces();

            RunRecursionFibonacciNumbers();

            RunBotSavesPrincess2();

            RunFlippingBits();

            RunBotClean();

            RunGenerics();

            RunTwoStrings();

            RunBotCleanStochastic();

            RunBinarySearchTrees();

            RunMarkAndToys();

            RunBotCleanLarge();

            RunBSTLevelOrderTraversal();

            RunAlternatingCharacters();

            RunBotCleanPartiallyObservable();
        }

        static void RunBotCleanPartiallyObservable()
        {
            var temp = Console.ReadLine();
            String[] positions = temp.Split(' ');
            var position = new int[2];
            var board = new String[5];
            for (var i = 0; i < 5; i++)
            {
                board[i] = Console.ReadLine();
            }
            for (var i = 0; i < 2; i++)
            {
                position[i] = Convert.ToInt32(positions[i]);
            }
            var artificialIntelligenceWorker = new ArtificialIntelligenceWorker();
            Console.WriteLine(artificialIntelligenceWorker.NextPartiallyObservableMove(position[0], position[1], board));
        }

        static void RunAlternatingCharacters()
        {
            var testsAmount = Convert.ToInt32(Console.ReadLine());
            var stringManipulator = new StringManipulator();
            for (var i = 0; i < testsAmount; i++)
            {
                var input = Console.ReadLine();

                int result = stringManipulator.CalculateSymbolsToDeleteAmountToGetFavourableString(input);

                Console.WriteLine(result);
            }
        }

        static void RunBSTLevelOrderTraversal()
        {
            TreeNode root = null;
            var nodesAmount = Int32.Parse(Console.ReadLine());
            var coderInThirtyDays = new CoderInThirtyDays();
            while (nodesAmount-- > 0)
            {
                var data = Int32.Parse(Console.ReadLine());
                root = coderInThirtyDays.InsertIntoTree(root, data);
            }
            List<int> result = coderInThirtyDays.GetBreadthFirstAllNodesInTree(root);
            foreach (var item in result)
            {
                Console.Write($"{ item } ");
            }
        }

        static void RunBotCleanLarge()
        {
            var temp = Console.ReadLine();
            String[] positions = temp.Split(' ');
            var position = new int[2];
            for (var i = 0; i < 2; i++)
            {
                position[i] = Convert.ToInt32(positions[i]);
            }
            String[] dimensions = Console.ReadLine().Split(' ');
            var dimension = new int[2];
            for (var i = 0; i < 2; i++)
            {
                dimension[i] = Convert.ToInt32(dimensions[i]);
            }
            var board = new String[dimension[0]];
            for (var i = 0; i < dimension[0]; i++)
            {
                board[i] = Console.ReadLine();
            }
            var artificialIntelligenceWorker = new ArtificialIntelligenceWorker();
            Console.WriteLine(artificialIntelligenceWorker.NextMegaMaidMove(position[0], position[1], dimension[0], dimension[1], board));
        }

        static void RunMarkAndToys()
        {
            string[] inputs = Console.ReadLine().Split(' ');

            var arrayLength = Convert.ToInt32(inputs[0]);

            var money = Convert.ToInt32(inputs[1]);

            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
            var sorter = new Sorter();
            int result = sorter.BuyMaximumToys(prices, money);

            Console.WriteLine(result);
        }

        static void RunBinarySearchTrees()
        {
            TreeNode root = null;
            var nodesAmount = Int32.Parse(Console.ReadLine());
            var coderInThirtyDays = new CoderInThirtyDays();
            while (nodesAmount-- > 0)
            {
                var data = Int32.Parse(Console.ReadLine());
                root = coderInThirtyDays.InsertIntoTree(root, data);
            }
            int height = coderInThirtyDays.GetTreeHeight(root);
            Console.WriteLine(height);
        }

        static void RunBotCleanStochastic()
        {
            var artificialIntelligenceWorker = new ArtificialIntelligenceWorker();
            var temp = Console.ReadLine();
            String[] positions = temp.Split(' ');
            var position = new int[2];
            var board = new String[5];
            for (var i = 0; i < 5; i++)
            {
                board[i] = Console.ReadLine();
            }
            for (var i = 0; i < 2; i++)
            {
                position[i] = Convert.ToInt32(positions[i]);
            }
            Console.WriteLine(artificialIntelligenceWorker.NextCleanBotStochasticMove(position[0], position[1], board));
        }

        static void RunTwoStrings()
        {
            var testsAmount = Convert.ToInt32(Console.ReadLine());
            var dictionaryWorker = new DictionaryWorker();
            for (var i = 0; i < testsAmount; i++)
            {
                var firstString = Console.ReadLine();

                var secondString = Console.ReadLine();
                
                string result = dictionaryWorker.CheckIfStringsHaveCommonSubstring(firstString, secondString);

                Console.WriteLine(result);
            }
        }

        static void RunGenerics()
        {
            var coderInThirtyDays = new CoderInThirtyDays();
            var arrayLength = Convert.ToInt32(Console.ReadLine());
            var intArray = new int[arrayLength];
            for (var i = 0; i < arrayLength; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            arrayLength = Convert.ToInt32(Console.ReadLine());
            var stringArray = new string[arrayLength];
            for (var i = 0; i < arrayLength; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            coderInThirtyDays.PrintArray<Int32>(intArray);
            coderInThirtyDays.PrintArray<String>(stringArray);
        }

        static void RunBotClean()
        {
            var artificialIntelligenceWorker = new ArtificialIntelligenceWorker();
            var temp = Console.ReadLine();
            String[] positions = temp.Split(' ');
            var position = new int[2];
            var board = new String[5];
            for (var i = 0; i < 5; i++)
            {
                board[i] = Console.ReadLine();
            }
            for (var i = 0; i < 2; i++)
            {
                position[i] = Convert.ToInt32(positions[i]);
            }
            Console.WriteLine(artificialIntelligenceWorker.NextCleanBotMove(position[0], position[1], board));
        }

        static void RunFlippingBits()
        {
            var testsAmount = Convert.ToInt32(Console.ReadLine());
            var miscellaneousWorker = new MiscellaneousWorker();
            for (var i = 0; i < testsAmount; i++)
            {
                var number = Convert.ToInt64(Console.ReadLine());

                long result = miscellaneousWorker.FlipBits(number);

                Console.WriteLine(result);
            }
        }

        static void RunBotSavesPrincess2()
        {
            var artificialIntelligenceWorker = new ArtificialIntelligenceWorker();

            var gridSize = int.Parse(Console.ReadLine());
            
            var position = Console.ReadLine();
            String[] positions = position.Split(' ');
            var numberPositions = new int[2];
            numberPositions[0] = Convert.ToInt32(positions[0]);
            numberPositions[1] = Convert.ToInt32(positions[1]);
            var grid = new String[gridSize];
            for (var i = 0; i < gridSize; i++)
            {
                grid[i] = Console.ReadLine();
            }

            Console.WriteLine(artificialIntelligenceWorker.NextMove(gridSize, numberPositions[0], numberPositions[1], grid));
        }

        static void RunRecursionFibonacciNumbers()
        {
            var position = Convert.ToInt32(Console.ReadLine());
            var backtracker = new Backtracker();
            Console.WriteLine(backtracker.CalculateFibonacciNumber(position));
        }

        static void RunInterfaces()
        {
            var number = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.CalculateDivisorsSum(number);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }

        static void RunQueuesAndStacks()
        {
            var input = Console.ReadLine();
            var coderInThirtyDays = new CoderInThirtyDays();
            Console.WriteLine(coderInThirtyDays.IsPalindrome(input));
        }

        static void RunMoreExceptions()
        {
            var calculator = new Calculator();
            var testsAmount = Int32.Parse(Console.ReadLine());
            while (testsAmount-- > 0)
            {
                string[] inputs = Console.ReadLine().Split();
                var baseNumber = int.Parse(inputs[0]);
                var exponent = int.Parse(inputs[1]);
                try
                {
                    string answer = calculator.Power(baseNumber, exponent);
                    Console.WriteLine(answer);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);

                }
            }
        }

        static void RunBotSavesPrincess()
        {
            int fieldSize;

            fieldSize = int.Parse(Console.ReadLine());

            var grid = new String[fieldSize];
            for (var i = 0; i < fieldSize; i++)
            {
                grid[i] = Console.ReadLine();
            }
            var artificialIntelligenceWorker = new ArtificialIntelligenceWorker();
            List<string> result = artificialIntelligenceWorker.CalculatePathToPrincess(grid);
            foreach (var direction in result)
            {
                Console.WriteLine(direction);
            }
        }

        static void RunInsertANodeAtASpecificPositionInALinkedList()
        {
            var linkedList = new Linked_Lists.SinglyLinkedList();

            var linkedListCount = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < linkedListCount; i++)
            {
                var linkedListItem = Convert.ToInt32(Console.ReadLine());
                linkedList.InsertNode(linkedListItem);
            }

            var data = Convert.ToInt32(Console.ReadLine());

            var position = Convert.ToInt32(Console.ReadLine());

            Linked_Lists.SinglyLinkedListNode linkedListHead = linkedList.InsertNodeAtPosition(linkedList.head, data, position);

            linkedList.PrintSinglyLinkedList(linkedListHead, " ");
            Console.WriteLine();
        }

        static void RunExceptionsStringToInteger()
        {
            var input = Console.ReadLine();
            var coderInThirtyDays = new CoderInThirtyDays();
            Object result = coderInThirtyDays.ConvertStringToInteger(input);
            Console.WriteLine(result);
        }

        static void RunBalancedForest()
        {
            var testsAmount = Convert.ToInt32(Console.ReadLine());
            var treeWorker = new TreeWorker();
            for (var testIterator = 0; testIterator < testsAmount; testIterator++)
            {
                var nodesAmount = Convert.ToInt32(Console.ReadLine());

                int[] nodes = Array.ConvertAll(Console.ReadLine().Split(' '), nodeTemp => Convert.ToInt32(nodeTemp));

                var edges = new int[nodesAmount - 1][];

                for (var i = 0; i < nodesAmount - 1; i++)
                {
                    edges[i] = Array.ConvertAll(Console.ReadLine().Split(' '), edgesTemp => Convert.ToInt32(edgesTemp));
                }

                int result = treeWorker.CalculateMinimumValueToCreateBalancedForest(nodes, edges);

                Console.WriteLine(result);
            }
        }

        static void RunLinkedList()
        {
            Node head = null;
            var testsAmount = Int32.Parse(Console.ReadLine());
            var coderInThirtyDays = new CoderInThirtyDays();
            while (testsAmount-- > 0)
            {
                var data = Int32.Parse(Console.ReadLine());
                head = coderInThirtyDays.InsertNodeToLinkedList(head, data);
            }
            coderInThirtyDays.DisplayLinkedList(head);
        }
        static void RunRoadsAndLibraries()
        {
            var queriesAmount = Convert.ToInt32(Console.ReadLine());
            var graphWorker = new GraphWorker();
            for (var queryIterator = 0; queryIterator < queriesAmount; queryIterator++)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                var citiesAmount = Convert.ToInt32(inputs[0]);

                var roadsAmount = Convert.ToInt32(inputs[1]);

                var libraryCost = Convert.ToInt32(inputs[2]);

                var roadCost = Convert.ToInt32(inputs[3]);

                var cities = new int[roadsAmount][];

                for (var i = 0; i < roadsAmount; i++)
                {
                    cities[i] = Array.ConvertAll(Console.ReadLine().Split(' '), citiesTemp => Convert.ToInt32(citiesTemp));
                }

                long result = graphWorker.CalculateBuildingCost(citiesAmount, libraryCost, roadCost, cities);

                Console.WriteLine(result);
            }
        }

        static void RunScope()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] numberArray = Console.ReadLine().Split(' ').Select(number => Convert.ToInt32(number)).ToArray();

            var difference = new Difference(numberArray);

            difference.ComputeDifference();

            Console.Write(difference.maximumDifference);
        }
        static void RunBalancedBrackets()
        {
            var testsAmount = Convert.ToInt32(Console.ReadLine());
            var stackWorker = new StackWorker();
            for (var i = 0; i < testsAmount; i++)
            {
                var expression = Console.ReadLine();

                string result = stackWorker.SolveBracketsBalanceInExpression(expression);

                Console.WriteLine(result);
            }
        }

        static void RunAbstractClasses()
        {
            var title = Console.ReadLine();
            var author = Console.ReadLine();
            var price = Int32.Parse(Console.ReadLine());
            var newNovel = new MyBook(title, author, price);
            newNovel.Display();
        }

        static void RunMaxArraySum()
        {
            var number = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            var dynamicProgrammer = new DynamicProgrammer();
            int result = dynamicProgrammer.CalculateMaxSubsetSum(numberArray);

            Console.WriteLine(result);
        }

        static void RunInheritance()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            var id = Convert.ToInt32(inputs[2]);
            var numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            var scores = new int[numScores];
            for (var i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            var student = new Student(firstName, lastName, id, scores);
            student.PrintPerson();
            Console.WriteLine("Grade: " + student.Calculate() + "\n");
        }

        static void RunBinaryNumbers()
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var coderInThirtyDays = new CoderInThirtyDays();
            Console.WriteLine(coderInThirtyDays.CountConsecutiveOnes(number));
        }

        static void RunHashTablesIceCreamParlor()
        {
            List<string> results = new List<string>();
            var testsAmount = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < testsAmount; i++)
            {
                var money = Convert.ToInt32(Console.ReadLine());

                var arrayLength = Convert.ToInt32(Console.ReadLine());

                int[] cost = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), costTemp => Convert.ToInt32(costTemp));
                var searcher = new Searcher();
                string result = searcher.WhatFlavors(cost, money);
                results.Add(result);
            }
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        static void RunMinimumAbsoluteDifferenceInAnArray()
        {
            var arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            var greedyWorker = new GreedyWorker();
            int result = greedyWorker.CalculateMinimumAbsoluteDifference(input);

            Console.WriteLine(result);
        }

        static void RunRecursion3()
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var coderInThirtyDays = new CoderInThirtyDays();
            int result = coderInThirtyDays.CalculateFactorial(number);

            Console.WriteLine(result);
        }

        static void RunMakingAnagrams()
        {
            var firstString = Console.ReadLine();

            var secondString = Console.ReadLine();
            var stringManipulator = new StringManipulator();
            int result = stringManipulator.CountDeletionsToMakeAnagram(firstString, secondString);

            Console.WriteLine(result);   
        }

        static void RunDictionariesAndMaps()
        {
            var entriesLength = Convert.ToInt32(Console.ReadLine());
            var input = new string[entriesLength];
            for (var i = 0; i < entriesLength; i++)
            {
                input[i] = Console.ReadLine();
            }
            var coderInThirtyDays = new CoderInThirtyDays();
            Dictionary<string, string> phoneBook = coderInThirtyDays.GeneratePhoneBook(input);
            string name;
            var names = new List<string>();
            while ((name = Console.ReadLine()) != null)
            {
                names.Add(name);
            }
            foreach (var nameElement in names)
            {
                string result = coderInThirtyDays.FindNumberInPhoneBook(phoneBook, nameElement);
                Console.WriteLine(result);
            }
            
        }

        static void RunBubbleSort()
        {
            var arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = Array.ConvertAll(Console.ReadLine().Split(' '), tempArray => Convert.ToInt32(tempArray));
            var sorter = new Sorter();
            string[] result = sorter.CountSwaps(numberArray);
            foreach (var row in result)
            {
                Console.WriteLine(row);
            }
        }

        static void RunHashTablesRansomNote()
        {
            string[] input = Console.ReadLine().Split(' ');

            var magazineLength = Convert.ToInt32(input[0]);

            var noteLength = Convert.ToInt32(input[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            var dictionaryWorker = new DictionaryWorker();
            Console.WriteLine(dictionaryWorker.CheckMagazine(magazine, note));
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
