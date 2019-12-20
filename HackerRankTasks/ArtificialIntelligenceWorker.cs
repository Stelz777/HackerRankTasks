using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class ArtificialIntelligenceWorker
    {
        #region BotSavesPrincess
        public void CalculateCoordinates(ref int verticalPosition, ref int horizontalPosition, String[] grid, string person)
        {
            for (int i = 0; i < grid.Length; i++)
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
            for (int i = 0; i < Math.Abs(difference); i++)
            {
                result.Add(word);
            }
            return result;
        }

        public List<string> CalculatePathToPrincess(String[] grid)
        {
            var result = new List<string>();
            int princessVerticalPosition = -1;
            int princessHorizontalPosition = -1;
            int manVerticalPosition = -1;
            int manHorizontalPosition = -1;
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
    }
}
