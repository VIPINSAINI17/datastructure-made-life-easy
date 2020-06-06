using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedAlgorithms.minimumcosttoreachlastcellinmatrix
{
    //int[][] array =
    //        {
    //            { 4, 7, 8, 6, 4 },
    //            { 6, 7, 3, 9, 2 },
    //            { 3, 8, 1, 2, 4 },
    //            { 7, 1, 7, 3, 7 },
    //            { 2, 9, 8, 9, 3 }
    //        };
    public class MinCostToReachLastCellInMatrix
    {

        public static int MinCostToReachLastCell(int[,] costMatrix, int row, int col)
        {

            if (row == -1 || col == -1)
            {
                return int.MaxValue;
            }

            if (row == 0 && col == 0)
            {
                return costMatrix[0, 0];
            }

            int c1 = MinCostToReachLastCell(costMatrix, row - 1, col); // up

            int c2 = MinCostToReachLastCell(costMatrix, row, col - 1); // left

            int minCost = Math.Min(c1, c2);

            int currentCell = costMatrix[row, col];

            return minCost + currentCell;
        }

        public static int MinCostToReachLastCell(int[,] costMatrix)
        {
            int row = costMatrix.GetLength(0);

            int col = costMatrix.GetLength(1);

            return MinCostToReachLastCell(costMatrix, row - 1, col - 1);
        }
    }
}
