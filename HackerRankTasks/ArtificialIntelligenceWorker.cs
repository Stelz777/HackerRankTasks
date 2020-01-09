using System;
using System.Collections.Generic;
using System.Linq;
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
            if (targetIdWithMinCost != -1)
            {
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
            }
            if (columnPosition == 0)
            {
                return "RIGHT";
            }
            if (columnPosition == board[0].Length - 1)
            {
                return "LEFT";
            }
            if (rowPosition == 0)
            {
                return "DOWN";
            }
            if (rowPosition == board.Length - 1)
            {
                return "UP";
            }
            if (columnPosition != 1 && columnPosition != board[0].Length - 2 && rowPosition != 1 && rowPosition != board.Length - 2)
            {
                return "RIGHT";
            }
            if (columnPosition == 1 && rowPosition == 1)
            {
                return "RIGHT";
            }
            if (columnPosition == board[0].Length - 2 && rowPosition == 1)
            {
                return "DOWN";
            }
            if (columnPosition == board[0].Length - 2 && rowPosition == board.Length - 2)
            {
                return "LEFT";
            }
            if (columnPosition == 1 && rowPosition == board.Length - 2)
            {
                return "UP";
            }
            if (columnPosition == 1)
            {
                return "UP";
            }
            if (rowPosition == 1)
            {
                return "RIGHT";
            }
            if (columnPosition == board[0].Length - 2)
            {
                return "DOWN";
            }
            if (rowPosition == board.Length - 2)
            {
                return "LEFT";
            }
            return String.Empty;
        }
        #endregion

        #region BotCleanStochastic
        //https://www.hackerrank.com/challenges/botcleanr/problem
        public string NextCleanBotStochasticMove(int rowPosition, int columnPosition, String[] board)
        {
            if (board[rowPosition][columnPosition] == 'd')
            {
                return "CLEAN";
            }
            var dirtyVerticalPosition = -1;
            var dirtyHorizontalPosition = -1;
            CalculateCoordinates(ref dirtyVerticalPosition, ref dirtyHorizontalPosition, board, "d");
            int verticalDifference = dirtyVerticalPosition - rowPosition;
            int horizontalDifference = dirtyHorizontalPosition - columnPosition;
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

        #region BotCleanLarge
        //https://www.hackerrank.com/challenges/botcleanlarge/problem
        public string NextMegaMaidMove(int rowPosition, int columnPosition, int dimensionHeight, int dimensionWidth, String[] board)
        {
            return NextCleanBotMove(rowPosition, columnPosition, board);
        }
        #endregion

        #region BotCleanPartiallyObservable
        //https://www.hackerrank.com/challenges/botcleanv2?hr_b=1
        public string NextPartiallyObservableMove(int rowPosition, int columnPosition, String[] board)
        {
            return NextCleanBotMove(rowPosition, columnPosition, board);
        }
        #endregion

        #region MazeEscape
        //https://www.hackerrank.com/challenges/maze-escape?hr_b=1
        public string direction = "NORTH";
        /*public string NextMoveInMaze(int rowPosition, int columnPosition, String[] board)
        {

        }*/
        #endregion
        


        #region ClickOMania
        //https://www.hackerrank.com/challenges/click-o-mania?hr_b=1
        public void CheckAdjacent(int rows, int columns, ref bool[,] areCheckedCells, ref int currentValue, String[] grid, int currentRow, int currentColumn)
        {
            currentValue++;
            areCheckedCells[currentRow, currentColumn] = true;
            if (currentColumn + 1 < columns)
            {
                if (grid[currentRow][currentColumn + 1] == grid[currentRow][currentColumn] && !areCheckedCells[currentRow, currentColumn + 1])
                {
                    CheckAdjacent(rows, columns, ref areCheckedCells, ref currentValue, grid, currentRow, currentColumn + 1);
                }
            }
            if (currentRow + 1 < rows)
            {
                if (grid[currentRow + 1][currentColumn] == grid[currentRow][currentColumn] && !areCheckedCells[currentRow + 1, currentColumn])
                {
                    CheckAdjacent(rows, columns, ref areCheckedCells, ref currentValue, grid, currentRow + 1, currentColumn);
                }
            }
            if (currentColumn - 1 >= 0)
            {
                if (grid[currentRow][currentColumn - 1] == grid[currentRow][currentColumn] && !areCheckedCells[currentRow, currentColumn - 1])
                {
                    CheckAdjacent(rows, columns, ref areCheckedCells, ref currentValue, grid, currentRow, currentColumn - 1);
                }
            }
            if (currentRow - 1 >= 0)
            {
                if (grid[currentRow - 1][currentColumn] == grid[currentRow][currentColumn] && !areCheckedCells[currentRow - 1, currentColumn])
                {
                    CheckAdjacent(rows, columns, ref areCheckedCells, ref currentValue, grid, currentRow - 1, currentColumn);
                }
            }
        }

        public int[] NextClick(int rows, int columns, int colorsAmount, String[] grid)
        {
            bool[,] areCheckedCells = new bool[rows, columns];
            var blocks = new Dictionary<int[], int>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i][j] != '-' && !areCheckedCells[i, j])
                    {
                        int currentValue = 0;
                        CheckAdjacent(rows, columns, ref areCheckedCells, ref currentValue, grid, i, j);
                        blocks.Add(new int[] { i, j }, currentValue);
                    }
                    
                }
            }
            var max = blocks.Aggregate((left, right) => left.Value > right.Value ? left : right).Key;
            return max;
        }
        #endregion
    }
}
