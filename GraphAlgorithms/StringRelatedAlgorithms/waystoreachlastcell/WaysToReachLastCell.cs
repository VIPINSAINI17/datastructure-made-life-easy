using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.waystoreachlastcell
{
    public class WaysToReachLastCell
    {
        public static int numberOfPaths(int[,] array, int row, int col, int cost)
        {
            int[,] dp = new int[row+1, col+1];
            return numberOfPathsAux(dp, array, row, col, cost);
        }// End of method


        public static int numberOfPathsAux(int[,] dp, int[,] array, int row, int col, int cost)
        {
            if (cost < 0)  // BASE CASE 
            {
                return 0;
            }
            if (row == 0 && col == 0)  // BASE CASE , We are on first cell
            { 
                return (array[0, 0] - cost == 0) ? 1 : 0;
            }
            if (dp[row, col] == 0) // If we have not solved this problem previously, only then solve it
            {
                if (row == 0) // BASE CASE: If we're at first row, we can only go left
                { 
                    dp[row, col] = numberOfPaths(array, 0, col - 1, cost - array[row, col]);
                }
                else if (col == 0) // BASE CASE: if we're at first column, we can only go up
                { 
                    dp[row, col] = numberOfPaths(array, row - 1, 0, cost - array[row, col]);
                }
                else
                {
                    int noOfPathsFromPreviousRow = numberOfPaths(array, row - 1, col, cost - array[row, col]); // Find Paths till last Row UP
                    int noOfPathsFromPreviousCol = numberOfPaths(array, row, col - 1, cost - array[row, col]); // Find Paths till last Col LEFT
                    dp[row, col] = noOfPathsFromPreviousRow + noOfPathsFromPreviousCol;
                }
            } // end of if-else block
            return dp[row, col];
        }// End of method


        public static int NumberOfPathsAux(int[,] costMatrix, int cost)
        {
            int row = costMatrix.GetLength(0);

            int col = costMatrix.GetLength(1);

            return numberOfPaths(costMatrix, row - 1, col - 1, cost);
        }
    }
}
