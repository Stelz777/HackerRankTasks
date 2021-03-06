﻿using HackerRankTasks._30_Days_of_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        #region Recursion3
        //https://www.hackerrank.com/challenges/30-recursion/problem
        public int CalculateFactorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorial(number - 1);
            }
        }
        #endregion



        #region BinaryNumbers
        //https://www.hackerrank.com/challenges/30-binary-numbers/problem
        public string ConvertToBinary(int number)
        {
            var result = new StringBuilder();
            while (number / 2 > 0)
            {
                result.Append(number % 2);
                number /= 2;
            }
            result.Append(number % 2);
            var resultString = result.ToString();
            int length = resultString.Length - 1;
            var reversedString = new char[length + 1];
            resultString.ToCharArray().ToList().ForEach(character =>
            {
                reversedString[length] = character;
                length--;
            });
            return new string(reversedString);
        }

        public int CountConsecutiveOnes(int number)
        {
            string binaryNumber = ConvertToBinary(number);
            var maxConsecutive = 1;
            var previousNumber = '2';
            var currentConsecutive = 0;
            for (var i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] != previousNumber)
                {
                    currentConsecutive = 1;
                }
                else
                {
                    currentConsecutive++;
                    if (currentConsecutive > maxConsecutive)
                    {
                        maxConsecutive = currentConsecutive;
                    }
                }
                previousNumber = binaryNumber[i];
            }
            return maxConsecutive;
        }
        #endregion

        #region LinkedList
        //https://www.hackerrank.com/challenges/30-linked-list/problem
        public Node InsertNodeToLinkedList(Node head, int data)
        {
            var newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node start = head;
                while (start.next != null)
                {
                    start = start.next;
                }
                start.next = newNode;
            }
            return head;
        }

        public void DisplayLinkedList(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write($"{ start.data } ");
                start = start.next;
            }
        }
        #endregion

        #region ExceptionsStringToInteger
        //https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem
        public Object ConvertStringToInteger(string input)
        {
            try
            {
                return Int32.Parse(input);
            }
            catch
            {
                return "Bad String";
            }
        }

        #endregion

        #region QueuesAndStacks
        //https://www.hackerrank.com/challenges/30-queues-stacks/problem
        public Stack<char> stack = new Stack<char>();
        public Queue<char> queue = new Queue<char>();

        public void PushCharacter(char character)
        {
            stack.Push(character);
        }

        public void EnqueueCharacter(char character)
        {
            queue.Enqueue(character);
        }

        public char PopCharacter()
        {
            return stack.Pop();
        }

        public char DequeueCharacter()
        {
            return queue.Dequeue();
        }

        public string IsPalindrome(string input)
        {
            foreach (char character in input)
            {
                PushCharacter(character);
                EnqueueCharacter(character);
            }
            var isPalidrome = true;
            for (var i = 0; i < input.Length / 2; i++)
            {
                if (PopCharacter() != DequeueCharacter())
                {
                    isPalidrome = false;
                    break;
                }
            }
            if (isPalidrome)
            {
                return $"The word, { input }, is a palindrome.";
            }
            else
            {
                return $"The word, { input }, is not a palindrome.";
            }
            
        }
        #endregion

        #region Generics
        //https://www.hackerrank.com/challenges/30-generics/problem
        public void PrintArray<T>(T[] array)
        {
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }
        #endregion

        #region BinarySearchTrees
        //https://www.hackerrank.com/challenges/30-binary-search-trees/problem
        public TreeNode InsertIntoTree(TreeNode root, int data)
        {
            if (root == null)
            {
                return new TreeNode(data);
            }
            else
            {
                TreeNode current;
                if (data <= root.data)
                {
                    current = InsertIntoTree(root.left, data);
                    root.left = current;
                }
                else
                {
                    current = InsertIntoTree(root.right, data);
                    root.right = current;
                }
                return root;
            }
        }

        public int GetTreeHeight(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }
            int leftHeight = GetTreeHeight(root.left);
            int rightHeight = GetTreeHeight(root.right);
            int max = leftHeight >= rightHeight ? leftHeight : rightHeight;
            return max + 1;
        }
        #endregion

        #region BSTLevelOrderTraversal
        //https://www.hackerrank.com/challenges/30-binary-trees/problem
        public List<int> GetBreadthFirstAllNodesInTree(TreeNode root)
        {
            var result = new List<int>();
            var nodes = new Queue<TreeNode>(); 
            if (root != null)
            {
                nodes.Enqueue(root);
                while (nodes.Count > 0)
                {
                    TreeNode tree = nodes.Dequeue();
                    result.Add(tree.data);
                    if (tree.left != null)
                    {
                        nodes.Enqueue(tree.left);
                    }
                    if (tree.right != null)
                    {
                        nodes.Enqueue(tree.right);
                    }
                }
            }
            return result;
        }
        #endregion

        #region MoreLinkedLists
        //https://www.hackerrank.com/challenges/30-linked-list-deletion/problem
        public Node RemoveDuplicatesInLinkedList(Node head)
        {
            var uniqueData = new Dictionary<int, bool>();
            
            Node start = head;
            while (start != null)
            {
                int data = start.data;
                if (!uniqueData.ContainsKey(data))
                {
                    uniqueData.Add(data, true);
                }
                start = start.next;
            }
            var result = new Node(head.data);
            foreach (var data in uniqueData.Keys)
            {
                if (data != head.data)
                {
                    InsertNodeToLinkedList(result, data);
                }
            }
            return result;
        }
        #endregion

        #region RunningTimeAndComplexity
        //https://www.hackerrank.com/challenges/30-running-time-and-complexity/problem
        public string IsPrimeNumber(int number)
        {
            var notPrime = "Not prime";
            var prime = "Prime";
            if (number <= 1)
            {
                return notPrime;
            }
            if (number <= 3)
            {
                return prime;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return notPrime;
            }
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return notPrime;
                }
            }
            return prime;
        }
        #endregion

        #region NestedLogic
        //https://www.hackerrank.com/challenges/30-nested-logic/problem
        public int CalculateFineForLibraryBook(int returnedDay, int returnedMonth, int returnedYear, int expectedDay, int expectedMonth, int expectedYear)
        {
            var returnedDate = new DateTime(returnedYear, returnedMonth, returnedDay);
            var expectedDate = new DateTime(expectedYear, expectedMonth, expectedDay);
            if (returnedDate <= expectedDate)
            {
                return 0;
            }
            else if (returnedDate.Month == expectedDate.Month && returnedDate.Year == expectedDate.Year)
            {
                return 15 * (returnedDate.Day - expectedDate.Day);
            }
            else if (returnedDate.Year == expectedDate.Year)
            {
                return 500 * (returnedDate.Month - expectedDate.Month);
            }
            else
            {
                return 10000;
            }
        }
        #endregion

        #region RegExPatternsAndIntroToDatabases
        //https://www.hackerrank.com/challenges/30-regex-patterns/problem
        public List<String> GetAlphabeticallyOrderedListOfFirstNamesForEveryUserWithAGmailAccount(List<PersonalData> personalDataList)
        {
            var result = new List<string>();
            foreach (var personalData in personalDataList)
            {
                if (EmailEndsWithCommercialAtGmailDotCom(personalData.email))
                {
                    result.Add(personalData.name);
                }
            }
            result.Sort();
            return result;
        }

        public bool EmailEndsWithCommercialAtGmailDotCom(string email)
        {
            var regex = new Regex(@"\@gmail\.com$");
            MatchCollection matches = regex.Matches(email);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region BitwiseAND
        public int FindMaxPossibleValueOfBitwiseOperation(int rightSetBorder, int lessThanValue)
        {
            var bitwiseOperationResultsLessThanValue = new List<int>();
            for (var i = 1; i < rightSetBorder; i++)
            {
                for (var j = i + 1; j <= rightSetBorder; j++)
                {
                    int bitwiseOperationResult = i & j;
                    if (bitwiseOperationResult < lessThanValue)
                    {
                        bitwiseOperationResultsLessThanValue.Add(bitwiseOperationResult);
                    }
                }
            }
            return bitwiseOperationResultsLessThanValue.Max();
        }
        #endregion
    }
}




