using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.minimumcosttoreachlastcellinmatrix
{
    public class Optimized_MinCostToReachLastCellInMatrix
    {
        public static int MinCostToReachLastCell(int[,] costMatrix, int row, int col, int[,] dp)
        {

            if (row == -1 || col == -1)
            {
                return int.MaxValue;
            }

            if (row == 0 && col == 0)
            {
                return costMatrix[0, 0];
            }

            if (dp[row, col] == 0)
            {
                int c1 = MinCostToReachLastCell(costMatrix, row - 1, col, dp); // up

                int c2 = MinCostToReachLastCell(costMatrix, row, col - 1, dp); // left

                int minCost = Math.Min(c1, c2);

                int currentCell = costMatrix[row, col];

                dp[row, col] = minCost + currentCell;
            }

            return dp[row, col];
        }

        public static int MinCostToReachLastCell(int[,] costMatrix)
        {
            int row = costMatrix.GetLength(0);

            int col = costMatrix.GetLength(1);

            int[,] dp = new int[row, col];

            return MinCostToReachLastCell(costMatrix, row - 1, col - 1, dp);
        }
    }
}
