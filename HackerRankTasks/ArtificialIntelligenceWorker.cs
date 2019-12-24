using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class ArtificialIntelligenceWorker
    {
        #region BotSavesPrincess
        //https://www.hackerrank.com/challenges/saveprincess?hr_b=1

        public struct Coordinates
        {
            public int absciss;
            public int ordinate;
            public int costToReach;

            public Coordinates(int absciss, int ordinate)
            {
                this.absciss = absciss;
                this.ordinate = ordinate;
                this.costToReach = 0;
            }

            public Coordinates(int absciss, int ordinate, int costToReach)
            {
                this.absciss = absciss;
                this.ordinate = ordinate;
                this.costToReach = costToReach;
            }
        }



        public Dictionary<int, Coordinates> CalculateCoordinates(String[] grid, string person)
        {
            var targets = new Dictionary<int, Coordinates>();
            var id = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == person[0])
                    {
                        targets.Add(id, new Coordinates(j, i));
                        id++;
                    }         
                }
            }
            return targets;

        }

        public void CalculateCoordinates(ref int verticalPosition, ref int horizontalPosition, String[] grid, string person)
        {
            for (var i = 0; i < grid.Length; i++)
            {
                if (grid[i].Contains(person))
                {
                    verticalPosition = i;
                    horizontalPosition = grid[i].IndexOf(person);
                }
            }
        }

        public List<string> AddResultToList(List<string> result, int difference, string word)
        {
            for (var i = 0; i < Math.Abs(difference); i++)
            {
                result.Add(word);
            }
            return result;
        }

        public List<string> CalculatePathToPrincess(String[] grid)
        {
            var result = new List<string>();
            var princessVerticalPosition = -1;
            var princessHorizontalPosition = -1;
            var manVerticalPosition = -1;
            var manHorizontalPosition = -1;
            CalculateCoordinates(ref princessVerticalPosition, ref princessHorizontalPosition, grid, "p");
            CalculateCoordinates(ref manVerticalPosition, ref manHorizontalPosition, grid, "m");
            int verticalDifference = princessVerticalPosition - manVerticalPosition;
            int horizontalDifference = princessHorizontalPosition - manHorizontalPosition;
            if (verticalDifference > 0)
            {
                result = AddResultToList(result, verticalDifference, "DOWN");
            }
            else if (verticalDifference < 0)
            {
                result = AddResultToList(result, verticalDifference, "UP");
            }
            if (horizontalDifference > 0)
            {
                result = AddResultToList(result, horizontalDifference, "RIGHT");
            }
            else if (horizontalDifference < 0)
            {
                result = AddResultToList(result, horizontalDifference, "LEFT");
            }
            return result;
        }
        #endregion

        #region BotSavesPrincess2
        //https://www.hackerrank.com/challenges/saveprincess2?hr_b=1
        public string NextMove(int gridSize, int row, int column, String[] grid)
        {
            var princessVerticalPosition = -1;
            var princessHorizontalPosition = -1;
            CalculateCoordinates(ref princessVerticalPosition, ref princessHorizontalPosition, grid, "p");
            int verticalDifference = princessVerticalPosition - row;
            int horizontalDifference = princessHorizontalPosition - column;
            if (horizontalDifference < 0)
            {
                return "LEFT";
            }
            if (horizontalDifference > 0)
            {
                return "RIGHT";
            }
            if (verticalDifference < 0)
            {
                return "UP";
            }
            if (verticalDifference > 0)
            {
                return "DOWN";
            }
            return String.Empty;
        }
        #endregion

        #region BotClean
        //https://www.hackerrank.com/challenges/botclean?hr_b=1
        public string NextCleanBotMove(int rowPosition, int columnPosition, String[] board)
        {
            if (board[rowPosition][columnPosition] == 'd')
            {
                return "CLEAN";
            }
            
            Dictionary<int, Coordinates> targets = CalculateCoordinates(board, "d");

            for (var i = 0; i < targets.Count; i++)
            {
                targets[i] = new Coordinates(targets[i].absciss, targets[i].ordinate, Math.Abs(targets[i].ordinate - rowPosition) + Math.Abs(targets[i].absciss - columnPosition));
            }

            
            var targetIdWithMinCost = -1;
            var minCost = int.MaxValue;
            foreach (var target in targets)
            {
                if (target.Value.costToReach < minCost)
                {
                    minCost = target.Value.costToReach;
                    targetIdWithMinCost = target.Key;
                }
            }
            int verticalDifference = targets[targetIdWithMinCost].ordinate - rowPosition;
            int horizontalDifference = targets[targetIdWithMinCost].absciss - columnPosition;
            
            if (horizontalDifference < 0)
            {
                    return "LEFT";
            }
            if (horizontalDifference > 0)
            {
                return "RIGHT";
            }
            
            
            if (verticalDifference < 0)
            {
                return "UP";
            }
            if (verticalDifference > 0)
            {
                return "DOWN";
            }
            
            return String.Empty;
        }
        #endregion
    }
}
