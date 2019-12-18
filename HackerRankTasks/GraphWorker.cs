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
    }
}
