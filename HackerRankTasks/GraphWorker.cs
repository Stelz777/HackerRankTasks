using HackerRankTasks.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankTasks
{
    public class GraphWorker
    {
        #region RoadsAndLibraries
        //https://www.hackerrank.com/challenges/torque-and-development/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=graphs
        public int GetRoot(int[] map, int index)
        {
            if (map[index] < 0)
            {
                return index;
            }
            else
            {
                return GetRoot(map, map[index]);
            }
        }

        public long CalculateBuildingCost(int citiesAmount, int libraryCost, int roadCost, int[][] cities)
        {
            var map = new int[citiesAmount];
            for (var i = 0; i < citiesAmount; i++)
            {
                map[i] = -1;
            }
            for (var i = 0; i < cities.Length; i++)
            {
                var firstCity = cities[i][0] - 1;
                var secondCity = cities[i][1] - 1;
                var firstRoot = GetRoot(map, firstCity);
                var secondRoot = GetRoot(map, secondCity);
                if (firstRoot != secondRoot)
                {
                    if (map[firstRoot] < map[secondRoot])
                    {
                        map[firstRoot] = map[firstRoot] + map[secondRoot];
                        map[secondRoot] = firstRoot;
                    }
                    else
                    {
                        map[secondRoot] = map[firstRoot] + map[secondRoot];
                        map[firstRoot] = secondRoot;
                    }
                }
            }
            var queue = new Queue<int>();
            for (var i = 0; i < citiesAmount; i++)
            {
                if (map[i] < 0)
                {
                    queue.Enqueue(map[i]);
                }
            }
            if (libraryCost > roadCost)
            {
                var sum = 0L;
                while (queue.Count > 0)
                {
                    sum += ((int)queue.Dequeue() + 1) * roadCost - libraryCost;
                }
                return -sum;
            }
            else
            {
                var sum = 0L;
                while (queue.Count > 0)
                {
                    sum += ((int)queue.Dequeue()) * libraryCost;
                }
                return -sum;
            }
        }
        #endregion

        #region FindTheNearestClone
        //https://www.hackerrank.com/challenges/find-the-nearest-clone/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=graphs
        Dictionary<int, Node> nodesGroup = new Dictionary<int, Node>();
        long[] colors;
        int[] nodesSource;
        int[] nodesTarget;

        public int FindRouteLengthToNodeWithTheSameColor(int nodesAmount, int[] nodesSource, int[] nodesTarget, long[] colors, int colorToMatch)
        {
            this.colors = colors;
            this.nodesSource = nodesSource;
            this.nodesTarget = nodesTarget;
            BuildGraph();
            var distances = new List<int>();
            foreach (var node in nodesGroup)
            {
                if (CheckNodeColor(node.Value, colorToMatch))
                {
                    var visitedNodes = new List<Node>();
                    visitedNodes.Add(node.Value);
                    int distance = 0;
                    distance = FindLeastDistanceToNodeWithTheSameColor(node.Value, visitedNodes, distance, colorToMatch);
                    if (distance == 1 || distance == -1)
                    {
                        return distance;
                    }
                    distances.Add(distance);
                    
                }
            }
            return distances.Min();
        }

        public int FindLeastDistanceToNodeWithTheSameColor(Node node, List<Node> visitedNodes, int distance, int colorToMatch)
        {
            distance++;
            var nodesToVisit = new List<Node>();
            foreach (var neighbor in node.neighbors)
            {
                if (!CheckVisited(visitedNodes, neighbor))
                {
                    visitedNodes.Add(neighbor);
                    nodesToVisit.Add(neighbor);
                    if (neighbor.color == colorToMatch)
                    {
                        return distance;
                    }
                }
            }
            foreach (var nodeToVisit in nodesToVisit)
            {
                int tempDistance = distance;
                distance = FindLeastDistanceToNodeWithTheSameColor(nodeToVisit, visitedNodes, distance, colorToMatch);
            }
            return -1;
        }

        public bool CheckVisited(List<Node> visitedNodes, Node currentNode)
        {
            foreach (var node in visitedNodes)
            {
                if (node == currentNode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckNodeColor(Node node, int colorToMatch)
        {
            if (node.color == colorToMatch)
            {
                return true;
            }
            return false;
        }

        public void BuildGraph()
        {
            for (int i = 0; i < colors.Length; i++)
            {
                Node node = CreateNode(i + 1, colors[i]);
                AddNodeToGroup(node, i + 1);
            }
            foreach (var node in nodesGroup)
            {
                CreateLinks(node);
            }
        }

        public void AddNodeToGroup(Node node, int nodeId)
        {
            if (!nodesGroup.ContainsKey(nodeId))
            {
                nodesGroup.Add(nodeId, node);
            }
        }

        public Node CreateNode(int nodeId, long color)
        {
            var node = new Node();
            node.id = nodeId;
            node.color = color;
            node.neighbors = new List<Node>();
            return node;
        }

        public void CreateLinks(KeyValuePair<int, Node> pair)
        {
            AddLinks(pair, nodesSource, nodesTarget);
            AddLinks(pair, nodesTarget, nodesSource);
        }

        public void AddLinks(KeyValuePair<int, Node> pair, int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (pair.Key == source[i])
                {
                    AddNodeToNeighbors(pair.Value, target[i]);
                }
            }
        }

        public void AddNodeToNeighbors(Node node, int nodeIdToAdd)
        {
            node.neighbors.Add(nodesGroup[nodeIdToAdd]);
        }
        #endregion

        #region DFSConnectedCellInAGrid
        //https://www.hackerrank.com/challenges/ctci-connected-cell-in-a-grid/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=graphs
        public void GenerateGroup(int[][] grid, bool[][] areVisited, ref int currentSize, int cellX, int cellY)
        {
            if (areVisited[cellX][cellY])
            {
                return;
            }
            else
            {
                areVisited[cellX][cellY] = true;
                if (grid[cellX][cellY] == 0)
                {
                    return;
                }
                else
                {
                    currentSize++;
                    if (cellY - 1 >= 0)
                    {
                        GenerateGroup(grid, areVisited, ref currentSize, cellX, cellY - 1);
                    }
                    if (cellX + 1 < grid.Length && cellY - 1 >= 0)
                    {
                        GenerateGroup(grid, areVisited, ref currentSize, cellX + 1, cellY - 1);
                    }
                    if (cellX + 1 < grid.Length)
                    {
                        GenerateGroup(grid, areVisited, ref currentSize, cellX + 1, cellY);
                    }
                    if (cellX + 1 < grid.Length && cellY + 1 < grid[cellX].Length)
                    {
                        GenerateGroup(grid, areVisited, ref currentSize, cellX + 1, cellY + 1);
                    }
                    if (cellY + 1 < grid[cellX].Length)
                    {
                        GenerateGroup(grid, areVisited, ref currentSize, cellX, cellY + 1);
                    }
                    if (cellX - 1 >= 0 && cellY + 1 < grid[cellX].Length)
                    {
                        GenerateGroup(grid, areVisited, ref currentSize, cellX - 1, cellY + 1);
                    }
                    if (cellX - 1 >= 0)
                    {
                        GenerateGroup(grid, areVisited, ref currentSize, cellX - 1, cellY);
                    }
                    if (cellX - 1 >= 0 && cellY - 1 >= 0)
                    {
                        GenerateGroup(grid, areVisited, ref currentSize, cellX - 1, cellY - 1);
                    }
                }
            }
        }
        
        public int CalculateMaxRegion(int[][] grid)
        {
            var areVisited = new bool[grid.Length][];
            InitAreVisited(areVisited, grid);
            var groups = new List<int>();
            var currentSize = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    GenerateGroup(grid, areVisited, ref currentSize, i, j);
                    groups.Add(currentSize);
                    currentSize = 0;
                }
            }
            return groups.Max();
        }

        public void InitAreVisited(bool[][] areVisited, int[][] grid)
        {
            for (var i = 0; i < areVisited.Length; i++)
            {
                areVisited[i] = new bool[grid[i].Length];
                for (var j = 0; j < areVisited[i].Length; j++)
                {
                    areVisited[i][j] = false;
                }
            }
        }
        #endregion
    }
}
